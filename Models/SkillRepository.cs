using System;
using System.Collections.Generic;
using System.Text;

namespace TextBattleGame.Models
{
    /// <summary>
    /// 集中管理遊戲中的技能資料
    /// </summary>
    public class SkillRepository
    {
        /// <summary>
        /// 取得遊戲中預先定義的技能清單
        /// </summary>
        /// <returns>技能資料清單</returns>
        public List<Skill> GetAll()
        {
            List<Skill> skills = new() {
                new Skill(
                    id: 1,
                    name: "火球",
                    description: "造成小幅魔法傷害",
                    requiredLevel: 1,
                    mpCost: 8,
                    damageMultiplier: 1.5
                ),
                new Skill(
                    id: 2,
                    name: "火焰",
                    description: "造成小幅魔法傷害",
                    requiredLevel: 10,
                    mpCost: 15,
                    damageMultiplier: 2.5
                ),
            };
            

            return skills;
        }
    }
}
