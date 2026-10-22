using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using TextBattleGame.Models;
namespace TextBattleGame.Systems
{
    /// <summary>
    /// 負責根據目前階段選擇怪物, 並建立符合階段強度的敵人
    /// </summary>
    public class EnemyGenerator
    {
        private readonly List<EnemyData> _enemyDataList;    // 儲存可供生成的怪物基礎資料
        private readonly Dictionary<int, EnemyData> _bossByStage = new();   // 儲存指定階段與首領怪物資料的對應關係

        /// <summary>
        /// 建立怪物生成器, 並接收由外部提供的怪物資料
        /// </summary>
        /// <param name="enemyDataList">由遊戲設計者設定的怪物資料清單</param>
        public EnemyGenerator(List<EnemyData> enemyDataList)
        {
            // 檢查傳入的怪物資料清單是否存在
            ArgumentNullException.ThrowIfNull(enemyDataList);

            // 確認至少有一筆怪物資料
            if(enemyDataList.Count == 0)
            {
                throw new ArgumentException("怪物資料清單不可為空", nameof(enemyDataList));
            }
            // 複製清單, 避免外部直接增刪原始清單影響生成器
            _enemyDataList = new List<EnemyData>(enemyDataList);

            // 檢查清單中是否有null或重複的怪物資料
            HashSet<string> enemyNames = new(StringComparer.OrdinalIgnoreCase);

            foreach(EnemyData? enemy in _enemyDataList)
            {
                // 不允許清單中出現null
                if(enemy is null)
                {
                    throw new ArgumentException("怪物資料清單不可包含null", nameof(enemyDataList));
                }
                // 不允許怪物名稱重複, 並忽略英文大小寫差異
                if (enemyNames.Add(enemy.Name) == false)
                {
                    throw new ArgumentException($"怪物名稱「{enemy.Name}」重複", nameof(enemyDataList));
                }
            }
        }

        /// <summary>
        /// 根據指定怪物資料與目前階段, 建立一隻新的敵人
        /// </summary>
        /// <param name="enemyData">怪物的基礎資料與階段成長</param>
        /// <param name="stage">目前的遊戲階段, 從1開始</param>
        /// <returns>能力值符合目前階段的新敵人</returns>
        public Enemy GenerateEnemy(EnemyData enemyData, int stage)
        {
            // 檢查怪物資料是否存在
            ArgumentNullException.ThrowIfNull(enemyData);

            // 階段必須從1開始
            if(stage < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(stage), "遊戲階段必須大於或等於1");
            }

            // 計算目前的階段相對於基礎階段的成長次數
            int growthCount = stage - 1;

            // 根據階段成長設定計算怪物的最終能力值
            int maxHP = CalculateStageValue(enemyData.BaseMaxHp, enemyData.StageHPGrowth, growthCount);
            int attack = CalculateStageValue(enemyData.BaseAttack, enemyData.StageAttackGrowth, growthCount);
            int defense = CalculateStageValue(enemyData.BaseDefence, enemyData.StageDefenseGrowth, growthCount);
            int experienceReward = CalculateStageValue(enemyData.BaseExperienceReward, enemyData.StageExperienceGrowth, growthCount);

            // 建立一隻符合目前階段能力值的敵人
            return new Enemy(name: enemyData.Name, maxHP: maxHP, attack: attack, defense: defense, experienceReward: experienceReward);
        }

        /// <summary>
        /// 從怪物資料清單中隨機選擇一隻非首領怪物
        /// </summary>
        /// <returns>隨機選出的普通怪物資料</returns>
        private EnemyData SelectRandomNormalEnemy(int stage)
        {
            // 篩選出所有非首領怪物
            List<EnemyData> availableEnemies = _enemyDataList.Where(enemy => enemy.IsBoss == false && enemy.AvailableStages.Contains(stage)).ToList();

            if (availableEnemies.Count == 0)
            {
                throw new InvalidOperationException($"第{stage}階段沒有可生成的普通怪物, 請檢查怪物資料設定");
            }

            // 隨機選擇一隻普通怪物
            int index = Random.Shared.Next(availableEnemies.Count);

            return availableEnemies[index];
        }

        /// <summary>
        /// 將首領設定到指定階段
        /// </summary>
        /// <param name="stage">首領出現的階段</param>
        /// <param name="bossData">首領的基礎資料</param>
        public void RegisterBoss(int stage, EnemyData bossData)
        {
            // 檢查階段是否有效
            if(stage < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(stage), "首領階段必須大於或等於1");
            }

            // 檢查首領資料是否存在
            ArgumentNullException.ThrowIfNull(bossData);

            // 確保登錄的資料確實是首領
            if(bossData.IsBoss == false)
            {
                throw new ArgumentException("指定的怪物資料不是首領", nameof(bossData));
            }   
            
            // 同一階段不允許重複登錄首領
            if(_bossByStage.TryAdd(stage, bossData) == false)
            {
                throw new InvalidOperationException($"第{stage}階段已經設定首領");
            }
        }

        /// <summary>
        /// 根據目前階段選擇首領或普通怪物, 並建立戰鬥用的敵人
        /// </summary>
        /// <param name="stage">目前的遊戲階段, 從1開始</param>
        /// <returns>符合目前階段設定的敵人</returns>
        public Enemy GenerateEnemyForStage(int stage)
        {
            // 檢查階段是否有效
            if(stage < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(stage), "遊戲階段必須大於或等於1");
            }

            // 如果目前階段有登錄首領, 就生成該首領
            if(_bossByStage.TryGetValue(stage, out EnemyData? bossData))
            {
                return GenerateEnemy(bossData, stage);
            }

            // 如果不是首領階段, 就隨機選擇普通怪物
            EnemyData normalEnemy = SelectRandomNormalEnemy(stage);

            // 根據目前階段計算能力值並建立敵人
            return GenerateEnemy(normalEnemy, stage);
        }

        /// <summary>
        /// 計算指定基礎數值與階段成長值的最終結果, 並檢查結果是否超出int可表示的範圍
        /// </summary>
        /// <param name="baseValue">基礎數值</param>
        /// <param name="growthValue">每階段增加的數值</param>
        /// <param name="growthCount">階段成長次數</param>
        /// <returns>計算完成的最終數值</returns>
        public static int CalculateStageValue(int baseValue, int growthValue, int growthCount)
        {
            long result = (long)baseValue + (long)growthCount * growthValue;

            if (result > int.MaxValue || result < int.MinValue)
            {
                throw new OverflowException("怪物階段成長數值超出int可表示的範圍");
            }
            return (int)result;
        }
    }
}
