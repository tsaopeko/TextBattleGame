namespace TextBattleGame.Forms
{
    partial class CharacterInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            btnClose = new Button();
            lbHeaderTitle = new Label();
            pnlCharacterMain = new Panel();
            pnlFullStats = new Panel();
            lbFullCriticalRateAndDamage = new Label();
            lbFullDefense = new Label();
            lbFullMagicAttack = new Label();
            lbFullPhysicalAttack = new Label();
            lbFullDexterity = new Label();
            lbFullIntelligence = new Label();
            lbFullVitality = new Label();
            lbFullStrength = new Label();
            lbFullMP = new Label();
            lbFullHP = new Label();
            lbFullEXP = new Label();
            lbFullLevel = new Label();
            lbFullStatsTitle = new Label();
            pnlCombatAllocation = new Panel();
            btnUndoAllocation = new Button();
            btnConfirmAllocation = new Button();
            btnAddDexterity = new Button();
            btnAddIntelligence = new Button();
            btnAddVitality = new Button();
            btnAddStrength = new Button();
            lbDexterityValue = new Label();
            lbIntelligenceValue = new Label();
            lbVitalityValue = new Label();
            lbStrengthValue = new Label();
            lbDexterity = new Label();
            lbIntelligence = new Label();
            lbVitality = new Label();
            lbStrength = new Label();
            lbAvailablePoints = new Label();
            lbCombatAllocationTitle = new Label();
            pnlBasicInfo = new Panel();
            lbCharacterEXP = new Label();
            lbCharacterLevel = new Label();
            lbCharacterName = new Label();
            lbBasicInfoTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlCharacterMain.SuspendLayout();
            pnlFullStats.SuspendLayout();
            pnlCombatAllocation.SuspendLayout();
            pnlBasicInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(38, 42, 54);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(lbHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(16, 0, 0, 0);
            pnlHeader.Size = new Size(782, 50);
            pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(52, 56, 70);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 55, 68);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 82, 96);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold);
            btnClose.Location = new Point(732, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lbHeaderTitle
            // 
            lbHeaderTitle.Dock = DockStyle.Left;
            lbHeaderTitle.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold);
            lbHeaderTitle.Location = new Point(16, 0);
            lbHeaderTitle.Name = "lbHeaderTitle";
            lbHeaderTitle.Size = new Size(110, 50);
            lbHeaderTitle.TabIndex = 0;
            lbHeaderTitle.Text = "角色資訊";
            lbHeaderTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCharacterMain
            // 
            pnlCharacterMain.AutoScroll = true;
            pnlCharacterMain.Controls.Add(pnlFullStats);
            pnlCharacterMain.Controls.Add(pnlCombatAllocation);
            pnlCharacterMain.Controls.Add(pnlBasicInfo);
            pnlCharacterMain.Dock = DockStyle.Fill;
            pnlCharacterMain.Location = new Point(0, 50);
            pnlCharacterMain.Margin = new Padding(0);
            pnlCharacterMain.Name = "pnlCharacterMain";
            pnlCharacterMain.Padding = new Padding(20, 16, 20, 16);
            pnlCharacterMain.Size = new Size(782, 830);
            pnlCharacterMain.TabIndex = 1;
            // 
            // pnlFullStats
            // 
            pnlFullStats.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFullStats.BackColor = Color.FromArgb(34, 38, 49);
            pnlFullStats.Controls.Add(lbFullCriticalRateAndDamage);
            pnlFullStats.Controls.Add(lbFullDefense);
            pnlFullStats.Controls.Add(lbFullMagicAttack);
            pnlFullStats.Controls.Add(lbFullPhysicalAttack);
            pnlFullStats.Controls.Add(lbFullDexterity);
            pnlFullStats.Controls.Add(lbFullIntelligence);
            pnlFullStats.Controls.Add(lbFullVitality);
            pnlFullStats.Controls.Add(lbFullStrength);
            pnlFullStats.Controls.Add(lbFullMP);
            pnlFullStats.Controls.Add(lbFullHP);
            pnlFullStats.Controls.Add(lbFullEXP);
            pnlFullStats.Controls.Add(lbFullLevel);
            pnlFullStats.Controls.Add(lbFullStatsTitle);
            pnlFullStats.Location = new Point(20, 500);
            pnlFullStats.Margin = new Padding(0, 12, 0, 0);
            pnlFullStats.Name = "pnlFullStats";
            pnlFullStats.Padding = new Padding(16, 12, 16, 12);
            pnlFullStats.Size = new Size(739, 300);
            pnlFullStats.TabIndex = 2;
            // 
            // lbFullCriticalRateAndDamage
            // 
            lbFullCriticalRateAndDamage.BackColor = Color.Transparent;
            lbFullCriticalRateAndDamage.Font = new Font("Microsoft JhengHei UI", 9F);
            lbFullCriticalRateAndDamage.ForeColor = Color.FromArgb(210, 214, 224);
            lbFullCriticalRateAndDamage.Location = new Point(310, 234);
            lbFullCriticalRateAndDamage.Name = "lbFullCriticalRateAndDamage";
            lbFullCriticalRateAndDamage.Size = new Size(270, 26);
            lbFullCriticalRateAndDamage.TabIndex = 12;
            lbFullCriticalRateAndDamage.Text = "暴擊：5% ／ 150%";
            lbFullCriticalRateAndDamage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbFullDefense
            // 
            lbFullDefense.BackColor = Color.Transparent;
            lbFullDefense.Font = new Font("Microsoft JhengHei UI", 9F);
            lbFullDefense.ForeColor = Color.FromArgb(210, 214, 224);
            lbFullDefense.Location = new Point(16, 234);
            lbFullDefense.Name = "lbFullDefense";
            lbFullDefense.Size = new Size(270, 26);
            lbFullDefense.TabIndex = 11;
            lbFullDefense.Text = "防禦力：5";
            lbFullDefense.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbFullMagicAttack
            // 
            lbFullMagicAttack.BackColor = Color.Transparent;
            lbFullMagicAttack.Font = new Font("Microsoft JhengHei UI", 9F);
            lbFullMagicAttack.ForeColor = Color.FromArgb(210, 214, 224);
            lbFullMagicAttack.Location = new Point(310, 200);
            lbFullMagicAttack.Name = "lbFullMagicAttack";
            lbFullMagicAttack.Size = new Size(270, 26);
            lbFullMagicAttack.TabIndex = 10;
            lbFullMagicAttack.Text = "魔法攻擊：20";
            lbFullMagicAttack.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbFullPhysicalAttack
            // 
            lbFullPhysicalAttack.BackColor = Color.Transparent;
            lbFullPhysicalAttack.Font = new Font("Microsoft JhengHei UI", 9F);
            lbFullPhysicalAttack.ForeColor = Color.FromArgb(210, 214, 224);
            lbFullPhysicalAttack.Location = new Point(16, 200);
            lbFullPhysicalAttack.Name = "lbFullPhysicalAttack";
            lbFullPhysicalAttack.Size = new Size(270, 26);
            lbFullPhysicalAttack.TabIndex = 9;
            lbFullPhysicalAttack.Text = "物理攻擊：20";
            lbFullPhysicalAttack.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbFullDexterity
            // 
            lbFullDexterity.BackColor = Color.Transparent;
            lbFullDexterity.Font = new Font("Microsoft JhengHei UI", 9F);
            lbFullDexterity.ForeColor = Color.FromArgb(210, 214, 224);
            lbFullDexterity.Location = new Point(310, 158);
            lbFullDexterity.Name = "lbFullDexterity";
            lbFullDexterity.Size = new Size(270, 26);
            lbFullDexterity.TabIndex = 8;
            lbFullDexterity.Text = "敏捷 DEX：5";
            lbFullDexterity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbFullIntelligence
            // 
            lbFullIntelligence.BackColor = Color.Transparent;
            lbFullIntelligence.Font = new Font("Microsoft JhengHei UI", 9F);
            lbFullIntelligence.ForeColor = Color.FromArgb(210, 214, 224);
            lbFullIntelligence.Location = new Point(16, 158);
            lbFullIntelligence.Name = "lbFullIntelligence";
            lbFullIntelligence.Size = new Size(270, 26);
            lbFullIntelligence.TabIndex = 7;
            lbFullIntelligence.Text = "智力 INT：5";
            lbFullIntelligence.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbFullVitality
            // 
            lbFullVitality.BackColor = Color.Transparent;
            lbFullVitality.Font = new Font("Microsoft JhengHei UI", 9F);
            lbFullVitality.ForeColor = Color.FromArgb(210, 214, 224);
            lbFullVitality.Location = new Point(310, 124);
            lbFullVitality.Name = "lbFullVitality";
            lbFullVitality.Size = new Size(270, 26);
            lbFullVitality.TabIndex = 6;
            lbFullVitality.Text = "體質 VIT：5";
            lbFullVitality.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbFullStrength
            // 
            lbFullStrength.BackColor = Color.Transparent;
            lbFullStrength.Font = new Font("Microsoft JhengHei UI", 9F);
            lbFullStrength.ForeColor = Color.FromArgb(210, 214, 224);
            lbFullStrength.Location = new Point(16, 124);
            lbFullStrength.Name = "lbFullStrength";
            lbFullStrength.Size = new Size(270, 26);
            lbFullStrength.TabIndex = 5;
            lbFullStrength.Text = "力量 STR：5";
            lbFullStrength.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbFullMP
            // 
            lbFullMP.BackColor = Color.Transparent;
            lbFullMP.Font = new Font("Microsoft JhengHei UI", 9F);
            lbFullMP.ForeColor = Color.FromArgb(210, 214, 224);
            lbFullMP.Location = new Point(310, 82);
            lbFullMP.Name = "lbFullMP";
            lbFullMP.Size = new Size(270, 26);
            lbFullMP.TabIndex = 4;
            lbFullMP.Text = "魔力值：50 / 50";
            lbFullMP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbFullHP
            // 
            lbFullHP.BackColor = Color.Transparent;
            lbFullHP.Font = new Font("Microsoft JhengHei UI", 9F);
            lbFullHP.ForeColor = Color.FromArgb(210, 214, 224);
            lbFullHP.Location = new Point(16, 82);
            lbFullHP.Name = "lbFullHP";
            lbFullHP.Size = new Size(270, 26);
            lbFullHP.TabIndex = 3;
            lbFullHP.Text = "生命值：100 / 100";
            lbFullHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbFullEXP
            // 
            lbFullEXP.BackColor = Color.Transparent;
            lbFullEXP.Font = new Font("Microsoft JhengHei UI", 9F);
            lbFullEXP.ForeColor = Color.FromArgb(210, 214, 224);
            lbFullEXP.Location = new Point(310, 48);
            lbFullEXP.Name = "lbFullEXP";
            lbFullEXP.Size = new Size(270, 26);
            lbFullEXP.TabIndex = 2;
            lbFullEXP.Text = "經驗值：0 / 100";
            lbFullEXP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbFullLevel
            // 
            lbFullLevel.BackColor = Color.Transparent;
            lbFullLevel.Font = new Font("Microsoft JhengHei UI", 9F);
            lbFullLevel.ForeColor = Color.FromArgb(210, 214, 224);
            lbFullLevel.Location = new Point(16, 48);
            lbFullLevel.Name = "lbFullLevel";
            lbFullLevel.Size = new Size(270, 26);
            lbFullLevel.TabIndex = 1;
            lbFullLevel.Text = "角色等級：Lv. 1";
            lbFullLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbFullStatsTitle
            // 
            lbFullStatsTitle.AutoSize = true;
            lbFullStatsTitle.BackColor = Color.Transparent;
            lbFullStatsTitle.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbFullStatsTitle.Location = new Point(16, 12);
            lbFullStatsTitle.Name = "lbFullStatsTitle";
            lbFullStatsTitle.Size = new Size(92, 18);
            lbFullStatsTitle.TabIndex = 0;
            lbFullStatsTitle.Text = "完整能力屬性";
            // 
            // pnlCombatAllocation
            // 
            pnlCombatAllocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCombatAllocation.BackColor = Color.FromArgb(34, 38, 49);
            pnlCombatAllocation.Controls.Add(btnUndoAllocation);
            pnlCombatAllocation.Controls.Add(btnConfirmAllocation);
            pnlCombatAllocation.Controls.Add(btnAddDexterity);
            pnlCombatAllocation.Controls.Add(btnAddIntelligence);
            pnlCombatAllocation.Controls.Add(btnAddVitality);
            pnlCombatAllocation.Controls.Add(btnAddStrength);
            pnlCombatAllocation.Controls.Add(lbDexterityValue);
            pnlCombatAllocation.Controls.Add(lbIntelligenceValue);
            pnlCombatAllocation.Controls.Add(lbVitalityValue);
            pnlCombatAllocation.Controls.Add(lbStrengthValue);
            pnlCombatAllocation.Controls.Add(lbDexterity);
            pnlCombatAllocation.Controls.Add(lbIntelligence);
            pnlCombatAllocation.Controls.Add(lbVitality);
            pnlCombatAllocation.Controls.Add(lbStrength);
            pnlCombatAllocation.Controls.Add(lbAvailablePoints);
            pnlCombatAllocation.Controls.Add(lbCombatAllocationTitle);
            pnlCombatAllocation.Location = new Point(20, 148);
            pnlCombatAllocation.Margin = new Padding(0, 0, 0, 12);
            pnlCombatAllocation.Name = "pnlCombatAllocation";
            pnlCombatAllocation.Padding = new Padding(16, 12, 16, 12);
            pnlCombatAllocation.Size = new Size(740, 340);
            pnlCombatAllocation.TabIndex = 1;
            // 
            // btnUndoAllocation
            // 
            btnUndoAllocation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUndoAllocation.BackColor = Color.FromArgb(42, 47, 60);
            btnUndoAllocation.Cursor = Cursors.Hand;
            btnUndoAllocation.FlatAppearance.BorderColor = Color.FromArgb(70, 77, 94);
            btnUndoAllocation.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 38, 49);
            btnUndoAllocation.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 64, 80);
            btnUndoAllocation.FlatStyle = FlatStyle.Flat;
            btnUndoAllocation.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            btnUndoAllocation.ForeColor = Color.FromArgb(210, 214, 224);
            btnUndoAllocation.Location = new Point(600, 278);
            btnUndoAllocation.Margin = new Padding(0);
            btnUndoAllocation.Name = "btnUndoAllocation";
            btnUndoAllocation.Padding = new Padding(4, 2, 4, 2);
            btnUndoAllocation.Size = new Size(100, 40);
            btnUndoAllocation.TabIndex = 15;
            btnUndoAllocation.Text = "復原";
            btnUndoAllocation.UseVisualStyleBackColor = false;
            btnUndoAllocation.Click += btnUndoAllocation_Click;
            // 
            // btnConfirmAllocation
            // 
            btnConfirmAllocation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmAllocation.BackColor = Color.FromArgb(76, 61, 145);
            btnConfirmAllocation.Cursor = Cursors.Hand;
            btnConfirmAllocation.FlatAppearance.BorderColor = Color.FromArgb(124, 92, 252);
            btnConfirmAllocation.FlatAppearance.MouseDownBackColor = Color.FromArgb(57, 45, 110);
            btnConfirmAllocation.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 75, 180);
            btnConfirmAllocation.FlatStyle = FlatStyle.Flat;
            btnConfirmAllocation.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            btnConfirmAllocation.Location = new Point(450, 278);
            btnConfirmAllocation.Margin = new Padding(0);
            btnConfirmAllocation.Name = "btnConfirmAllocation";
            btnConfirmAllocation.Padding = new Padding(4, 2, 4, 2);
            btnConfirmAllocation.Size = new Size(130, 40);
            btnConfirmAllocation.TabIndex = 14;
            btnConfirmAllocation.Text = "確認分配";
            btnConfirmAllocation.UseVisualStyleBackColor = false;
            btnConfirmAllocation.Click += btnConfirmAllocation_Click;
            // 
            // btnAddDexterity
            // 
            btnAddDexterity.BackColor = Color.FromArgb(124, 92, 252);
            btnAddDexterity.Cursor = Cursors.Hand;
            btnAddDexterity.Enabled = false;
            btnAddDexterity.FlatAppearance.BorderSize = 0;
            btnAddDexterity.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 69, 210);
            btnAddDexterity.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 121, 255);
            btnAddDexterity.FlatStyle = FlatStyle.Flat;
            btnAddDexterity.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            btnAddDexterity.Location = new Point(650, 225);
            btnAddDexterity.Name = "btnAddDexterity";
            btnAddDexterity.Size = new Size(34, 34);
            btnAddDexterity.TabIndex = 13;
            btnAddDexterity.Text = "+";
            btnAddDexterity.UseVisualStyleBackColor = false;
            btnAddDexterity.Click += btnAddDexterity_Click;
            // 
            // btnAddIntelligence
            // 
            btnAddIntelligence.BackColor = Color.FromArgb(124, 92, 252);
            btnAddIntelligence.Cursor = Cursors.Hand;
            btnAddIntelligence.FlatAppearance.BorderSize = 0;
            btnAddIntelligence.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 69, 210);
            btnAddIntelligence.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 121, 255);
            btnAddIntelligence.FlatStyle = FlatStyle.Flat;
            btnAddIntelligence.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            btnAddIntelligence.Location = new Point(650, 175);
            btnAddIntelligence.Name = "btnAddIntelligence";
            btnAddIntelligence.Size = new Size(34, 34);
            btnAddIntelligence.TabIndex = 12;
            btnAddIntelligence.Text = "+";
            btnAddIntelligence.UseVisualStyleBackColor = false;
            btnAddIntelligence.Click += btnAddIntelligence_Click;
            // 
            // btnAddVitality
            // 
            btnAddVitality.BackColor = Color.FromArgb(124, 92, 252);
            btnAddVitality.Cursor = Cursors.Hand;
            btnAddVitality.Enabled = false;
            btnAddVitality.FlatAppearance.BorderSize = 0;
            btnAddVitality.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 69, 210);
            btnAddVitality.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 121, 255);
            btnAddVitality.FlatStyle = FlatStyle.Flat;
            btnAddVitality.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            btnAddVitality.Location = new Point(650, 125);
            btnAddVitality.Name = "btnAddVitality";
            btnAddVitality.Size = new Size(34, 34);
            btnAddVitality.TabIndex = 11;
            btnAddVitality.Text = "+";
            btnAddVitality.UseVisualStyleBackColor = false;
            btnAddVitality.Click += btnAddVitality_Click;
            // 
            // btnAddStrength
            // 
            btnAddStrength.BackColor = Color.FromArgb(124, 92, 252);
            btnAddStrength.Cursor = Cursors.Hand;
            btnAddStrength.FlatAppearance.BorderSize = 0;
            btnAddStrength.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 69, 210);
            btnAddStrength.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 121, 255);
            btnAddStrength.FlatStyle = FlatStyle.Flat;
            btnAddStrength.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            btnAddStrength.Location = new Point(650, 75);
            btnAddStrength.Name = "btnAddStrength";
            btnAddStrength.Size = new Size(34, 34);
            btnAddStrength.TabIndex = 10;
            btnAddStrength.Text = "+";
            btnAddStrength.UseVisualStyleBackColor = false;
            btnAddStrength.Click += btnAddStrength_Click;
            // 
            // lbDexterityValue
            // 
            lbDexterityValue.BackColor = Color.FromArgb(23, 26, 33);
            lbDexterityValue.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbDexterityValue.Location = new Point(550, 228);
            lbDexterityValue.Name = "lbDexterityValue";
            lbDexterityValue.Size = new Size(48, 28);
            lbDexterityValue.TabIndex = 9;
            lbDexterityValue.Text = "5";
            lbDexterityValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbIntelligenceValue
            // 
            lbIntelligenceValue.BackColor = Color.FromArgb(23, 26, 33);
            lbIntelligenceValue.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbIntelligenceValue.Location = new Point(550, 178);
            lbIntelligenceValue.Name = "lbIntelligenceValue";
            lbIntelligenceValue.Size = new Size(48, 28);
            lbIntelligenceValue.TabIndex = 8;
            lbIntelligenceValue.Text = "5";
            lbIntelligenceValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbVitalityValue
            // 
            lbVitalityValue.BackColor = Color.FromArgb(23, 26, 33);
            lbVitalityValue.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbVitalityValue.Location = new Point(550, 128);
            lbVitalityValue.Name = "lbVitalityValue";
            lbVitalityValue.Size = new Size(48, 28);
            lbVitalityValue.TabIndex = 7;
            lbVitalityValue.Text = "5";
            lbVitalityValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbStrengthValue
            // 
            lbStrengthValue.BackColor = Color.FromArgb(23, 26, 33);
            lbStrengthValue.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbStrengthValue.Location = new Point(550, 78);
            lbStrengthValue.Name = "lbStrengthValue";
            lbStrengthValue.Size = new Size(48, 28);
            lbStrengthValue.TabIndex = 6;
            lbStrengthValue.Text = "5";
            lbStrengthValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDexterity
            // 
            lbDexterity.AutoSize = true;
            lbDexterity.BackColor = Color.Transparent;
            lbDexterity.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbDexterity.Location = new Point(16, 232);
            lbDexterity.Name = "lbDexterity";
            lbDexterity.Size = new Size(58, 15);
            lbDexterity.TabIndex = 5;
            lbDexterity.Text = "敏捷 DEX";
            // 
            // lbIntelligence
            // 
            lbIntelligence.AutoSize = true;
            lbIntelligence.BackColor = Color.Transparent;
            lbIntelligence.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbIntelligence.Location = new Point(16, 182);
            lbIntelligence.Name = "lbIntelligence";
            lbIntelligence.Size = new Size(55, 15);
            lbIntelligence.TabIndex = 4;
            lbIntelligence.Text = "智力 INT";
            // 
            // lbVitality
            // 
            lbVitality.AutoSize = true;
            lbVitality.BackColor = Color.Transparent;
            lbVitality.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbVitality.Location = new Point(16, 132);
            lbVitality.Name = "lbVitality";
            lbVitality.Size = new Size(53, 15);
            lbVitality.TabIndex = 3;
            lbVitality.Text = "體質 VIT";
            // 
            // lbStrength
            // 
            lbStrength.AutoSize = true;
            lbStrength.BackColor = Color.Transparent;
            lbStrength.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbStrength.Location = new Point(16, 82);
            lbStrength.Name = "lbStrength";
            lbStrength.Size = new Size(56, 15);
            lbStrength.TabIndex = 2;
            lbStrength.Text = "力量 STR";
            // 
            // lbAvailablePoints
            // 
            lbAvailablePoints.AutoSize = true;
            lbAvailablePoints.BackColor = Color.Transparent;
            lbAvailablePoints.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbAvailablePoints.ForeColor = Color.FromArgb(124, 92, 252);
            lbAvailablePoints.Location = new Point(16, 46);
            lbAvailablePoints.Name = "lbAvailablePoints";
            lbAvailablePoints.Size = new Size(98, 15);
            lbAvailablePoints.TabIndex = 1;
            lbAvailablePoints.Text = "可用能力點數：0";
            // 
            // lbCombatAllocationTitle
            // 
            lbCombatAllocationTitle.AutoSize = true;
            lbCombatAllocationTitle.BackColor = Color.Transparent;
            lbCombatAllocationTitle.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbCombatAllocationTitle.Location = new Point(16, 12);
            lbCombatAllocationTitle.Name = "lbCombatAllocationTitle";
            lbCombatAllocationTitle.Size = new Size(134, 18);
            lbCombatAllocationTitle.TabIndex = 0;
            lbCombatAllocationTitle.Text = "戰鬥能力與點數分配";
            // 
            // pnlBasicInfo
            // 
            pnlBasicInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBasicInfo.BackColor = Color.FromArgb(34, 38, 49);
            pnlBasicInfo.Controls.Add(lbCharacterEXP);
            pnlBasicInfo.Controls.Add(lbCharacterLevel);
            pnlBasicInfo.Controls.Add(lbCharacterName);
            pnlBasicInfo.Controls.Add(lbBasicInfoTitle);
            pnlBasicInfo.Location = new Point(20, 16);
            pnlBasicInfo.Margin = new Padding(0, 0, 0, 12);
            pnlBasicInfo.Name = "pnlBasicInfo";
            pnlBasicInfo.Padding = new Padding(16, 12, 16, 12);
            pnlBasicInfo.Size = new Size(740, 120);
            pnlBasicInfo.TabIndex = 0;
            // 
            // lbCharacterEXP
            // 
            lbCharacterEXP.AutoSize = true;
            lbCharacterEXP.BackColor = Color.Transparent;
            lbCharacterEXP.Font = new Font("Microsoft JhengHei UI", 9F);
            lbCharacterEXP.ForeColor = Color.FromArgb(146, 152, 167);
            lbCharacterEXP.Location = new Point(16, 76);
            lbCharacterEXP.Name = "lbCharacterEXP";
            lbCharacterEXP.Size = new Size(80, 15);
            lbCharacterEXP.TabIndex = 3;
            lbCharacterEXP.Text = "EXP　0 / 100";
            lbCharacterEXP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbCharacterLevel
            // 
            lbCharacterLevel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbCharacterLevel.AutoSize = true;
            lbCharacterLevel.BackColor = Color.Transparent;
            lbCharacterLevel.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbCharacterLevel.ForeColor = Color.FromArgb(124, 92, 252);
            lbCharacterLevel.Location = new Point(650, 43);
            lbCharacterLevel.Name = "lbCharacterLevel";
            lbCharacterLevel.Size = new Size(39, 18);
            lbCharacterLevel.TabIndex = 2;
            lbCharacterLevel.Text = "Lv. 1";
            lbCharacterLevel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbCharacterName
            // 
            lbCharacterName.AutoSize = true;
            lbCharacterName.BackColor = Color.Transparent;
            lbCharacterName.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            lbCharacterName.Location = new Point(16, 42);
            lbCharacterName.Name = "lbCharacterName";
            lbCharacterName.Size = new Size(57, 20);
            lbCharacterName.TabIndex = 1;
            lbCharacterName.Text = "冒險者";
            lbCharacterName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbBasicInfoTitle
            // 
            lbBasicInfoTitle.AutoSize = true;
            lbBasicInfoTitle.BackColor = Color.Transparent;
            lbBasicInfoTitle.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbBasicInfoTitle.Location = new Point(16, 12);
            lbBasicInfoTitle.Name = "lbBasicInfoTitle";
            lbBasicInfoTitle.Size = new Size(92, 18);
            lbBasicInfoTitle.TabIndex = 0;
            lbBasicInfoTitle.Text = "角色基本資訊";
            lbBasicInfoTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CharacterInfoForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(23, 26, 33);
            ClientSize = new Size(782, 880);
            Controls.Add(pnlCharacterMain);
            Controls.Add(pnlHeader);
            Font = new Font("Microsoft JhengHei UI", 10F);
            ForeColor = Color.FromArgb(243, 244, 246);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CharacterInfoForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "角色資訊";
            pnlHeader.ResumeLayout(false);
            pnlCharacterMain.ResumeLayout(false);
            pnlFullStats.ResumeLayout(false);
            pnlFullStats.PerformLayout();
            pnlCombatAllocation.ResumeLayout(false);
            pnlCombatAllocation.PerformLayout();
            pnlBasicInfo.ResumeLayout(false);
            pnlBasicInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnClose;
        private Label lbHeaderTitle;
        private Panel pnlCharacterMain;
        private Panel pnlBasicInfo;
        private Label lbCharacterLevel;
        private Label lbCharacterName;
        private Label lbBasicInfoTitle;
        private Label lbCharacterEXP;
        private Panel pnlCombatAllocation;
        private Label lbCombatAllocationTitle;
        private Label lbAvailablePoints;
        private Label lbDexterity;
        private Label lbIntelligence;
        private Label lbVitality;
        private Label lbStrength;
        private Label lbDexterityValue;
        private Label lbIntelligenceValue;
        private Label lbVitalityValue;
        private Label lbStrengthValue;
        private Button btnAddDexterity;
        private Button btnAddIntelligence;
        private Button btnAddVitality;
        private Button btnAddStrength;
        private Button btnUndoAllocation;
        private Button btnConfirmAllocation;
        private Panel pnlFullStats;
        private Label lbFullMP;
        private Label lbFullHP;
        private Label lbFullEXP;
        private Label lbFullLevel;
        private Label lbFullStatsTitle;
        private Label lbFullDexterity;
        private Label lbFullIntelligence;
        private Label lbFullVitality;
        private Label lbFullStrength;
        private Label lbFullCriticalRateAndDamage;
        private Label lbFullDefense;
        private Label lbFullMagicAttack;
        private Label lbFullPhysicalAttack;
    }
}