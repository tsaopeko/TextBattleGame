using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TextBattleGame.Controls;
using TextBattleGame.Models;
using TextBattleGame.Systems;

namespace TextBattleGame.Forms
{
    public partial class SkillSelectForm : Form
    {
        private readonly Player _player;    // 目前正在選擇的玩家
        private readonly SkillSystem _skillSystem;  // 負責管理技能資料的系統
        public Skill? SelectedSkill { get; private set; }   // 取得玩家在技能選擇視窗中選取的技能
        public SkillSelectForm(Player player, SkillSystem skillSystem)
        {
            InitializeComponent();

            _player = player ?? throw new ArgumentNullException(nameof(player));
            _skillSystem = skillSystem ?? throw new ArgumentNullException(nameof(skillSystem));

            //LoadUnlockedSkills();
            try
            {
                LoadUnlockedSkills();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"載入技能卡片時發生錯誤：\n{ex}",
                    "技能載入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 載入玩家目前已解鎖的技能卡片
        /// </summary>
        private void LoadUnlockedSkills()
        {
            flpSkillList.Controls.Clear();

            List<Skill> unlockedSkills = _skillSystem.GetUnlockedSkills(_player.Level);

            foreach (Skill skill in unlockedSkills)
            {
                SkillCardControl skillCard = new SkillCardControl();

                skillCard.SetSkill(skill);

                skillCard.SkillSelected += SkillCard_SkillSelected;

                flpSkillList.Controls.Add(skillCard);
            }
        }

        private void SkillCard_SkillSelected(object? sender, EventArgs e)
        {
            if(sender is not SkillCardControl skillCard)
            {
                return;
            }

            if(skillCard.SkillData is null)
            {
                return;
            }

            SelectedSkill = skillCard.SkillData;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
