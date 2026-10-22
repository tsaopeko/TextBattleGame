using System;
using System.Collections.Generic;
using System.Text;

namespace TextBattleGame.Models
{
    public class Enemy
    {
        // 怪物基本資料
        public string Name { get; }
        public int MaxHP { get; }
        public int Attack { get; }
        public int Defense { get; }
        public int ExperienceReward { get; }

        // 怪物目前生命值
        public int CurrentHP { get; internal set; }

        // 判斷怪物是否死亡
        public bool IsDead => CurrentHP <= 0;

        public Enemy(string name, int maxHP, int attack, int defense, int experienceReward)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("怪物名稱不能為空");
            }

            if(maxHP <= 0)
            {
                throw new ArgumentException("怪物最大生命值必須大於零");
            }

            if (attack < 0 || defense < 0 || experienceReward < 0)
            {
                throw new ArgumentException("攻擊力、防禦力和經驗值獎勵不能為負數");
            }

            Name = name;
            MaxHP = maxHP;
            Attack = attack;
            Defense = defense;
            ExperienceReward = experienceReward;
            CurrentHP = maxHP; // 初始化怪物的當前生命值為最大生命值
        }
    }
}
