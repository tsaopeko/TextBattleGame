using System;
using System.Collections.Generic;
using System.Text;

namespace TextBattleGame.Models
{
    /// <summary>
    /// 儲存怪物的基礎設定資料, 不包含戰鬥中的即時狀態
    /// </summary>
    public class EnemyData
    {
        public string Name { get; } // 怪物名稱
        public int BaseMaxHp { get; }   // 怪物基礎最大生命值
        public int BaseAttack { get; }  // 怪物基礎攻擊力
        public int BaseDefence { get; } // 怪物的基礎防禦力
        public int BaseExperienceReward { get; }    // 擊殺怪物的基礎經驗值
        public bool IsBoss { get; } // 判斷是否為首領怪
        public int StageHPGrowth { get; }   // 每提升一個階段, 最大生命值增加的數值
        public int StageAttackGrowth { get; }   // 每提升一個階段, 攻擊力增加的數值
        public int StageDefenseGrowth { get; }  // 每提升一個階段, 防禦力增加的數值
        public int StageExperienceGrowth { get; }   // 每提升一個階段, 經驗值獎勵增加的數值
        public IReadOnlyList<int> AvailableStages { get; }  // 此普通怪物可以出現的遊戲階段
        public EnemyData(string name, int baseMaxHP, int baseAttack, int baseDefense, int baseExperienceReward, bool isBoss, 
            int stageHPGrowth, int stageAttackGrowth, int stageDefenseGrowth, int stageExperienceGrowth, IEnumerable<int>? availableStages = null)
        {
            VaildateData(name, baseMaxHP, baseAttack, baseDefense, baseExperienceReward, stageHPGrowth, stageAttackGrowth, stageDefenseGrowth, stageExperienceGrowth);
            Name = name;
            BaseMaxHp = baseMaxHP;
            BaseAttack = baseAttack;
            BaseDefence = baseDefense;
            BaseExperienceReward = baseExperienceReward;

            IsBoss = isBoss;
            StageHPGrowth = stageHPGrowth;
            StageAttackGrowth = stageAttackGrowth;
            StageDefenseGrowth = stageDefenseGrowth;
            StageExperienceGrowth = stageExperienceGrowth;

            // 首領的出現階段由首領階段設定管理, 普通怪物才使用此清單
            AvailableStages = availableStages?.ToArray() ?? Array.Empty<int>();
        }

        /// <summary>
        /// 驗證怪物基礎資料與階段成長設定
        /// </summary>
        private void VaildateData(string name, int baseMaxHP, int baseAttack, int baseDefense, int baseExperienceReward, int stageHPGrowth,
            int stageAttackGrowth, int stageDefenseGrowth, int stageExperienceGrowth)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("怪物名稱不可為空", nameof(name));
            }

            if(baseMaxHP <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(baseMaxHP), "基礎生命值必須大於0");
            }
            
            if(baseAttack < 0 || baseDefense < 0 || baseExperienceReward < 0)
            {
                throw new ArgumentException("攻擊力, 防禦力與經驗值獎勵不可為負數");
            }
            if(stageHPGrowth < 0 || stageAttackGrowth < 0 || stageDefenseGrowth < 0 || stageExperienceGrowth < 0)
            {
                throw new ArgumentException("階段成長不可為負數");
            }
        }
    }
}
