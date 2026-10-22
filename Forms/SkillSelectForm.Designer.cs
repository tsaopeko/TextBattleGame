namespace TextBattleGame.Forms
{
    partial class SkillSelectForm
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
            lblTitle = new Label();
            flpSkillList = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(38, 42, 54);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(12, 0, 8, 0);
            pnlHeader.Size = new Size(594, 50);
            pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 70, 85);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 108, 122);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(243, 244, 246);
            btnClose.Location = new Point(536, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 1;
            btnClose.Text = "×";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(243, 244, 246);
            lblTitle.Location = new Point(12, 0);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "選擇技能";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpSkillList
            // 
            flpSkillList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpSkillList.AutoScroll = true;
            flpSkillList.FlowDirection = FlowDirection.TopDown;
            flpSkillList.Location = new Point(16, 66);
            flpSkillList.Name = "flpSkillList";
            flpSkillList.Padding = new Padding(4);
            flpSkillList.Size = new Size(550, 300);
            flpSkillList.TabIndex = 0;
            flpSkillList.WrapContents = false;
            // 
            // SkillSelectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 26, 33);
            ClientSize = new Size(594, 476);
            Controls.Add(flpSkillList);
            Controls.Add(pnlHeader);
            Font = new Font("Microsoft JhengHei UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SkillSelectForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "選擇技能";
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnClose;
        private FlowLayoutPanel flpSkillList;
    }
}