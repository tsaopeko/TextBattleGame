using System;
using System.Collections.Generic;
using System.Text;

namespace TextBattleGame.Models
{
    public class Player
    {
        // 基本資料
        public string Name { get; private set; }
        public int Level { get; internal set; }
        public int Experience { get; internal set; }
        public int StatPoints { get; internal set; }

        // 基本能力值
        public int Strength { get; internal set; }
        public int Vitality { get; internal set; }
        public int Intelligence { get; internal set; }
        public int Dexterity { get; internal set; }

        // 目前生命值與魔力
        public int CurrentHP { get; internal set; }
        public int CurrentMP { get; internal set; }

        // 計算最大生命值與魔力
        public int MaxHP => 100 + (Vitality - 5) * 5 + (Level - 1) * 10;
        public int MaxMP => 50 + (Intelligence - 5) * 3 + (Level - 1) * 5;

        // 戰鬥數值
        public int PhysicalAttack => 10 + (Strength -5) * 5 + (Vitality - 5) * 2 + (Dexterity - 5) * 2 + (Level - 1) * 2;
        public int Defense => 5 + (Vitality - 5) * 2 + (Level - 1) * 2;
        public int MagicAttack => 10 + (Intelligence - 5) * 2;
        public double CriticalRate => Math.Min(100, 0 + Dexterity * 0.5);
        public int CriticalDamage => 150 + (Dexterity - 5) * 2;

        public Player(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("角色名稱不可為空", nameof(name));
            }

            Name = name.Trim();
            Level = 1;
            Experience = 0;
            StatPoints = 0;

            Strength = 5;
            Vitality = 5;
            Intelligence = 5;
            Dexterity = 5;

            CurrentHP = MaxHP;
            CurrentMP = MaxMP;
        }

        public void RestoreSaveData(string name, int level, int experience, int statPoints, int strength, int vitality, int intelligence, int dexterity)
        {
            // 驗證角色名稱
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("角色名稱不可為空", nameof(name));
            }

            // 驗證等級範圍
            if (level < 1 || level > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(level), "角色等級必須介於1到100");
            }

            // 驗證經驗值與能力點
            if(experience < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(experience), "經驗值不可為負數");
            }

            if(statPoints < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(statPoints), "能力點不可為負數");
            }

            // 驗證基本能力值
            if(strength < 5 || vitality < 5 || intelligence < 5 || dexterity < 5)
            {
                throw new ArgumentOutOfRangeException("能力值", "基本能力值不可低於初始值5");
            }

            // 還原角色基本資料
            Name = name.Trim();
            Level = level;
            Experience = experience;
            StatPoints = statPoints;

            // 還原四項基本能力值
            Strength = strength;
            Vitality = vitality;
            Intelligence = intelligence;
            Dexterity = dexterity;

            // 還原後恢復滿血滿魔
            CurrentHP = MaxHP;
            CurrentMP = MaxMP;
        }
    }
}
