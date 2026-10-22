using System;
using System.Collections.Generic;
using System.Text;
using TextBattleGame.Models;

namespace TextBattleGame.Systems
{
    /// <summary>
    /// 管理遊戲或應用程式內技能的註冊、查詢與執行流程。
    /// </summary>
    public class SkillSystem
    {
        private readonly List<Skill> _skills = new List<Skill>();   // 儲存目前遊戲中可使用的技能
        public IReadOnlyList<Skill> Skills => _skills;  // 取得目前已登錄的所有技能
        
        /// <summary>
        /// 登錄一個技能
        /// </summary>
        /// <param name="skill">要登錄的技能資料</param>
        public void AddSkill(Skill skill)
        {
            ArgumentNullException.ThrowIfNull(skill);

            // 避免重複登錄相同的技能ID
            if(_skills.Exists(existing => existing.Id == skill.Id))
            {
                throw new ArgumentException($"技能ID{skill.Id}已經存在", nameof(skill));
            }
            _skills.Add(skill);
        }

        /// <summary>
        /// 根據技能ID查詢技能
        /// </summary>
        /// <param name="id">技能識別碼</param>
        /// <returns>找到的技能, 找不到則回傳null</returns>
        public Skill? GetSkillById(int id)
        {
            return _skills.Find(skill => skill.Id == id);
        }

        /// <summary>
        /// 判斷玩家是否有足夠的魔力使用指定技能
        /// </summary>
        /// <param name="currentMP">玩家目前的魔力值</param>
        /// <param name="skill">要使用的技能</param>
        /// <returns>魔力足夠則回傳true, 否則回傳false</returns>
        public bool HasEnoughMP(int currentMP, Skill skill)
        {
            ArgumentNullException.ThrowIfNull(skill);

            return currentMP >= skill.MpCost;
        }

        /// <summary>
        /// 取得玩家目前等級已解鎖的所有技能
        /// </summary>
        /// <param name="playerLevel">玩家目前的等級</param>
        /// <returns>符合解鎖等及條件的技能清單</returns>
        public List<Skill> GetUnlockedSkills(int playerLevel)
        {
            return _skills.Where(skill => skill.RequiredLevel <= playerLevel).ToList();
        }

        /// <summary>
        /// 取得指定等級區間內新解鎖的技能
        /// </summary>
        /// <param name="previousLevel">升級前的等級</param>
        /// <param name="currentLevel">升級後的等級</param>
        /// <returns>在此等級區間內解鎖的技能清單</returns>
        public List<Skill> GetNewlyUnlockedSkills(int previousLevel, int currentLevel)
        {
            return _skills.Where(skill => skill.RequiredLevel > previousLevel && skill.RequiredLevel <= currentLevel).ToList();
        }
    }
}
