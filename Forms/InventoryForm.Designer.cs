namespace TextBattleGame.Forms
{
    partial class InventoryForm
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
            flpItemCategories = new FlowLayoutPanel();
            btnAllItems = new Button();
            btnHealthItems = new Button();
            btnManaItems = new Button();
            flpItems = new FlowLayoutPanel();
            pnlItemDetails = new Panel();
            btnUseItem = new Button();
            lbItemQuantity = new Label();
            lbItemDescription = new Label();
            lbItemName = new Label();
            pnlHeader.SuspendLayout();
            flpItemCategories.SuspendLayout();
            pnlItemDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(lbTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(12, 0, 12, 0);
            pnlHeader.Size = new Size(744, 50);
            pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 55, 68);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 82, 96);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.FromArgb(240, 235, 221);
            btnClose.Location = new Point(682, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 1;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbTitle
            // 
            lbTitle.Dock = DockStyle.Left;
            lbTitle.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            lbTitle.ForeColor = Color.FromArgb(240, 235, 221);
            lbTitle.Location = new Point(12, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(100, 50);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "冒險者背包";
            lbTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpItemCategories
            // 
            flpItemCategories.Controls.Add(btnAllItems);
            flpItemCategories.Controls.Add(btnHealthItems);
            flpItemCategories.Controls.Add(btnManaItems);
            flpItemCategories.Dock = DockStyle.Top;
            flpItemCategories.Location = new Point(0, 50);
            flpItemCategories.Margin = new Padding(0);
            flpItemCategories.Name = "flpItemCategories";
            flpItemCategories.Padding = new Padding(12, 8, 12, 8);
            flpItemCategories.Size = new Size(744, 52);
            flpItemCategories.TabIndex = 1;
            flpItemCategories.WrapContents = false;
            // 
            // btnAllItems
            // 
            btnAllItems.BackColor = Color.FromArgb(214, 183, 122);
            btnAllItems.FlatAppearance.BorderSize = 0;
            btnAllItems.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 204, 148);
            btnAllItems.FlatStyle = FlatStyle.Flat;
            btnAllItems.ForeColor = Color.FromArgb(23, 27, 39);
            btnAllItems.Location = new Point(12, 8);
            btnAllItems.Margin = new Padding(0, 0, 8, 0);
            btnAllItems.Name = "btnAllItems";
            btnAllItems.Padding = new Padding(4);
            btnAllItems.Size = new Size(132, 34);
            btnAllItems.TabIndex = 0;
            btnAllItems.Text = "全部道具";
            btnAllItems.UseVisualStyleBackColor = false;
            btnAllItems.Click += btnAllItems_Click;
            // 
            // btnHealthItems
            // 
            btnHealthItems.BackColor = Color.FromArgb(37, 44, 59);
            btnHealthItems.FlatAppearance.BorderSize = 0;
            btnHealthItems.FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 62, 81);
            btnHealthItems.FlatStyle = FlatStyle.Flat;
            btnHealthItems.ForeColor = Color.FromArgb(240, 235, 221);
            btnHealthItems.Location = new Point(152, 8);
            btnHealthItems.Margin = new Padding(0, 0, 8, 0);
            btnHealthItems.Name = "btnHealthItems";
            btnHealthItems.Padding = new Padding(4);
            btnHealthItems.Size = new Size(132, 34);
            btnHealthItems.TabIndex = 1;
            btnHealthItems.Text = "生命藥水";
            btnHealthItems.UseVisualStyleBackColor = false;
            btnHealthItems.Click += btnHealthItems_Click;
            // 
            // btnManaItems
            // 
            btnManaItems.BackColor = Color.FromArgb(37, 44, 59);
            btnManaItems.FlatAppearance.BorderSize = 0;
            btnManaItems.FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 62, 81);
            btnManaItems.FlatStyle = FlatStyle.Flat;
            btnManaItems.ForeColor = Color.FromArgb(240, 235, 221);
            btnManaItems.Location = new Point(292, 8);
            btnManaItems.Margin = new Padding(0, 0, 8, 0);
            btnManaItems.Name = "btnManaItems";
            btnManaItems.Padding = new Padding(4);
            btnManaItems.Size = new Size(132, 34);
            btnManaItems.TabIndex = 2;
            btnManaItems.Text = "魔力藥水";
            btnManaItems.UseVisualStyleBackColor = false;
            btnManaItems.Click += btnManaItems_Click;
            // 
            // flpItems
            // 
            flpItems.AutoScroll = true;
            flpItems.BackColor = Color.FromArgb(23, 27, 39);
            flpItems.Dock = DockStyle.Fill;
            flpItems.Location = new Point(0, 102);
            flpItems.Margin = new Padding(0);
            flpItems.Name = "flpItems";
            flpItems.Padding = new Padding(12);
            flpItems.Size = new Size(744, 419);
            flpItems.TabIndex = 2;
            // 
            // pnlItemDetails
            // 
            pnlItemDetails.Controls.Add(btnUseItem);
            pnlItemDetails.Controls.Add(lbItemQuantity);
            pnlItemDetails.Controls.Add(lbItemDescription);
            pnlItemDetails.Controls.Add(lbItemName);
            pnlItemDetails.Dock = DockStyle.Bottom;
            pnlItemDetails.Location = new Point(0, 401);
            pnlItemDetails.Margin = new Padding(0);
            pnlItemDetails.Name = "pnlItemDetails";
            pnlItemDetails.Padding = new Padding(12, 10, 12, 10);
            pnlItemDetails.Size = new Size(744, 120);
            pnlItemDetails.TabIndex = 0;
            // 
            // btnUseItem
            // 
            btnUseItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUseItem.BackColor = Color.FromArgb(214, 183, 122);
            btnUseItem.Cursor = Cursors.Hand;
            btnUseItem.Enabled = false;
            btnUseItem.FlatAppearance.BorderSize = 0;
            btnUseItem.FlatAppearance.MouseDownBackColor = Color.FromArgb(184, 153, 94);
            btnUseItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 204, 148);
            btnUseItem.FlatStyle = FlatStyle.Flat;
            btnUseItem.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            btnUseItem.ForeColor = Color.FromArgb(23, 27, 39);
            btnUseItem.Location = new Point(500, 14);
            btnUseItem.Margin = new Padding(0);
            btnUseItem.Name = "btnUseItem";
            btnUseItem.Size = new Size(112, 38);
            btnUseItem.TabIndex = 3;
            btnUseItem.Text = "使用道具";
            btnUseItem.UseVisualStyleBackColor = false;
            btnUseItem.Click += btnUseItem_Click;
            // 
            // lbItemQuantity
            // 
            lbItemQuantity.AutoSize = true;
            lbItemQuantity.BackColor = Color.Transparent;
            lbItemQuantity.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lbItemQuantity.ForeColor = Color.FromArgb(214, 183, 122);
            lbItemQuantity.Location = new Point(390, 18);
            lbItemQuantity.Margin = new Padding(0);
            lbItemQuantity.Name = "lbItemQuantity";
            lbItemQuantity.Size = new Size(74, 15);
            lbItemQuantity.TabIndex = 2;
            lbItemQuantity.Text = "持有數量：0";
            // 
            // lbItemDescription
            // 
            lbItemDescription.BackColor = Color.Transparent;
            lbItemDescription.ForeColor = Color.FromArgb(176, 184, 198);
            lbItemDescription.Location = new Point(12, 40);
            lbItemDescription.Margin = new Padding(0);
            lbItemDescription.Name = "lbItemDescription";
            lbItemDescription.Size = new Size(350, 40);
            lbItemDescription.TabIndex = 1;
            lbItemDescription.Text = "選取道具後，這裡會顯示道具說明。";
            // 
            // lbItemName
            // 
            lbItemName.AutoSize = true;
            lbItemName.BackColor = Color.Transparent;
            lbItemName.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold);
            lbItemName.ForeColor = Color.FromArgb(240, 235, 221);
            lbItemName.Location = new Point(12, 10);
            lbItemName.Margin = new Padding(0);
            lbItemName.Name = "lbItemName";
            lbItemName.Size = new Size(99, 19);
            lbItemName.TabIndex = 0;
            lbItemName.Text = "尚未選取道具";
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 37, 51);
            ClientSize = new Size(744, 521);
            Controls.Add(pnlItemDetails);
            Controls.Add(flpItems);
            Controls.Add(flpItemCategories);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "冒險者背包";
            pnlHeader.ResumeLayout(false);
            flpItemCategories.ResumeLayout(false);
            pnlItemDetails.ResumeLayout(false);
            pnlItemDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnClose;
        private Label lbTitle;
        private FlowLayoutPanel flpItemCategories;
        private FlowLayoutPanel flpItems;
        private Panel pnlItemDetails;
        private Button btnAllItems;
        private Button btnHealthItems;
        private Button btnManaItems;
        private Button btnUseItem;
        private Label lbItemQuantity;
        private Label lbItemDescription;
        private Label lbItemName;
    }
}