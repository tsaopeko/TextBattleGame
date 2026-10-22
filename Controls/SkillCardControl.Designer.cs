namespace TextBattleGame.Controls
{
    partial class SkillCardControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            lbSkillName = new Label();
            lbSkillDescription = new Label();
            lbSkillMpCost = new Label();
            SuspendLayout();
            // 
            // lbSkillName
            // 
            lbSkillName.BackColor = Color.Transparent;
            lbSkillName.Cursor = Cursors.Hand;
            lbSkillName.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold);
            lbSkillName.ForeColor = Color.FromArgb(243, 244, 246);
            lbSkillName.Location = new Point(12, 10);
            lbSkillName.Margin = new Padding(0);
            lbSkillName.Name = "lbSkillName";
            lbSkillName.Size = new Size(428, 26);
            lbSkillName.TabIndex = 1;
            lbSkillName.Text = "技能名稱";
            lbSkillName.TextAlign = ContentAlignment.MiddleLeft;
            lbSkillName.Click += lbSkillName_Click;
            // 
            // lbSkillDescription
            // 
            lbSkillDescription.BackColor = Color.Transparent;
            lbSkillDescription.Cursor = Cursors.Hand;
            lbSkillDescription.Font = new Font("Microsoft JhengHei UI", 9F);
            lbSkillDescription.ForeColor = Color.FromArgb(146, 152, 167);
            lbSkillDescription.Location = new Point(12, 38);
            lbSkillDescription.Margin = new Padding(0);
            lbSkillDescription.Name = "lbSkillDescription";
            lbSkillDescription.Size = new Size(428, 24);
            lbSkillDescription.TabIndex = 2;
            lbSkillDescription.Text = "技能說明會顯示在這裡";
            lbSkillDescription.TextAlign = ContentAlignment.MiddleLeft;
            lbSkillDescription.Click += lbSkillDescription_Click;
            // 
            // lbSkillMpCost
            // 
            lbSkillMpCost.BackColor = Color.Transparent;
            lbSkillMpCost.Cursor = Cursors.Hand;
            lbSkillMpCost.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbSkillMpCost.ForeColor = Color.FromArgb(167, 139, 250);
            lbSkillMpCost.Location = new Point(12, 72);
            lbSkillMpCost.Margin = new Padding(0);
            lbSkillMpCost.Name = "lbSkillMpCost";
            lbSkillMpCost.Size = new Size(200, 22);
            lbSkillMpCost.TabIndex = 3;
            lbSkillMpCost.Text = "MP 消耗：—";
            lbSkillMpCost.TextAlign = ContentAlignment.MiddleLeft;
            lbSkillMpCost.Click += lbSkillMpCost_Click;
            // 
            // SkillCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 38, 49);
            Controls.Add(lbSkillMpCost);
            Controls.Add(lbSkillDescription);
            Controls.Add(lbSkillName);
            Margin = new Padding(0, 0, 0, 10);
            MaximumSize = new Size(550, 112);
            MinimumSize = new Size(550, 112);
            Name = "SkillCardControl";
            Size = new Size(566, 112);
            Click += SkillCardControl_Click;
            ResumeLayout(false);
        }

        #endregion

        private Label lbSkillName;
        private Label lbSkillDescription;
        private Label lbSkillMpCost;
    }
}
