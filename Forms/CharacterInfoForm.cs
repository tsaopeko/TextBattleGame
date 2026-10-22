using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TextBattleGame.Models;
using TextBattleGame.Systems;

namespace TextBattleGame.Forms
{
    public partial class CharacterInfoForm : Form
    {
        private readonly Player _player;
        private readonly ExperienceSystem _experienceSystem;
        private int _tempStrength;
        private int _tempVitality;
        private int _tempIntelligence;
        private int _tempDexterity;

        public CharacterInfoForm(Player player, ExperienceSystem experienceSystem)
        {
            InitializeComponent();

            _player = player ?? throw new ArgumentNullException(nameof(player));
            _experienceSystem = experienceSystem ?? throw new ArgumentNullException(nameof(experienceSystem));

            _tempStrength = _player.Strength;
            _tempVitality = _player.Vitality;
            _tempIntelligence = _player.Intelligence;
            _tempDexterity = _player.Dexterity;

            RefreshCharacterInfo();
            RefreshAllocationUI();
        }
        /// <summary>
        /// 重新整理角色完整能力屬性資訊
        /// </summary>
        private void RefreshCharacterInfo()
        {
            // 基本資訊
            lbCharacterName.Text = _player.Name;
            lbCharacterLevel.Text = $"Lv. {_player.Level}";
            lbCharacterEXP.Text = $"EXP {_player.Experience} / {_experienceSystem.GetRequiredExperience(_player.Level)}";

            // 能力值區
            lbAvailablePoints.Text = $"可用能力點數 : {_player.StatPoints}";

            lbStrengthValue.Text = _player.Strength.ToString();
            lbVitalityValue.Text = _player.Vitality.ToString();
            lbIntelligenceValue.Text = _player.Intelligence.ToString();
            lbDexterityValue.Text = _player.Dexterity.ToString();

            // 完整能力屬性
            lbFullLevel.Text = $"角色等級 : Lv. {_player.Level}";
            lbFullEXP.Text = $"經驗值 : {_player.Experience} / {_experienceSystem.GetRequiredExperience(_player.Level)}";
            lbFullHP.Text = $"生命值 : {_player.CurrentHP} / {_player.MaxHP}";
            lbFullMP.Text = $"魔力值 : {_player.CurrentMP} / {_player.MaxMP}";

            lbFullStrength.Text = $"力量 STR : {_player.Strength}";
            lbFullVitality.Text = $"體質 VIT : {_player.Vitality}";
            lbFullIntelligence.Text = $"智力 INT : {_player.Intelligence}";
            lbFullDexterity.Text = $"敏捷 DEX : {_player.Dexterity}";

            lbFullPhysicalAttack.Text = $"物理攻擊 : {_player.PhysicalAttack}";
            lbFullMagicAttack.Text = $"魔法攻擊 : {_player.MagicAttack}";
            lbFullDefense.Text = $"防禦力 : {_player.Defense}";
            lbFullCriticalRateAndDamage.Text = $"爆擊率 : {_player.CriticalRate:0.#}% / 爆擊傷害 : {_player.CriticalDamage}%";
        }
        /// <summary>
        /// 重新整理能力值分配區與剩餘點數的顯示資訊
        /// </summary>
        private void RefreshAllocationUI()
        {
            int usedPoints = (_tempStrength - _player.Strength)
                            + (_tempVitality - _player.Vitality)
                            + (_tempIntelligence - _player.Intelligence)
                            + (_tempDexterity - _player.Dexterity);
            // 計算尚未使用的能力點數
            int remainingPoints = _player.StatPoints - usedPoints;

            // 顯示剩餘能力點數
            lbAvailablePoints.Text = $"可用能力點數 : {remainingPoints}";

            // 顯示暫時分配的能力值
            lbStrengthValue.Text = _tempStrength.ToString();
            lbVitalityValue.Text = _tempVitality.ToString();
            lbIntelligenceValue.Text = _tempIntelligence.ToString();
            lbDexterityValue.Text = _tempDexterity.ToString();

            // 根據目前的分配狀態更新按鈕
            UpdateAllocationButtons();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 暫時增加能力值, 不會立即修改正式角色能力值
        /// </summary>
        /// <param name="stat">要增加的能力屬性</param>
        private void AddTemporaryStat(CharacterStat stat)
        {
            int usedPoints = (_tempStrength - _player.Strength)
                            + (_tempVitality - _player.Vitality)
                            + (_tempIntelligence - _player.Intelligence)
                            + (_tempDexterity - _player.Dexterity);
            // 沒有剩餘點數, 不允許再增加能力值
            if (usedPoints >= _player.StatPoints)
            {
                MessageBox.Show("目前沒有可用的能力點數", "能力分配", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            // 根據指定的能力屬性, 增加對應的暫時能力值
            switch (stat)
            {
                case CharacterStat.Strength:
                    _tempStrength++;
                    break;
                case CharacterStat.Vitality:
                    _tempVitality++;
                    break;
                case CharacterStat.Intelligence:
                    _tempIntelligence++;
                    break;
                case CharacterStat.Dexterity:
                    _tempDexterity++;
                    break;
            }

            // 更新能力數值, 剩餘點數及按鈕狀態
            RefreshAllocationUI();
        }

        private void btnAddStrength_Click(object sender, EventArgs e)
        {
            AddTemporaryStat(CharacterStat.Strength);
        }

        private void btnAddVitality_Click(object sender, EventArgs e)
        {
            AddTemporaryStat(CharacterStat.Vitality);
        }

        private void btnAddIntelligence_Click(object sender, EventArgs e)
        {
            AddTemporaryStat(CharacterStat.Intelligence);
        }

        private void btnAddDexterity_Click(object sender, EventArgs e)
        {
            AddTemporaryStat(CharacterStat.Dexterity);
        }
        /// <summary>
        /// 確認能力值分配, 將暫存的能力值套入正式角色的能力值
        /// </summary>
        private void btnConfirmAllocation_Click(object sender, EventArgs e)
        {
            int usedPoints = (_tempStrength - _player.Strength)
                            + (_tempVitality - _player.Vitality)
                            + (_tempIntelligence - _player.Intelligence)
                            + (_tempDexterity - _player.Dexterity);
            // 沒有暫時分配的能力值, 不需要確認
            if (usedPoints == 0)
            {
                MessageBox.Show("目前沒有需要確認的能力分配", "能力分配", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            // 記錄分配前的最大生命值與魔力值, 以便在分配後調整目前生命值與魔力值
            int oldMaxHP = _player.MaxHP;
            int oldMaxMP = _player.MaxMP;

            _player.Strength = _tempStrength;
            _player.Vitality = _tempVitality;
            _player.Intelligence = _tempIntelligence;
            _player.Dexterity = _tempDexterity;

            // 計算分配後的最大生命值與魔力值增加量
            int hpIncrease = _player.MaxHP - oldMaxHP;
            int mpIncrease = _player.MaxMP - oldMaxMP;

            // 將目前生命值與魔力值增加, 但不超過最大值
            _player.CurrentHP = Math.Min(_player.MaxHP, _player.CurrentHP + hpIncrease);
            _player.CurrentMP = Math.Min(_player.MaxMP, _player.CurrentMP + mpIncrease);

            // 扣除已使用的能力點數
            _player.StatPoints -= usedPoints;

            RefreshCharacterInfo();
            RefreshAllocationUI();

            MessageBox.Show("能力點數分配完成", "能力分配", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void btnUndoAllocation_Click(object sender, EventArgs e)
        {
            _tempStrength = _player.Strength;
            _tempVitality = _player.Vitality;
            _tempIntelligence = _player.Intelligence;
            _tempDexterity = _player.Dexterity;

            RefreshCharacterInfo();
            RefreshAllocationUI();
        }
        /// <summary>
        /// 根據剩餘能力點數與暫時分配狀態, 更新按鈕的啟用狀態
        /// </summary>
        private void UpdateAllocationButtons()
        {
            int usedPoints = (_tempStrength - _player.Strength)
                            + (_tempVitality - _player.Vitality)
                            + (_tempIntelligence - _player.Intelligence)
                            + (_tempDexterity - _player.Dexterity);
            // 計算剩餘可分配的點數
            int remainingPoints = _player.StatPoints - usedPoints;

            // 根據剩餘點數決定是否啟用增加能力值的按鈕
            bool canAllocate = remainingPoints > 0;
            btnAddStrength.Enabled = canAllocate;
            btnAddVitality.Enabled = canAllocate;
            btnAddIntelligence.Enabled = canAllocate;
            btnAddDexterity.Enabled = canAllocate;

            // 根據是否有暫時分配的能力值, 決定是否啟用確認與取消按鈕
            bool hasChanges = usedPoints > 0;
            btnConfirmAllocation.Enabled = hasChanges;
            btnUndoAllocation.Enabled = hasChanges;
        }
    }
}
