using System;
using System.Collections.Generic;
using System.Text;
using TextBattleGame.Models;
namespace TextBattleGame.Systems
{
    public class ExperienceSystem
    {
        private readonly SkillSystem _skillSystem;  // 負責查詢技能資料與解鎖條件
        // 目前角色最高等級
        public const int MaxLevel = 100;

        /// <summary>
        /// 初始化經驗值系統
        /// </summary>
        /// <param name="skillSystem">技能系統</param>
        public ExperienceSystem(SkillSystem skillSystem)
        {
            _skillSystem = skillSystem ?? throw new ArgumentNullException(nameof(skillSystem));
        }
        /// <summary>
        /// 目前等級到下一級所需的經驗值
        /// </summary>
        /// <param name="level">等級</param>
        /// <returns>經驗值</returns>
        public int GetRequiredExperience(int level)
        {
            if(level < 1 || level >= MaxLevel)
            {
                return 0;
            }

            return level * 100;
        }
        /// <summary>
        /// 玩家獲得經驗值, 處理升級
        /// </summary>
        /// <param name="player">玩家角色</param>
        /// <param name="amount">獲得的經驗值</param>
        /// <param name="message">本次經驗值處理訊息</param>
        /// <param name="newlyUnlockedSkills">本次新解鎖的技能清單</param>
        /// <returns>等級數</returns>
        public int GainExperience(Player player, int amount, out string message, out List<Skill> newlyUnlockedSkills)
        {
            newlyUnlockedSkills = new List<Skill>();

            if (player == null)
            {
                message = "玩家資料不存在";
                return 0;
            }

            if(amount < 0)
            {
                message = "經驗值不能為負數";
                return 0;
            }    

            if (player.Level >= MaxLevel)
            {
                player.Experience = 0;
                message = "角色已達目前最高等級";
                return 0;
            }

            player.Experience += amount;
            int gainedLevels = 0;

            // 經驗值足夠時, 連續升級
            while(player.Level < MaxLevel)
            {
                int requiredExp = GetRequiredExperience(player.Level);

                if (player.Experience < requiredExp)
                {
                    break;
                }

                // 紀錄升級前的等級
                int previousLevel = player.Level;

                // 扣除經驗值
                player.Experience -= requiredExp;

                // 升級
                player.Level++;

                // 升級獲得5點能力值點數
                player.StatPoints += 5;

                // 升級後回復滿血滿魔
                player.CurrentHP = player.MaxHP;
                player.CurrentMP = player.MaxMP;

                List<Skill> unlockedSkills = _skillSystem.GetNewlyUnlockedSkills(previousLevel, player.Level);
                newlyUnlockedSkills.AddRange(unlockedSkills);

                gainedLevels++;
            }

            if(gainedLevels > 0)
            {
                message = $"升級!目前等級 : Lv.{player.Level}";
            }
            else
            {
                message = $"獲得{amount}點經驗值";
            }

            return gainedLevels;
        }

        /// <summary>
        /// 執行角色死亡時的經驗值懲罰
        /// </summary>
        /// <param name="player">死亡的玩家角色</param>
        /// <returns>本次扣除的經驗值</returns>
        public int ApplyDeathPenalty(Player player)
        {
            ArgumentNullException.ThrowIfNull(player);

            int currentExperience = player.Experience;

            int penalty = (int)(currentExperience * 0.2);

            player.Experience -= penalty;

            return penalty;
        }
    }
}
