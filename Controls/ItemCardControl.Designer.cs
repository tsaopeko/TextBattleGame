namespace TextBattleGame.Controls
{
    partial class ItemCardControl
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
            lbCardItemName = new Label();
            lbCardItemDescription = new Label();
            lbCardItemQuantity = new Label();
            SuspendLayout();
            // 
            // lbCardItemName
            // 
            lbCardItemName.AutoEllipsis = true;
            lbCardItemName.BackColor = Color.Transparent;
            lbCardItemName.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            lbCardItemName.Location = new Point(12, 12);
            lbCardItemName.Margin = new Padding(0);
            lbCardItemName.Name = "lbCardItemName";
            lbCardItemName.Size = new Size(196, 28);
            lbCardItemName.TabIndex = 0;
            lbCardItemName.Text = "生命藥水";
            lbCardItemName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbCardItemDescription
            // 
            lbCardItemDescription.AutoEllipsis = true;
            lbCardItemDescription.BackColor = Color.Transparent;
            lbCardItemDescription.Font = new Font("Microsoft JhengHei UI", 8.5F);
            lbCardItemDescription.ForeColor = Color.FromArgb(176, 184, 198);
            lbCardItemDescription.Location = new Point(12, 48);
            lbCardItemDescription.Margin = new Padding(0);
            lbCardItemDescription.Name = "lbCardItemDescription";
            lbCardItemDescription.Size = new Size(196, 42);
            lbCardItemDescription.TabIndex = 1;
            lbCardItemDescription.Text = "恢復 30 點生命值";
            // 
            // lbCardItemQuantity
            // 
            lbCardItemQuantity.AutoSize = true;
            lbCardItemQuantity.BackColor = Color.Transparent;
            lbCardItemQuantity.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbCardItemQuantity.ForeColor = Color.FromArgb(214, 183, 122);
            lbCardItemQuantity.Location = new Point(12, 112);
            lbCardItemQuantity.Margin = new Padding(0);
            lbCardItemQuantity.Name = "lbCardItemQuantity";
            lbCardItemQuantity.Size = new Size(50, 15);
            lbCardItemQuantity.TabIndex = 2;
            lbCardItemQuantity.Text = "持有：3";
            lbCardItemQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ItemCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 44, 59);
            Controls.Add(lbCardItemQuantity);
            Controls.Add(lbCardItemDescription);
            Controls.Add(lbCardItemName);
            Cursor = Cursors.Hand;
            ForeColor = Color.FromArgb(240, 235, 221);
            Margin = new Padding(0, 0, 12, 12);
            MaximumSize = new Size(220, 150);
            MinimumSize = new Size(220, 150);
            Name = "ItemCardControl";
            Padding = new Padding(10);
            Size = new Size(220, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCardItemName;
        private Label lbCardItemDescription;
        private Label lbCardItemQuantity;
    }
}
