namespace TextBattleGame.Forms
{
    partial class StartForm
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
            pnlStartContent = new Panel();
            lbStartSubtitle = new Label();
            btnExitGame = new Button();
            btnStartGame = new Button();
            txtCharacterName = new TextBox();
            lbCharacterName = new Label();
            lbStartTitle = new Label();
            btnLoadGame = new Button();
            pnlHeader.SuspendLayout();
            pnlStartContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(38, 42, 54);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(lbHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1010, 50);
            pnlHeader.TabIndex = 0;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
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
            btnClose.Location = new Point(960, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lbHeaderTitle
            // 
            lbHeaderTitle.BackColor = Color.Transparent;
            lbHeaderTitle.Dock = DockStyle.Left;
            lbHeaderTitle.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold);
            lbHeaderTitle.Location = new Point(0, 0);
            lbHeaderTitle.Name = "lbHeaderTitle";
            lbHeaderTitle.Padding = new Padding(15, 0, 0, 0);
            lbHeaderTitle.Size = new Size(126, 50);
            lbHeaderTitle.TabIndex = 0;
            lbHeaderTitle.Text = "TEXT BATTLE";
            lbHeaderTitle.TextAlign = ContentAlignment.MiddleLeft;
            lbHeaderTitle.MouseDown += lbHeaderTitle_MouseDown;
            // 
            // pnlStartContent
            // 
            pnlStartContent.Anchor = AnchorStyles.None;
            pnlStartContent.BackColor = Color.FromArgb(34, 38, 49);
            pnlStartContent.Controls.Add(btnLoadGame);
            pnlStartContent.Controls.Add(lbStartSubtitle);
            pnlStartContent.Controls.Add(btnExitGame);
            pnlStartContent.Controls.Add(btnStartGame);
            pnlStartContent.Controls.Add(txtCharacterName);
            pnlStartContent.Controls.Add(lbCharacterName);
            pnlStartContent.Controls.Add(lbStartTitle);
            pnlStartContent.Location = new Point(220, 100);
            pnlStartContent.Margin = new Padding(0);
            pnlStartContent.Name = "pnlStartContent";
            pnlStartContent.Padding = new Padding(24);
            pnlStartContent.Size = new Size(520, 446);
            pnlStartContent.TabIndex = 1;
            // 
            // lbStartSubtitle
            // 
            lbStartSubtitle.AutoSize = true;
            lbStartSubtitle.BackColor = Color.Transparent;
            lbStartSubtitle.Font = new Font("Microsoft JhengHei UI", 9F);
            lbStartSubtitle.ForeColor = Color.FromArgb(146, 152, 167);
            lbStartSubtitle.Location = new Point(27, 78);
            lbStartSubtitle.Name = "lbStartSubtitle";
            lbStartSubtitle.Size = new Size(163, 15);
            lbStartSubtitle.TabIndex = 4;
            lbStartSubtitle.Text = "CREATE YOUR CHARACTER";
            // 
            // btnExitGame
            // 
            btnExitGame.Cursor = Cursors.Hand;
            btnExitGame.FlatAppearance.BorderColor = Color.FromArgb(69, 75, 91);
            btnExitGame.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 32, 42);
            btnExitGame.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 53, 67);
            btnExitGame.FlatStyle = FlatStyle.Flat;
            btnExitGame.ForeColor = Color.FromArgb(146, 152, 167);
            btnExitGame.Location = new Point(27, 345);
            btnExitGame.Margin = new Padding(0);
            btnExitGame.Name = "btnExitGame";
            btnExitGame.Padding = new Padding(8, 4, 8, 4);
            btnExitGame.Size = new Size(442, 48);
            btnExitGame.TabIndex = 2;
            btnExitGame.Text = "離開遊戲";
            btnExitGame.UseVisualStyleBackColor = true;
            btnExitGame.Click += btnExitGame_Click;
            // 
            // btnStartGame
            // 
            btnStartGame.BackColor = Color.FromArgb(124, 92, 252);
            btnStartGame.Cursor = Cursors.Hand;
            btnStartGame.FlatAppearance.BorderSize = 0;
            btnStartGame.FlatAppearance.MouseDownBackColor = Color.FromArgb(98, 72, 210);
            btnStartGame.FlatAppearance.MouseOverBackColor = Color.FromArgb(145, 117, 255);
            btnStartGame.FlatStyle = FlatStyle.Flat;
            btnStartGame.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold);
            btnStartGame.Location = new Point(27, 225);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Padding = new Padding(8, 4, 8, 4);
            btnStartGame.Size = new Size(442, 48);
            btnStartGame.TabIndex = 1;
            btnStartGame.Text = "開始遊戲";
            btnStartGame.UseVisualStyleBackColor = false;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // txtCharacterName
            // 
            txtCharacterName.BackColor = Color.FromArgb(23, 26, 33);
            txtCharacterName.BorderStyle = BorderStyle.FixedSingle;
            txtCharacterName.Font = new Font("Microsoft JhengHei UI", 11F);
            txtCharacterName.ForeColor = Color.FromArgb(243, 244, 246);
            txtCharacterName.Location = new Point(27, 175);
            txtCharacterName.Name = "txtCharacterName";
            txtCharacterName.Size = new Size(442, 26);
            txtCharacterName.TabIndex = 0;
            // 
            // lbCharacterName
            // 
            lbCharacterName.AutoSize = true;
            lbCharacterName.BackColor = Color.Transparent;
            lbCharacterName.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            lbCharacterName.Location = new Point(27, 135);
            lbCharacterName.Margin = new Padding(0);
            lbCharacterName.Name = "lbCharacterName";
            lbCharacterName.Size = new Size(73, 20);
            lbCharacterName.TabIndex = 1;
            lbCharacterName.Text = "角色名稱";
            lbCharacterName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbStartTitle
            // 
            lbStartTitle.AutoSize = true;
            lbStartTitle.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold);
            lbStartTitle.Location = new Point(24, 25);
            lbStartTitle.Name = "lbStartTitle";
            lbStartTitle.Size = new Size(184, 35);
            lbStartTitle.TabIndex = 0;
            lbStartTitle.Text = "TEXT BATTLE";
            // 
            // btnLoadGame
            // 
            btnLoadGame.BackColor = Color.FromArgb(45, 55, 72);
            btnLoadGame.Cursor = Cursors.Hand;
            btnLoadGame.FlatAppearance.BorderSize = 0;
            btnLoadGame.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 43, 57);
            btnLoadGame.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 80, 105);
            btnLoadGame.FlatStyle = FlatStyle.Flat;
            btnLoadGame.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold);
            btnLoadGame.ForeColor = Color.FromArgb(240, 244, 248);
            btnLoadGame.Location = new Point(27, 285);
            btnLoadGame.Name = "btnLoadGame";
            btnLoadGame.Padding = new Padding(8, 4, 8, 4);
            btnLoadGame.Size = new Size(442, 48);
            btnLoadGame.TabIndex = 5;
            btnLoadGame.Text = "讀取遊戲";
            btnLoadGame.UseVisualStyleBackColor = false;
            btnLoadGame.Click += btnLoadGame_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(23, 26, 33);
            ClientSize = new Size(1010, 636);
            Controls.Add(pnlStartContent);
            Controls.Add(pnlHeader);
            Font = new Font("Microsoft JhengHei UI", 10F);
            ForeColor = Color.FromArgb(243, 244, 246);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "StartForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text Battle";
            pnlHeader.ResumeLayout(false);
            pnlStartContent.ResumeLayout(false);
            pnlStartContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lbHeaderTitle;
        private Panel pnlStartContent;
        private Label lbStartTitle;
        private Button btnStartGame;
        private TextBox txtCharacterName;
        private Label lbCharacterName;
        private Label lbStartSubtitle;
        private Button btnExitGame;
        private Button btnClose;
        private Button btnLoadGame;
    }
}