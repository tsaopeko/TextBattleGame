using System;
using System.Collections.Generic;
using System.Text;

namespace TextBattleGame.Models
{
    public class Skill
    {
        public int Id { get; }  // 技能識別碼
        public string Name { get; } // 技能名稱
        public string Description { get; }  // 技能說明
        public int MpCost { get; }  // 使用技能所需消耗的魔力值
        public double DamageMultiplier { get; } // 技能傷害倍率
        public int RequiredLevel { get; }   // 取得解鎖此技能所需的角色等級
        /// <summary>
        /// 初始化 Skill 的新實例，代表一個遊戲中的技能。
        /// </summary>
        public Skill(int id, string name, string description, int requiredLevel,int mpCost, double damageMultiplier)
        {
            Id = id;
            Name = name;
            Description = description;
            MpCost = mpCost;
            DamageMultiplier = damageMultiplier;
            RequiredLevel = requiredLevel;
        }
    }
}
