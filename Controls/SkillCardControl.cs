using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using TextBattleGame.Models;

namespace TextBattleGame.Controls
{
    public partial class SkillCardControl : UserControl
    {
        public SkillCardControl()
        {
            InitializeComponent();
        }

        public Skill? SkillData { get; private set; }   // 取得或設定目前卡片所顯示的技能
        /// <summary>
        /// 將技能資料套用至卡片介面
        /// </summary>
        /// <param name="skill">要顯示的技能資料</param>
        public void SetSkill(Skill skill)
        {
            ArgumentNullException.ThrowIfNull(skill);

            SkillData = skill;

            lbSkillName.Text = skill.Name;
            lbSkillDescription.Text = skill.Description;
            lbSkillMpCost.Text = $"MP消耗 : {skill.MpCost}";
        }

        public event EventHandler? SkillSelected;   // 當玩家點擊技能卡片時觸發

        /// <summary>
        /// 通知外部程式目前卡片的技能已被選取
        /// </summary>
        private void OnSkillSelected()
        {
            SkillSelected?.Invoke(this, EventArgs.Empty);
        }

        private void lbSkillName_Click(object sender, EventArgs e)
        {
            OnSkillSelected();
        }

        private void lbSkillDescription_Click(object sender, EventArgs e)
        {
            OnSkillSelected();
        }

        private void lbSkillMpCost_Click(object sender, EventArgs e)
        {
            OnSkillSelected();
        }

        private void SkillCardControl_Click(object sender, EventArgs e)
        {
            OnSkillSelected();
        }
    }
}
