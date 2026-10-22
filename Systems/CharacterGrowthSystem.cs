using System;
using System.Collections.Generic;
using System.Text;
using TextBattleGame.Models;

namespace TextBattleGame.Systems
{
    public enum CharacterStat
    {
        Strength,
        Vitality,
        Intelligence,
        Dexterity
    }
    public class CharacterGrowthSystem
    {
        public bool TryAllocatePoint(Player player, CharacterStat stat, out string message)
        {
            if (player == null)
            {
                message = "玩家資料不存在";
                return false;
            }

            if (player.StatPoints <= 0)
            {
                message = "沒有可用的能力值點數";
                return false;
            }

            switch(stat)
            {
                case CharacterStat.Strength:
                    player.Strength++;
                    break;
                case CharacterStat.Vitality:
                    player.Vitality++;
                    break;
                case CharacterStat.Intelligence:
                    player.Intelligence++;
                    break;
                case CharacterStat.Dexterity:
                    player.Dexterity++;
                    break;
                default:
                    message = "無效的能力值類型";
                    return false;
            }

            player.StatPoints--;

            message = "成功分配能力值點數";
            return true;
        }
    }
}
