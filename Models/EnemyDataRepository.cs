using System;
using System.Collections.Generic;
using System.Text;

namespace TextBattleGame.Models
{
    /// <summary>
    /// 集中管理遊戲敵人資料，提供載入、儲存與查詢敵人定義與範本的介面。
    /// </summary>
    public class EnemyDataRepository
    {
        /// <summary>
        /// 傳回預先定義的敵人資料 (EnemyData) 範本清單，用於遊戲內建立或查詢敵人。
        /// </summary>
        /// <remarks>清單與其項目皆為新建立的實例；如需變更預設資料，請更新程式碼內的定義。</remarks>
        /// <returns>包含預先定義敵人範本的 List<EnemyData>。</returns>
        public List<EnemyData> GetAll()
        {
            List<EnemyData> enemyDatasList = new()
            {
                new EnemyData(
                        name: "綠史萊姆",
                        baseMaxHP: 100,
                        baseAttack: 10,
                        baseDefense: 5,
                        baseExperienceReward: 20,
                        isBoss: false,
                        stageHPGrowth: 100,
                        stageAttackGrowth: 20,
                        stageDefenseGrowth: 10,
                        stageExperienceGrowth: 10,
                        availableStages: new[] { 1,2,3,4}
                    ),
                new EnemyData(
                        name: "紅史萊姆",
                        baseMaxHP: 70,
                        baseAttack: 15,
                        baseDefense: 3,
                        baseExperienceReward: 20,
                        isBoss: false,
                        stageHPGrowth: 50,
                        stageAttackGrowth: 30,
                        stageDefenseGrowth: 5,
                        stageExperienceGrowth: 10,
                        availableStages: new[] { 1,2,3,4}
                    ),
                new EnemyData(
                        name: "藍史萊姆",
                        baseMaxHP: 120,
                        baseAttack: 7,
                        baseDefense: 7,
                        baseExperienceReward: 20,
                        isBoss: false,
                        stageHPGrowth: 150,
                        stageAttackGrowth: 14,
                        stageDefenseGrowth: 15,
                        stageExperienceGrowth: 10,
                        availableStages: new[] { 1,2,3,4}
                    ),
                new EnemyData(
                        name: "弓箭哥布林",
                        baseMaxHP: 100,
                        baseAttack: 12,
                        baseDefense: 3,
                        baseExperienceReward: 40,
                        isBoss: false,
                        stageHPGrowth: 200,
                        stageAttackGrowth: 36,
                        stageDefenseGrowth: 9,
                        stageExperienceGrowth: 10,
                        availableStages: new[] { 6,7,8,9}
                    ),
                new EnemyData(
                        name: "戰士哥布林",
                        baseMaxHP: 120,
                        baseAttack: 10,
                        baseDefense: 8,
                        baseExperienceReward: 40,
                        isBoss: false,
                        stageHPGrowth: 240,
                        stageAttackGrowth: 30,
                        stageDefenseGrowth: 24,
                        stageExperienceGrowth: 10,
                        availableStages: new[] { 6,7,8,9}
                    ),
                new EnemyData(
                        name: "盾牌哥布林",
                        baseMaxHP: 150,
                        baseAttack: 5,
                        baseDefense: 15,
                        baseExperienceReward: 20,
                        isBoss: false,
                        stageHPGrowth: 300,
                        stageAttackGrowth: 15,
                        stageDefenseGrowth: 45,
                        stageExperienceGrowth: 10,
                        availableStages: new[] { 6,7,8,9}
                    ),
                new EnemyData(
                        name: "史萊姆王",
                        baseMaxHP: 500,
                        baseAttack: 50,
                        baseDefense: 30,
                        baseExperienceReward: 200,
                        isBoss: true,
                        stageHPGrowth: 100,
                        stageAttackGrowth: 30,
                        stageDefenseGrowth: 20,
                        stageExperienceGrowth: 50
                    ),
                new EnemyData(
                        name: "哥布林酋長",
                        baseMaxHP: 700,
                        baseAttack: 100,
                        baseDefense: 60,
                        baseExperienceReward: 300,
                        isBoss: true,
                        stageHPGrowth: 150,
                        stageAttackGrowth: 40,
                        stageDefenseGrowth: 25,
                        stageExperienceGrowth: 70
                    )
            };

            ValidateEnemyData(enemyDatasList);

            return enemyDatasList;
        }

        /// <summary>
        /// 取得首領出現階段的設定, Key為首領出現階段, Value為首領名稱
        /// </summary>
        /// <returns>首領階段與首領名稱的對應資料</returns>
        public Dictionary<int, string> GetBossStageSettings()
        {
            // 集中設定那些階段會出現首領
            Dictionary<int, string> bossStageSettings = new()
            {
                { 5, "史萊姆王"},
                { 10, "哥布林酋長"}
            };
            // 取得怪物資料, GetAll()也會驗證怪物名稱是否重複
            List<EnemyData> enemyDataList = GetAll();
            // 驗證首領階段, 名稱, 以及對應的怪物資料
            ValidateBossStageSetting(enemyDataList, bossStageSettings);

            return bossStageSettings;
        }

        /// <summary>
        /// 驗證怪物資料是否有重複名稱或無效資料。
        /// </summary>
        /// <param name="enemyDataList">要檢查的怪物資料清單。</param>
        private static void ValidateEnemyData(List<EnemyData> enemyDataList)
        {
            HashSet<string> enemyNames = new(StringComparer.OrdinalIgnoreCase);

            foreach(EnemyData enemy in enemyDataList)
            {
                ArgumentNullException.ThrowIfNull(enemy);

                if(enemyNames.Add(enemy.Name) == false)
                {
                    throw new InvalidOperationException($"怪物名稱「{enemy.Name}」重複, 請使用不同的名稱");
                }
            }
        }

        /// <summary>
        /// 驗證首領階段設定是否與怪物資料一致
        /// </summary>
        /// <param name="enemyDataList">所有怪物的基礎資料</param>
        /// <param name="bossStageSettings">首領出現階段與怪物名稱的對應設定</param>
        private static void ValidateBossStageSetting(List<EnemyData> enemyDataList, Dictionary<int, string> bossStageSettings)
        {
            // 建立怪物名稱查詢表, 方便尋找對應資料
            Dictionary<string, EnemyData> enemyLookup = enemyDataList.ToDictionary(enemy => enemy.Name, StringComparer.OrdinalIgnoreCase);

            // 逐一檢查每個首領階段設定
            foreach(KeyValuePair<int,string> setting in bossStageSettings)
            {
                // 首領階段必須從1開始
                if(setting.Key < 1)
                {
                    throw new InvalidOperationException($"首領階段{setting.Key}無效, 階段必須大於或等於1");
                }
                // 檢查是否有填寫首領名稱
                if(string.IsNullOrWhiteSpace(setting.Value))
                {
                    throw new InvalidOperationException($"第{setting.Key}階段的首領名稱不可為空");
                }
                // 確認名稱存在於怪物資料中
                if(enemyLookup.TryGetValue(setting.Value, out EnemyData? bossData) == false)
                {
                    throw new InvalidOperationException($"第{setting.Key}階段設定的怪物「{setting.Value}」不存在");
                }
                // 確認該怪物確實是首領
                if(bossData.IsBoss == false)
                {
                    throw new InvalidOperationException($"怪物{bossData.Name}不是首領, 不能設定為首領階段");
                }
            }
        }
    }
}
