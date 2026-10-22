using System;
using System.Collections.Generic;
using System.Text;
using TextBattleGame.Models;

namespace TextBattleGame.Systems
{
    // 儲存單一回合的戰鬥結果
    public class BattleTurnResult
    {
        public int PlayerDamage { get; internal set; }
        public int EnemyDamage { get; internal set; }
        public bool IsCritical { get; internal set; }
        public bool EnemyIsDead { get; internal set; }
        public bool PlayerIsDead { get; internal set; }
        public bool PlayerFled { get; internal set; }
        public bool BattleEnded { get; internal set; }
        public int ExperienceGained { get; internal set; }
        public int LevelGained { get; internal set; }
        public string Message { get; internal set; } = string.Empty;
        public List<Skill> NewlyUnlockedSkills { get; set; } = new List<Skill>();   // 本次戰鬥結算時新解鎖的技能
    }
    public class BattleManager
    {
        private readonly Player _player;
        private readonly Enemy _enemy;
        private readonly ExperienceSystem _experienceSystem;
        private readonly int _startingMP;
        private bool _battleEnded;
        public bool IsBattleEnded => _battleEnded;  // 目前戰鬥是否已經結束
        private readonly Dictionary<int, int> _usedItems = new();   // 紀錄本場戰鬥使用的道具數量
        public BattleManager(Player player, Enemy enemy, ExperienceSystem experienceSystem)
        {
            _player = player ?? throw new ArgumentNullException(nameof(player));
            _enemy = enemy ?? throw new ArgumentNullException(nameof(enemy));
            _experienceSystem = experienceSystem ?? throw new ArgumentNullException(nameof(experienceSystem));
            _startingMP = _player.CurrentMP;

            if(_player.CurrentHP <= 0)
            {
                throw new ArgumentException("玩家HP必須大於0才能開始戰鬥", nameof(player));
            }

            if(_enemy.IsDead)
            {
                throw new ArgumentException("怪物HP必須大於0才能開始戰鬥", nameof(enemy));
            }     
        }

        public BattleTurnResult PlayerAttack()
        {
            var result = new BattleTurnResult();

            if(_battleEnded)
            {
                result.BattleEnded = true;
                result.Message = "戰鬥已結束";
                return result;
            }

            // 計算玩家攻擊傷害
            int damage = Math.Max(1, _player.PhysicalAttack - _enemy.Defense);

            // 判斷是否暴擊
            bool isCritical = new Random().NextDouble() * 100 < _player.CriticalRate;

            if (isCritical)
            {
                damage = Convert.ToInt32(Math.Round(damage * (_player.CriticalDamage / 100.0)));
            }

            // 扣除怪物生命值
            _enemy.CurrentHP = Math.Max(0, _enemy.CurrentHP - damage);
            result.PlayerDamage = damage;
            result.IsCritical = isCritical;

            // 判斷怪物是否死亡
            if (_enemy.IsDead)
            {
                result.EnemyIsDead = true;
                result.ExperienceGained = _enemy.ExperienceReward;

                result.LevelGained = _experienceSystem.GainExperience(_player, result.ExperienceGained, out string expMessage, out List<Skill> newlyUnlockedSkills);
                result.NewlyUnlockedSkills = newlyUnlockedSkills;

                _battleEnded = true;
                result.BattleEnded = true;

                result.Message = $"擊敗{_enemy.Name}！造成{damage}點傷害" + (isCritical ? "爆擊!" : "") + $", 獲得{result.ExperienceGained}點經驗" + (result.LevelGained > 0 ? $", 升級至Lv.{_player.Level}!" : "");
                return result;
            }

            // 怪物反擊
            int enemyDamage = Math.Max(1, _enemy.Attack - _player.Defense);
            _player.CurrentHP = Math.Max(0, _player.CurrentHP - enemyDamage);
            result.EnemyDamage = enemyDamage;

            // 判斷玩家是否死亡
            if (_player.CurrentHP <= 0)
            {
                _battleEnded = true;
                result.PlayerIsDead = true;
                result.BattleEnded = true;

                result.Message = $"你對{_enemy.Name}造成{damage}點傷害" + (isCritical ? "爆擊!" : "") + $", 你受到{enemyDamage}點反擊傷害, 死亡了";
                return result;
            }

            result.Message = $"你對{_enemy.Name}造成{damage}點傷害" + (isCritical ? "爆擊!" : "") + $", {_enemy.Name}反擊, 造成{enemyDamage}點傷害";
            return result;
        }

        /// <summary>
        /// 執行敵人反擊, 用於玩家使用道具等不會攻擊敵人的回合
        /// </summary>
        /// <returns>敵人反擊的戰鬥結果</returns>
        public BattleTurnResult EnemyCounterAttack()
        {
            var result = new BattleTurnResult();

            if (_battleEnded)
            {
                result.BattleEnded = true;
                result.Message = "戰鬥已結束";
                return result;
            }

            if(_enemy.IsDead)
            {
                _battleEnded = true;
                result.BattleEnded = true;
                result.EnemyIsDead = true;
                result.Message = $"{_enemy.Name}已被擊敗, 無法反擊";
                return result;
            }

            int enemyDamage = Math.Max(1, _enemy.Attack - _player.Defense);

            _player.CurrentHP = Math.Max(0, _player.CurrentHP - enemyDamage);

            result.EnemyDamage = enemyDamage;

            if(_player.CurrentHP <= 0)
            {
                _battleEnded = true;

                result.PlayerIsDead = true;
                result.BattleEnded = true;
                result.Message = $"{_enemy.Name}反擊, 造成{enemyDamage}點傷害, 你死亡了";
                return result;
            }

            result.Message = $"{_enemy.Name}反擊, 造成{enemyDamage}點傷害";

            return result;
        }
        
        /// <summary>
        /// 處理玩家逃跑, 立即結束本場戰鬥
        /// </summary>
        /// <returns>本次逃跑的戰鬥結果</returns>
        public BattleTurnResult Flee()
        {
            // 如果戰鬥已經結束, 不允許再次執行逃跑
            if (_battleEnded)
            {
                return new BattleTurnResult
                {
                    BattleEnded = true,
                    Message = "本場戰鬥已經結束, 無法再次逃跑"
                };
            }
            // 退還本場戰鬥消耗的MP
            int consumedMP = _startingMP - _player.CurrentMP;
            if(consumedMP > 0)
            {
                _player.CurrentMP += consumedMP;
            }
            // 標記戰鬥結束, 阻止後續攻擊
            _battleEnded = true;

            // 回傳逃跑成功的結果
            return new BattleTurnResult
            {
                PlayerFled = true,
                BattleEnded = true,
                Message = "你成功逃離了戰鬥"
            };
        }

        /// <summary>
        /// 處理玩家使用技能
        /// </summary>
        /// <param name="skill">技能資料</param>
        /// <returns>回傳使用完技能的戰鬥結果</returns>
        public BattleTurnResult UseSkill(Skill skill)
        {
            var result = new BattleTurnResult();

            // 1.確認戰鬥尚未結束
            if(_battleEnded)
            {
                result.BattleEnded = true;
                result.Message = "戰鬥已結束, 無法使用技能";
                return result;
            }

            // 2.確認技能資料存在
            if(skill is null)
            {
                result.Message = "技能資料不存在";
                return result;
            }

            // 3.確認玩家已經解鎖這個技能
            if(_player.Level < skill.RequiredLevel)
            {
                result.Message = "尚未解鎖此技能";
                return result;
            }

            // 4. MP不足時直接結束本次操作, 不消耗回合
            if(_player.CurrentMP < skill.MpCost)
            {
                result.Message = "MP不足, 無法使用此技能";
                return result;
            }

            _player.CurrentMP -= skill.MpCost;  // 5.扣除技能所需MP

            int damage = Math.Max(1, (int)Math.Floor(_player.MagicAttack * skill.DamageMultiplier));    // 6.計算魔法傷害

            _enemy.CurrentHP = Math.Max(0, _enemy.CurrentHP - damage);
            result.PlayerDamage = damage;

            // 7.如果怪物死亡, 直接結束戰鬥, 不進行反擊
            if(_enemy.IsDead)
            {
                result.EnemyIsDead = true;
                result.ExperienceGained = _enemy.ExperienceReward;

                result.LevelGained = _experienceSystem.GainExperience(_player, result.ExperienceGained, out string expMessage, out List<Skill> newlyUnlockedSkills);
                result.NewlyUnlockedSkills = newlyUnlockedSkills;

                _battleEnded = true;
                result.BattleEnded = true;

                result.Message = $"你使用「{skill.Name}」對{_enemy.Name}造成{damage}點魔法傷害, " + $"擊敗了{_enemy.Name}!獲得{result.ExperienceGained}點經驗";

                if(result.LevelGained > 0)
                {
                    result.Message += $"升級至Lv.{_player.Level}";
                }

                return result;
            }

            // 8.怪物存活時, 執行怪物反擊
            int enemyDamage = Math.Max(1, _enemy.Attack - _player.Defense);

            _player.CurrentHP = Math.Max(0, _player.CurrentHP - enemyDamage);
            result.EnemyDamage = enemyDamage;

            // 9.判斷玩家是否被反擊擊敗
            if(_player.CurrentHP <= 0)
            {
                _battleEnded = true;
                result.PlayerIsDead = true;
                result.BattleEnded = true;

                result.Message = $"你使用「{skill.Name}」對{_enemy.Name}造成{damage}點魔法傷害, " + $"但遭到反擊, 受到{enemyDamage}點傷害, 角色死亡了";

                return result;
            }

            // 10.雙方都存活, 繼續戰鬥
            result.Message = $"你使用「{skill.Name}」對{_enemy.Name}造成{damage}點魔法傷害, " + $"{_enemy.Name}反擊, 造成{enemyDamage}點傷害";

            return result;
        }

        /// <summary>
        /// 紀錄本場戰鬥使用的道具
        /// </summary>
        /// <param name="itemId">道具編號</param>
        public void RecordItemUsed(int itemId)
        {
            if (itemId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(itemId));
            }

            if(_usedItems.ContainsKey(itemId))
            {
                _usedItems[itemId]++;
            }    
            else
            {
                _usedItems[itemId] = 1;
            }
        }

        /// <summary>
        /// 退還本場戰鬥使用的所有道具
        /// </summary>
        /// <param name="inventorySystem">玩家背包系統</param>
        public void RefundUsedItems(InventorySystem inventorySystem)
        {
            ArgumentNullException.ThrowIfNull(inventorySystem);

            foreach(KeyValuePair<int, int> usedItem in _usedItems)
            {
                inventorySystem.RefundItem(usedItem.Key, usedItem.Value);
            }

            _usedItems.Clear(); // 清除本場戰鬥的道具使用紀錄
        }
    }
}
