namespace TextBattleGame.Forms
{
    partial class SaveLoadForm
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
            lbTitle = new Label();
            pnlMode = new Panel();
            btnLoadMode = new Button();
            btnSaveMode = new Button();
            pnlSlotContainer = new Panel();
            pnlSlot3 = new Panel();
            btnSlot3Action = new Button();
            lbSlot3Details = new Label();
            lbSlot3PlayerName = new Label();
            lbSlot3Title = new Label();
            pnlSlot2 = new Panel();
            btnSlot2Action = new Button();
            lbSlot2Details = new Label();
            lbSlot2PlayerName = new Label();
            lbSlot2Title = new Label();
            pnlSlot1 = new Panel();
            btnSlot1Action = new Button();
            lbSlot1Details = new Label();
            lbSlot1PlayerName = new Label();
            lbSlot1Title = new Label();
            pnlHeader.SuspendLayout();
            pnlMode.SuspendLayout();
            pnlSlotContainer.SuspendLayout();
            pnlSlot3.SuspendLayout();
            pnlSlot2.SuspendLayout();
            pnlSlot1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(37, 45, 60);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(lbTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(16, 0, 12, 0);
            pnlHeader.Size = new Size(823, 50);
            pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(140, 40, 50);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 55, 65);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(240, 244, 248);
            btnClose.Location = new Point(761, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lbTitle
            // 
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Dock = DockStyle.Left;
            lbTitle.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            lbTitle.ForeColor = Color.FromArgb(240, 244, 248);
            lbTitle.Location = new Point(16, 0);
            lbTitle.Margin = new Padding(0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(200, 50);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "冒險紀錄";
            lbTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlMode
            // 
            pnlMode.Controls.Add(btnLoadMode);
            pnlMode.Controls.Add(btnSaveMode);
            pnlMode.Dock = DockStyle.Top;
            pnlMode.Location = new Point(0, 50);
            pnlMode.Margin = new Padding(0);
            pnlMode.Name = "pnlMode";
            pnlMode.Padding = new Padding(16, 8, 16, 8);
            pnlMode.Size = new Size(823, 56);
            pnlMode.TabIndex = 1;
            // 
            // btnLoadMode
            // 
            btnLoadMode.BackColor = Color.FromArgb(37, 45, 60);
            btnLoadMode.Cursor = Cursors.Hand;
            btnLoadMode.FlatAppearance.BorderSize = 0;
            btnLoadMode.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 37, 50);
            btnLoadMode.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 66, 85);
            btnLoadMode.FlatStyle = FlatStyle.Flat;
            btnLoadMode.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            btnLoadMode.ForeColor = Color.FromArgb(190, 199, 213);
            btnLoadMode.Location = new Point(384, 8);
            btnLoadMode.Margin = new Padding(0);
            btnLoadMode.Name = "btnLoadMode";
            btnLoadMode.Size = new Size(360, 40);
            btnLoadMode.TabIndex = 1;
            btnLoadMode.TabStop = false;
            btnLoadMode.Text = "讀檔";
            btnLoadMode.UseVisualStyleBackColor = false;
            btnLoadMode.Click += btnLoadMode_Click;
            // 
            // btnSaveMode
            // 
            btnSaveMode.BackColor = Color.FromArgb(124, 92, 220);
            btnSaveMode.Cursor = Cursors.Hand;
            btnSaveMode.FlatAppearance.BorderSize = 0;
            btnSaveMode.FlatAppearance.MouseDownBackColor = Color.FromArgb(99, 70, 190);
            btnSaveMode.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 112, 235);
            btnSaveMode.FlatStyle = FlatStyle.Flat;
            btnSaveMode.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            btnSaveMode.ForeColor = Color.White;
            btnSaveMode.Location = new Point(16, 8);
            btnSaveMode.Margin = new Padding(0, 0, 8, 0);
            btnSaveMode.Name = "btnSaveMode";
            btnSaveMode.Size = new Size(360, 40);
            btnSaveMode.TabIndex = 0;
            btnSaveMode.TabStop = false;
            btnSaveMode.Text = "存檔";
            btnSaveMode.UseVisualStyleBackColor = false;
            btnSaveMode.Click += btnSaveMode_Click;
            // 
            // pnlSlotContainer
            // 
            pnlSlotContainer.AutoScroll = true;
            pnlSlotContainer.Controls.Add(pnlSlot3);
            pnlSlotContainer.Controls.Add(pnlSlot2);
            pnlSlotContainer.Controls.Add(pnlSlot1);
            pnlSlotContainer.Dock = DockStyle.Fill;
            pnlSlotContainer.Location = new Point(0, 106);
            pnlSlotContainer.Margin = new Padding(0);
            pnlSlotContainer.Name = "pnlSlotContainer";
            pnlSlotContainer.Padding = new Padding(16, 12, 16, 16);
            pnlSlotContainer.Size = new Size(823, 529);
            pnlSlotContainer.TabIndex = 2;
            // 
            // pnlSlot3
            // 
            pnlSlot3.BackColor = Color.FromArgb(32, 39, 52);
            pnlSlot3.BorderStyle = BorderStyle.FixedSingle;
            pnlSlot3.Controls.Add(btnSlot3Action);
            pnlSlot3.Controls.Add(lbSlot3Details);
            pnlSlot3.Controls.Add(lbSlot3PlayerName);
            pnlSlot3.Controls.Add(lbSlot3Title);
            pnlSlot3.Location = new Point(16, 260);
            pnlSlot3.Margin = new Padding(0, 0, 0, 12);
            pnlSlot3.Name = "pnlSlot3";
            pnlSlot3.Padding = new Padding(16, 12, 16, 12);
            pnlSlot3.Size = new Size(656, 112);
            pnlSlot3.TabIndex = 2;
            // 
            // btnSlot3Action
            // 
            btnSlot3Action.BackColor = Color.FromArgb(124, 92, 220);
            btnSlot3Action.Cursor = Cursors.Hand;
            btnSlot3Action.FlatAppearance.BorderSize = 0;
            btnSlot3Action.FlatAppearance.MouseDownBackColor = Color.FromArgb(99, 70, 190);
            btnSlot3Action.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 112, 235);
            btnSlot3Action.FlatStyle = FlatStyle.Flat;
            btnSlot3Action.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            btnSlot3Action.ForeColor = Color.White;
            btnSlot3Action.Location = new Point(520, 36);
            btnSlot3Action.Margin = new Padding(0);
            btnSlot3Action.Name = "btnSlot3Action";
            btnSlot3Action.Size = new Size(104, 40);
            btnSlot3Action.TabIndex = 3;
            btnSlot3Action.TabStop = false;
            btnSlot3Action.Text = "儲存";
            btnSlot3Action.UseVisualStyleBackColor = false;
            btnSlot3Action.Click += btnSlot3Action_Click;
            // 
            // lbSlot3Details
            // 
            lbSlot3Details.ForeColor = Color.FromArgb(160, 172, 190);
            lbSlot3Details.Location = new Point(16, 72);
            lbSlot3Details.Name = "lbSlot3Details";
            lbSlot3Details.Size = new Size(430, 24);
            lbSlot3Details.TabIndex = 2;
            lbSlot3Details.Text = "等級：--　階段：--　存檔時間：--";
            lbSlot3Details.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbSlot3PlayerName
            // 
            lbSlot3PlayerName.AutoEllipsis = true;
            lbSlot3PlayerName.BackColor = Color.Transparent;
            lbSlot3PlayerName.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold);
            lbSlot3PlayerName.ForeColor = Color.FromArgb(240, 244, 248);
            lbSlot3PlayerName.Location = new Point(16, 40);
            lbSlot3PlayerName.Margin = new Padding(0);
            lbSlot3PlayerName.Name = "lbSlot3PlayerName";
            lbSlot3PlayerName.Size = new Size(300, 28);
            lbSlot3PlayerName.TabIndex = 1;
            lbSlot3PlayerName.Text = "尚無存檔";
            lbSlot3PlayerName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbSlot3Title
            // 
            lbSlot3Title.BackColor = Color.Transparent;
            lbSlot3Title.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbSlot3Title.ForeColor = Color.FromArgb(176, 186, 202);
            lbSlot3Title.Location = new Point(16, 12);
            lbSlot3Title.Margin = new Padding(0);
            lbSlot3Title.Name = "lbSlot3Title";
            lbSlot3Title.Size = new Size(100, 24);
            lbSlot3Title.TabIndex = 0;
            lbSlot3Title.Text = "存檔槽 3";
            lbSlot3Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSlot2
            // 
            pnlSlot2.BackColor = Color.FromArgb(32, 39, 52);
            pnlSlot2.BorderStyle = BorderStyle.FixedSingle;
            pnlSlot2.Controls.Add(btnSlot2Action);
            pnlSlot2.Controls.Add(lbSlot2Details);
            pnlSlot2.Controls.Add(lbSlot2PlayerName);
            pnlSlot2.Controls.Add(lbSlot2Title);
            pnlSlot2.Location = new Point(16, 136);
            pnlSlot2.Margin = new Padding(0, 0, 0, 12);
            pnlSlot2.Name = "pnlSlot2";
            pnlSlot2.Padding = new Padding(16, 12, 16, 12);
            pnlSlot2.Size = new Size(656, 112);
            pnlSlot2.TabIndex = 1;
            // 
            // btnSlot2Action
            // 
            btnSlot2Action.BackColor = Color.FromArgb(124, 92, 220);
            btnSlot2Action.Cursor = Cursors.Hand;
            btnSlot2Action.FlatAppearance.BorderSize = 0;
            btnSlot2Action.FlatAppearance.MouseDownBackColor = Color.FromArgb(99, 70, 190);
            btnSlot2Action.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 112, 235);
            btnSlot2Action.FlatStyle = FlatStyle.Flat;
            btnSlot2Action.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            btnSlot2Action.ForeColor = Color.White;
            btnSlot2Action.Location = new Point(520, 36);
            btnSlot2Action.Margin = new Padding(0);
            btnSlot2Action.Name = "btnSlot2Action";
            btnSlot2Action.Size = new Size(104, 40);
            btnSlot2Action.TabIndex = 3;
            btnSlot2Action.TabStop = false;
            btnSlot2Action.Text = "儲存";
            btnSlot2Action.UseVisualStyleBackColor = false;
            btnSlot2Action.Click += btnSlot2Action_Click;
            // 
            // lbSlot2Details
            // 
            lbSlot2Details.ForeColor = Color.FromArgb(160, 172, 190);
            lbSlot2Details.Location = new Point(16, 72);
            lbSlot2Details.Name = "lbSlot2Details";
            lbSlot2Details.Size = new Size(430, 24);
            lbSlot2Details.TabIndex = 2;
            lbSlot2Details.Text = "等級：--　階段：--　存檔時間：--";
            lbSlot2Details.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbSlot2PlayerName
            // 
            lbSlot2PlayerName.AutoEllipsis = true;
            lbSlot2PlayerName.BackColor = Color.Transparent;
            lbSlot2PlayerName.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold);
            lbSlot2PlayerName.ForeColor = Color.FromArgb(240, 244, 248);
            lbSlot2PlayerName.Location = new Point(16, 40);
            lbSlot2PlayerName.Margin = new Padding(0);
            lbSlot2PlayerName.Name = "lbSlot2PlayerName";
            lbSlot2PlayerName.Size = new Size(300, 28);
            lbSlot2PlayerName.TabIndex = 1;
            lbSlot2PlayerName.Text = "尚無存檔";
            lbSlot2PlayerName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbSlot2Title
            // 
            lbSlot2Title.BackColor = Color.Transparent;
            lbSlot2Title.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbSlot2Title.ForeColor = Color.FromArgb(176, 186, 202);
            lbSlot2Title.Location = new Point(16, 12);
            lbSlot2Title.Margin = new Padding(0);
            lbSlot2Title.Name = "lbSlot2Title";
            lbSlot2Title.Size = new Size(100, 24);
            lbSlot2Title.TabIndex = 0;
            lbSlot2Title.Text = "存檔槽 2";
            lbSlot2Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSlot1
            // 
            pnlSlot1.BackColor = Color.FromArgb(32, 39, 52);
            pnlSlot1.BorderStyle = BorderStyle.FixedSingle;
            pnlSlot1.Controls.Add(btnSlot1Action);
            pnlSlot1.Controls.Add(lbSlot1Details);
            pnlSlot1.Controls.Add(lbSlot1PlayerName);
            pnlSlot1.Controls.Add(lbSlot1Title);
            pnlSlot1.Location = new Point(16, 12);
            pnlSlot1.Margin = new Padding(0, 0, 0, 12);
            pnlSlot1.Name = "pnlSlot1";
            pnlSlot1.Padding = new Padding(16, 12, 16, 12);
            pnlSlot1.Size = new Size(656, 112);
            pnlSlot1.TabIndex = 0;
            // 
            // btnSlot1Action
            // 
            btnSlot1Action.BackColor = Color.FromArgb(124, 92, 220);
            btnSlot1Action.Cursor = Cursors.Hand;
            btnSlot1Action.FlatAppearance.BorderSize = 0;
            btnSlot1Action.FlatAppearance.MouseDownBackColor = Color.FromArgb(99, 70, 190);
            btnSlot1Action.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 112, 235);
            btnSlot1Action.FlatStyle = FlatStyle.Flat;
            btnSlot1Action.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            btnSlot1Action.ForeColor = Color.White;
            btnSlot1Action.Location = new Point(520, 36);
            btnSlot1Action.Margin = new Padding(0);
            btnSlot1Action.Name = "btnSlot1Action";
            btnSlot1Action.Size = new Size(104, 40);
            btnSlot1Action.TabIndex = 3;
            btnSlot1Action.TabStop = false;
            btnSlot1Action.Text = "儲存";
            btnSlot1Action.UseVisualStyleBackColor = false;
            btnSlot1Action.Click += btnSlot1Action_Click;
            // 
            // lbSlot1Details
            // 
            lbSlot1Details.ForeColor = Color.FromArgb(160, 172, 190);
            lbSlot1Details.Location = new Point(16, 72);
            lbSlot1Details.Name = "lbSlot1Details";
            lbSlot1Details.Size = new Size(430, 24);
            lbSlot1Details.TabIndex = 2;
            lbSlot1Details.Text = "等級：--　階段：--　存檔時間：--";
            lbSlot1Details.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbSlot1PlayerName
            // 
            lbSlot1PlayerName.AutoEllipsis = true;
            lbSlot1PlayerName.BackColor = Color.Transparent;
            lbSlot1PlayerName.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold);
            lbSlot1PlayerName.ForeColor = Color.FromArgb(240, 244, 248);
            lbSlot1PlayerName.Location = new Point(16, 40);
            lbSlot1PlayerName.Margin = new Padding(0);
            lbSlot1PlayerName.Name = "lbSlot1PlayerName";
            lbSlot1PlayerName.Size = new Size(300, 28);
            lbSlot1PlayerName.TabIndex = 1;
            lbSlot1PlayerName.Text = "尚無存檔";
            lbSlot1PlayerName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbSlot1Title
            // 
            lbSlot1Title.BackColor = Color.Transparent;
            lbSlot1Title.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbSlot1Title.ForeColor = Color.FromArgb(176, 186, 202);
            lbSlot1Title.Location = new Point(16, 12);
            lbSlot1Title.Margin = new Padding(0);
            lbSlot1Title.Name = "lbSlot1Title";
            lbSlot1Title.Size = new Size(100, 24);
            lbSlot1Title.TabIndex = 0;
            lbSlot1Title.Text = "存檔槽 1";
            lbSlot1Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SaveLoadForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(24, 29, 39);
            ClientSize = new Size(823, 635);
            Controls.Add(pnlSlotContainer);
            Controls.Add(pnlMode);
            Controls.Add(pnlHeader);
            Font = new Font("Microsoft JhengHei UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(823, 635);
            Name = "SaveLoadForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SaveLoadForm";
            pnlHeader.ResumeLayout(false);
            pnlMode.ResumeLayout(false);
            pnlSlotContainer.ResumeLayout(false);
            pnlSlot3.ResumeLayout(false);
            pnlSlot2.ResumeLayout(false);
            pnlSlot1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lbTitle;
        private Button btnClose;
        private Panel pnlMode;
        private Button btnSaveMode;
        private Button btnLoadMode;
        private Panel pnlSlotContainer;
        private Panel pnlSlot1;
        private Label lbSlot1Title;
        private Label lbSlot1Details;
        private Label lbSlot1PlayerName;
        private Button btnSlot1Action;
        private Panel pnlSlot2;
        private Button btnSlot2Action;
        private Label lbSlot2Details;
        private Label lbSlot2PlayerName;
        private Label lbSlot2Title;
        private Panel pnlSlot3;
        private Button btnSlot3Action;
        private Label lbSlot3Details;
        private Label lbSlot3PlayerName;
        private Label lbSlot3Title;
    }
}