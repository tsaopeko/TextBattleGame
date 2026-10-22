namespace TextBattleGame.Forms
{
    partial class GameForm
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
            lbGameTitle = new Label();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            pnlMain = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnNormalAttack = new Button();
            btnMagicAttack = new Button();
            btnInventory = new Button();
            btnFlee = new Button();
            btnSave = new Button();
            pnlBattleLog = new Panel();
            lbCurrentStage = new Label();
            rtbBattleLog = new RichTextBox();
            lbBattleLogTitle = new Label();
            pnlExperience = new Panel();
            prgExperience = new TextBattleGame.Controls.GameProgressBar();
            lbExperience = new Label();
            tlpBattleStatus = new TableLayoutPanel();
            pnlPlayerCard = new Panel();
            prgPlayerMP = new TextBattleGame.Controls.GameProgressBar();
            prgPlayerHP = new TextBattleGame.Controls.GameProgressBar();
            lbPlayerDefense = new Label();
            lbPlayerAttack = new Label();
            lbPlayerMP = new Label();
            lbPlayerHP = new Label();
            lbPlayerLevel = new Label();
            lbPlayerName = new Label();
            pnlEnemyCard = new Panel();
            btnNextStage = new Button();
            btnRetryBattle = new Button();
            lbBattleStatus = new Label();
            prgEnemyHP = new TextBattleGame.Controls.GameProgressBar();
            lbEnemyHP = new Label();
            lbEnemyStats = new Label();
            lbEnemyName = new Label();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlBattleLog.SuspendLayout();
            pnlExperience.SuspendLayout();
            tlpBattleStatus.SuspendLayout();
            pnlPlayerCard.SuspendLayout();
            pnlEnemyCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(38, 42, 54);
            pnlHeader.Controls.Add(lbGameTitle);
            pnlHeader.Controls.Add(btnMinimize);
            pnlHeader.Controls.Add(btnMaximize);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1100, 50);
            pnlHeader.TabIndex = 0;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            // 
            // lbGameTitle
            // 
            lbGameTitle.BackColor = Color.Transparent;
            lbGameTitle.Dock = DockStyle.Left;
            lbGameTitle.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold);
            lbGameTitle.Location = new Point(0, 0);
            lbGameTitle.Name = "lbGameTitle";
            lbGameTitle.Padding = new Padding(15, 0, 0, 0);
            lbGameTitle.Size = new Size(193, 50);
            lbGameTitle.TabIndex = 3;
            lbGameTitle.Text = "文字戰鬥遊戲";
            lbGameTitle.TextAlign = ContentAlignment.MiddleLeft;
            lbGameTitle.MouseDown += lbGameTitle_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(52, 56, 70);
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 46, 58);
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 76, 92);
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Microsoft JhengHei UI", 12F);
            btnMinimize.Location = new Point(950, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(50, 50);
            btnMinimize.TabIndex = 1;
            btnMinimize.TabStop = false;
            btnMinimize.Text = "一";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.FromArgb(52, 56, 70);
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 46, 58);
            btnMaximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 76, 92);
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold);
            btnMaximize.Location = new Point(1000, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(50, 50);
            btnMaximize.TabIndex = 4;
            btnMaximize.Text = "口";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
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
            btnClose.Font = new Font("Microsoft JhengHei UI", 16F);
            btnClose.Location = new Point(1050, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(flowLayoutPanel1);
            pnlMain.Controls.Add(pnlBattleLog);
            pnlMain.Controls.Add(pnlExperience);
            pnlMain.Controls.Add(tlpBattleStatus);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 50);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(20);
            pnlMain.Size = new Size(1100, 650);
            pnlMain.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(btnNormalAttack);
            flowLayoutPanel1.Controls.Add(btnMagicAttack);
            flowLayoutPanel1.Controls.Add(btnInventory);
            flowLayoutPanel1.Controls.Add(btnFlee);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(20, 530);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 16, 0, 8);
            flowLayoutPanel1.Size = new Size(1060, 100);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnNormalAttack
            // 
            btnNormalAttack.BackColor = Color.FromArgb(48, 41, 87);
            btnNormalAttack.Cursor = Cursors.Hand;
            btnNormalAttack.FlatAppearance.BorderColor = Color.FromArgb(124, 92, 252);
            btnNormalAttack.FlatAppearance.BorderSize = 0;
            btnNormalAttack.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 33, 70);
            btnNormalAttack.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 54, 112);
            btnNormalAttack.FlatStyle = FlatStyle.Flat;
            btnNormalAttack.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            btnNormalAttack.ForeColor = Color.White;
            btnNormalAttack.Location = new Point(0, 16);
            btnNormalAttack.Margin = new Padding(0, 0, 12, 0);
            btnNormalAttack.Name = "btnNormalAttack";
            btnNormalAttack.Padding = new Padding(8, 4, 8, 4);
            btnNormalAttack.Size = new Size(200, 56);
            btnNormalAttack.TabIndex = 0;
            btnNormalAttack.Text = "普通攻擊";
            btnNormalAttack.UseVisualStyleBackColor = false;
            btnNormalAttack.Click += btnNormalAttack_Click;
            // 
            // btnMagicAttack
            // 
            btnMagicAttack.BackColor = Color.FromArgb(38, 51, 79);
            btnMagicAttack.Cursor = Cursors.Hand;
            btnMagicAttack.FlatAppearance.BorderColor = Color.FromArgb(82, 121, 216);
            btnMagicAttack.FlatAppearance.BorderSize = 0;
            btnMagicAttack.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 66, 101);
            btnMagicAttack.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 63);
            btnMagicAttack.FlatStyle = FlatStyle.Flat;
            btnMagicAttack.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            btnMagicAttack.Location = new Point(212, 16);
            btnMagicAttack.Margin = new Padding(0, 0, 12, 0);
            btnMagicAttack.Name = "btnMagicAttack";
            btnMagicAttack.Padding = new Padding(8, 4, 8, 4);
            btnMagicAttack.Size = new Size(200, 56);
            btnMagicAttack.TabIndex = 1;
            btnMagicAttack.Text = "魔法攻擊";
            btnMagicAttack.UseVisualStyleBackColor = false;
            btnMagicAttack.Click += btnMagicAttack_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(36, 65, 55);
            btnInventory.Cursor = Cursors.Hand;
            btnInventory.FlatAppearance.BorderColor = Color.FromArgb(84, 214, 160);
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 83, 70);
            btnInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 52, 43);
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            btnInventory.Location = new Point(424, 16);
            btnInventory.Margin = new Padding(0, 0, 12, 0);
            btnInventory.Name = "btnInventory";
            btnInventory.Padding = new Padding(8, 4, 8, 4);
            btnInventory.Size = new Size(200, 56);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "背包";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnFlee
            // 
            btnFlee.BackColor = Color.FromArgb(66, 42, 50);
            btnFlee.Cursor = Cursors.Hand;
            btnFlee.FlatAppearance.BorderColor = Color.FromArgb(244, 108, 122);
            btnFlee.FlatAppearance.BorderSize = 0;
            btnFlee.FlatAppearance.MouseDownBackColor = Color.FromArgb(88, 49, 59);
            btnFlee.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 33, 40);
            btnFlee.FlatStyle = FlatStyle.Flat;
            btnFlee.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            btnFlee.Location = new Point(636, 16);
            btnFlee.Margin = new Padding(0, 0, 12, 0);
            btnFlee.Name = "btnFlee";
            btnFlee.Padding = new Padding(8, 4, 8, 4);
            btnFlee.Size = new Size(200, 56);
            btnFlee.TabIndex = 3;
            btnFlee.Text = "逃跑";
            btnFlee.UseVisualStyleBackColor = false;
            btnFlee.Click += btnFlee_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(37, 45, 60);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 37, 50);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 66, 85);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(240, 244, 248);
            btnSave.Location = new Point(848, 16);
            btnSave.Margin = new Padding(0, 0, 12, 0);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(8, 4, 8, 4);
            btnSave.Size = new Size(200, 56);
            btnSave.TabIndex = 4;
            btnSave.TabStop = false;
            btnSave.Text = "冒險紀錄";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pnlBattleLog
            // 
            pnlBattleLog.BackColor = Color.FromArgb(34, 38, 49);
            pnlBattleLog.Controls.Add(lbCurrentStage);
            pnlBattleLog.Controls.Add(rtbBattleLog);
            pnlBattleLog.Controls.Add(lbBattleLogTitle);
            pnlBattleLog.Dock = DockStyle.Top;
            pnlBattleLog.Location = new Point(20, 268);
            pnlBattleLog.Margin = new Padding(0, 12, 0, 0);
            pnlBattleLog.Name = "pnlBattleLog";
            pnlBattleLog.Padding = new Padding(16, 12, 16, 12);
            pnlBattleLog.Size = new Size(1060, 270);
            pnlBattleLog.TabIndex = 2;
            // 
            // lbCurrentStage
            // 
            lbCurrentStage.AutoSize = true;
            lbCurrentStage.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbCurrentStage.ForeColor = Color.FromArgb(214, 182, 92);
            lbCurrentStage.Location = new Point(107, 12);
            lbCurrentStage.Name = "lbCurrentStage";
            lbCurrentStage.Size = new Size(66, 18);
            lbCurrentStage.TabIndex = 8;
            lbCurrentStage.Text = "第 1 階段";
            // 
            // rtbBattleLog
            // 
            rtbBattleLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbBattleLog.BackColor = Color.FromArgb(34, 38, 49);
            rtbBattleLog.BorderStyle = BorderStyle.None;
            rtbBattleLog.DetectUrls = false;
            rtbBattleLog.Font = new Font("Microsoft JhengHei UI", 9F);
            rtbBattleLog.ForeColor = Color.FromArgb(210, 214, 224);
            rtbBattleLog.Location = new Point(16, 42);
            rtbBattleLog.Margin = new Padding(0);
            rtbBattleLog.Name = "rtbBattleLog";
            rtbBattleLog.ReadOnly = true;
            rtbBattleLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbBattleLog.Size = new Size(700, 195);
            rtbBattleLog.TabIndex = 1;
            rtbBattleLog.TabStop = false;
            rtbBattleLog.Text = "";
            // 
            // lbBattleLogTitle
            // 
            lbBattleLogTitle.AutoSize = true;
            lbBattleLogTitle.BackColor = Color.Transparent;
            lbBattleLogTitle.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbBattleLogTitle.Location = new Point(16, 12);
            lbBattleLogTitle.Margin = new Padding(0);
            lbBattleLogTitle.Name = "lbBattleLogTitle";
            lbBattleLogTitle.Size = new Size(64, 18);
            lbBattleLogTitle.TabIndex = 0;
            lbBattleLogTitle.Text = "戰鬥紀錄";
            lbBattleLogTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlExperience
            // 
            pnlExperience.Controls.Add(prgExperience);
            pnlExperience.Controls.Add(lbExperience);
            pnlExperience.Dock = DockStyle.Top;
            pnlExperience.Location = new Point(20, 210);
            pnlExperience.Margin = new Padding(0, 8, 0, 8);
            pnlExperience.Name = "pnlExperience";
            pnlExperience.Padding = new Padding(0, 8, 0, 8);
            pnlExperience.Size = new Size(1060, 58);
            pnlExperience.TabIndex = 1;
            // 
            // prgExperience
            // 
            prgExperience.Location = new Point(5, 29);
            prgExperience.Name = "prgExperience";
            prgExperience.Size = new Size(700, 14);
            prgExperience.TabIndex = 2;
            prgExperience.Text = "gameProgressBar1";
            // 
            // lbExperience
            // 
            lbExperience.AutoSize = true;
            lbExperience.BackColor = Color.Transparent;
            lbExperience.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbExperience.ForeColor = Color.FromArgb(146, 152, 167);
            lbExperience.Location = new Point(5, 5);
            lbExperience.Margin = new Padding(0);
            lbExperience.Name = "lbExperience";
            lbExperience.Size = new Size(94, 18);
            lbExperience.TabIndex = 0;
            lbExperience.Text = "EXP　0 / 100";
            lbExperience.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpBattleStatus
            // 
            tlpBattleStatus.ColumnCount = 2;
            tlpBattleStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBattleStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBattleStatus.Controls.Add(pnlPlayerCard, 0, 0);
            tlpBattleStatus.Controls.Add(pnlEnemyCard, 1, 0);
            tlpBattleStatus.Dock = DockStyle.Top;
            tlpBattleStatus.Location = new Point(20, 20);
            tlpBattleStatus.Name = "tlpBattleStatus";
            tlpBattleStatus.RowCount = 1;
            tlpBattleStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBattleStatus.Size = new Size(1060, 190);
            tlpBattleStatus.TabIndex = 0;
            // 
            // pnlPlayerCard
            // 
            pnlPlayerCard.BackColor = Color.FromArgb(34, 38, 49);
            pnlPlayerCard.Controls.Add(prgPlayerMP);
            pnlPlayerCard.Controls.Add(prgPlayerHP);
            pnlPlayerCard.Controls.Add(lbPlayerDefense);
            pnlPlayerCard.Controls.Add(lbPlayerAttack);
            pnlPlayerCard.Controls.Add(lbPlayerMP);
            pnlPlayerCard.Controls.Add(lbPlayerHP);
            pnlPlayerCard.Controls.Add(lbPlayerLevel);
            pnlPlayerCard.Controls.Add(lbPlayerName);
            pnlPlayerCard.Cursor = Cursors.Hand;
            pnlPlayerCard.Dock = DockStyle.Fill;
            pnlPlayerCard.Location = new Point(0, 0);
            pnlPlayerCard.Margin = new Padding(0, 0, 8, 0);
            pnlPlayerCard.Name = "pnlPlayerCard";
            pnlPlayerCard.Padding = new Padding(16, 14, 16, 14);
            pnlPlayerCard.Size = new Size(522, 190);
            pnlPlayerCard.TabIndex = 0;
            pnlPlayerCard.TabStop = true;
            pnlPlayerCard.Click += pnlPlayerCard_Click;
            // 
            // prgPlayerMP
            // 
            prgPlayerMP.Location = new Point(16, 148);
            prgPlayerMP.Name = "prgPlayerMP";
            prgPlayerMP.Size = new Size(300, 14);
            prgPlayerMP.TabIndex = 9;
            prgPlayerMP.Text = "gameProgressBar1";
            // 
            // prgPlayerHP
            // 
            prgPlayerHP.Location = new Point(16, 100);
            prgPlayerHP.Name = "prgPlayerHP";
            prgPlayerHP.Size = new Size(300, 14);
            prgPlayerHP.TabIndex = 8;
            prgPlayerHP.Text = "gameProgressBar1";
            // 
            // lbPlayerDefense
            // 
            lbPlayerDefense.AutoSize = true;
            lbPlayerDefense.BackColor = Color.Transparent;
            lbPlayerDefense.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbPlayerDefense.ForeColor = Color.FromArgb(146, 152, 167);
            lbPlayerDefense.Location = new Point(176, 42);
            lbPlayerDefense.Name = "lbPlayerDefense";
            lbPlayerDefense.Size = new Size(62, 15);
            lbPlayerDefense.TabIndex = 7;
            lbPlayerDefense.Text = "防禦力：5";
            lbPlayerDefense.Click += lbPlayerDefense_Click;
            // 
            // lbPlayerAttack
            // 
            lbPlayerAttack.AutoSize = true;
            lbPlayerAttack.BackColor = Color.Transparent;
            lbPlayerAttack.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbPlayerAttack.ForeColor = Color.FromArgb(146, 152, 167);
            lbPlayerAttack.Location = new Point(76, 42);
            lbPlayerAttack.Name = "lbPlayerAttack";
            lbPlayerAttack.Size = new Size(81, 15);
            lbPlayerAttack.TabIndex = 6;
            lbPlayerAttack.Text = "物理攻擊：20";
            lbPlayerAttack.Click += lbPlayerAttack_Click;
            // 
            // lbPlayerMP
            // 
            lbPlayerMP.AutoSize = true;
            lbPlayerMP.BackColor = Color.Transparent;
            lbPlayerMP.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbPlayerMP.ForeColor = Color.FromArgb(124, 92, 252);
            lbPlayerMP.Location = new Point(16, 124);
            lbPlayerMP.Name = "lbPlayerMP";
            lbPlayerMP.Size = new Size(78, 15);
            lbPlayerMP.TabIndex = 4;
            lbPlayerMP.Text = "MP　50 / 50";
            // 
            // lbPlayerHP
            // 
            lbPlayerHP.AutoSize = true;
            lbPlayerHP.BackColor = Color.Transparent;
            lbPlayerHP.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbPlayerHP.ForeColor = Color.FromArgb(84, 214, 160);
            lbPlayerHP.Location = new Point(16, 76);
            lbPlayerHP.Name = "lbPlayerHP";
            lbPlayerHP.Size = new Size(89, 15);
            lbPlayerHP.TabIndex = 2;
            lbPlayerHP.Text = "HP　100 / 100";
            // 
            // lbPlayerLevel
            // 
            lbPlayerLevel.AutoSize = true;
            lbPlayerLevel.BackColor = Color.Transparent;
            lbPlayerLevel.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbPlayerLevel.ForeColor = Color.FromArgb(146, 152, 167);
            lbPlayerLevel.Location = new Point(16, 42);
            lbPlayerLevel.Name = "lbPlayerLevel";
            lbPlayerLevel.Size = new Size(33, 15);
            lbPlayerLevel.TabIndex = 1;
            lbPlayerLevel.Text = "Lv. 1";
            lbPlayerLevel.Click += lbPlayerLevel_Click;
            // 
            // lbPlayerName
            // 
            lbPlayerName.AutoSize = true;
            lbPlayerName.BackColor = Color.Transparent;
            lbPlayerName.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            lbPlayerName.Location = new Point(16, 14);
            lbPlayerName.Name = "lbPlayerName";
            lbPlayerName.Size = new Size(57, 20);
            lbPlayerName.TabIndex = 0;
            lbPlayerName.Text = "冒險者";
            lbPlayerName.Click += lbPlayerName_Click;
            // 
            // pnlEnemyCard
            // 
            pnlEnemyCard.BackColor = Color.FromArgb(34, 38, 49);
            pnlEnemyCard.Controls.Add(btnNextStage);
            pnlEnemyCard.Controls.Add(btnRetryBattle);
            pnlEnemyCard.Controls.Add(lbBattleStatus);
            pnlEnemyCard.Controls.Add(prgEnemyHP);
            pnlEnemyCard.Controls.Add(lbEnemyHP);
            pnlEnemyCard.Controls.Add(lbEnemyStats);
            pnlEnemyCard.Controls.Add(lbEnemyName);
            pnlEnemyCard.Dock = DockStyle.Fill;
            pnlEnemyCard.Location = new Point(538, 0);
            pnlEnemyCard.Margin = new Padding(8, 0, 0, 0);
            pnlEnemyCard.Name = "pnlEnemyCard";
            pnlEnemyCard.Padding = new Padding(16, 14, 16, 14);
            pnlEnemyCard.Size = new Size(522, 190);
            pnlEnemyCard.TabIndex = 1;
            // 
            // btnNextStage
            // 
            btnNextStage.BackColor = Color.FromArgb(34, 38, 49);
            btnNextStage.FlatAppearance.BorderColor = Color.FromArgb(58, 65, 79);
            btnNextStage.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 46, 60);
            btnNextStage.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 57, 73);
            btnNextStage.FlatStyle = FlatStyle.Flat;
            btnNextStage.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            btnNextStage.ForeColor = Color.FromArgb(243, 244, 246);
            btnNextStage.Location = new Point(186, 142);
            btnNextStage.Margin = new Padding(4);
            btnNextStage.Name = "btnNextStage";
            btnNextStage.Size = new Size(130, 36);
            btnNextStage.TabIndex = 7;
            btnNextStage.Text = "前往下一階段";
            btnNextStage.UseVisualStyleBackColor = false;
            btnNextStage.Visible = false;
            btnNextStage.Click += btnNextStage_Click;
            // 
            // btnRetryBattle
            // 
            btnRetryBattle.BackColor = Color.FromArgb(124, 92, 252);
            btnRetryBattle.FlatAppearance.BorderSize = 0;
            btnRetryBattle.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 58, 190);
            btnRetryBattle.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 72, 220);
            btnRetryBattle.FlatStyle = FlatStyle.Flat;
            btnRetryBattle.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            btnRetryBattle.ForeColor = Color.White;
            btnRetryBattle.Location = new Point(20, 142);
            btnRetryBattle.Margin = new Padding(4);
            btnRetryBattle.Name = "btnRetryBattle";
            btnRetryBattle.Size = new Size(130, 36);
            btnRetryBattle.TabIndex = 6;
            btnRetryBattle.Text = "再次挑戰";
            btnRetryBattle.UseVisualStyleBackColor = false;
            btnRetryBattle.Visible = false;
            btnRetryBattle.Click += btnRetryBattle_Click;
            // 
            // lbBattleStatus
            // 
            lbBattleStatus.AutoSize = true;
            lbBattleStatus.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbBattleStatus.ForeColor = Color.FromArgb(146, 152, 167);
            lbBattleStatus.Location = new Point(238, 14);
            lbBattleStatus.Margin = new Padding(4);
            lbBattleStatus.Name = "lbBattleStatus";
            lbBattleStatus.Size = new Size(78, 18);
            lbBattleStatus.TabIndex = 5;
            lbBattleStatus.Text = "戰鬥進行中";
            lbBattleStatus.Visible = false;
            // 
            // prgEnemyHP
            // 
            prgEnemyHP.Location = new Point(16, 100);
            prgEnemyHP.Name = "prgEnemyHP";
            prgEnemyHP.Size = new Size(300, 14);
            prgEnemyHP.TabIndex = 4;
            prgEnemyHP.Text = "gameProgressBar1";
            // 
            // lbEnemyHP
            // 
            lbEnemyHP.AutoSize = true;
            lbEnemyHP.BackColor = Color.Transparent;
            lbEnemyHP.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbEnemyHP.ForeColor = Color.FromArgb(244, 108, 122);
            lbEnemyHP.Location = new Point(16, 76);
            lbEnemyHP.Name = "lbEnemyHP";
            lbEnemyHP.Size = new Size(75, 15);
            lbEnemyHP.TabIndex = 2;
            lbEnemyHP.Text = "HP　30 / 30";
            // 
            // lbEnemyStats
            // 
            lbEnemyStats.AutoSize = true;
            lbEnemyStats.BackColor = Color.Transparent;
            lbEnemyStats.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbEnemyStats.ForeColor = Color.FromArgb(146, 152, 167);
            lbEnemyStats.Location = new Point(16, 42);
            lbEnemyStats.Name = "lbEnemyStats";
            lbEnemyStats.Size = new Size(88, 15);
            lbEnemyStats.TabIndex = 1;
            lbEnemyStats.Text = "ATK 5　 DEF 1";
            // 
            // lbEnemyName
            // 
            lbEnemyName.AutoSize = true;
            lbEnemyName.BackColor = Color.Transparent;
            lbEnemyName.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            lbEnemyName.Location = new Point(16, 14);
            lbEnemyName.Name = "lbEnemyName";
            lbEnemyName.Size = new Size(57, 20);
            lbEnemyName.TabIndex = 0;
            lbEnemyName.Text = "史萊姆";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(23, 26, 33);
            ClientSize = new Size(1100, 700);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Font = new Font("Microsoft JhengHei UI", 10F);
            ForeColor = Color.FromArgb(243, 244, 246);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "GameForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text Battle";
            Load += GameForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            pnlBattleLog.ResumeLayout(false);
            pnlBattleLog.PerformLayout();
            pnlExperience.ResumeLayout(false);
            pnlExperience.PerformLayout();
            tlpBattleStatus.ResumeLayout(false);
            pnlPlayerCard.ResumeLayout(false);
            pnlPlayerCard.PerformLayout();
            pnlEnemyCard.ResumeLayout(false);
            pnlEnemyCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnMinimize;
        private Button btnClose;
        private Label lbGameTitle;
        private Button btnMaximize;
        private Panel pnlMain;
        private TableLayoutPanel tlpBattleStatus;
        private Panel pnlPlayerCard;
        private Panel pnlEnemyCard;
        private Label lbPlayerHP;
        private Label lbPlayerLevel;
        private Label lbPlayerName;
        private Label lbPlayerMP;
        private Label lbEnemyName;
        private Label lbEnemyHP;
        private Label lbEnemyStats;
        private Panel pnlExperience;
        private Label lbExperience;
        private Panel pnlBattleLog;
        private RichTextBox rtbBattleLog;
        private Label lbBattleLogTitle;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnNormalAttack;
        private Button btnMagicAttack;
        private Button btnInventory;
        private Button btnFlee;
        private Label lbPlayerDefense;
        private Label lbPlayerAttack;
        private Controls.GameProgressBar prgPlayerHP;
        private Controls.GameProgressBar prgPlayerMP;
        private Controls.GameProgressBar prgEnemyHP;
        private Button btnRetryBattle;
        private Label lbBattleStatus;
        private Button btnNextStage;
        private Controls.GameProgressBar prgExperience;
        private Label lbCurrentStage;
        private Button btnSave;
    }
}