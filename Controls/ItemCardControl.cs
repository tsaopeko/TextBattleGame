using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TextBattleGame.Models;

namespace TextBattleGame.Controls
{
    public partial class ItemCardControl : UserControl
    {
        public Item? ItemData { get; private set; } // 目前卡片顯示的道具資料
        public bool IsSelected { get; private set; }    // 卡片目前是否被選取
        public event EventHandler? ItemSelected;    // 卡片被選取時發生的事件
        public ItemCardControl()
        {
            InitializeComponent();

            RegisterChildEvents();

            MouseEnter += ItemCardControl_MouseEnter;
            MouseLeave += ItemCardControl_MouseLeave;
            Click += ItemCardControl_Click;
        }

        /// <summary>
        /// 設定卡片要顯示的道具資料
        /// </summary>
        /// <param name="item">要顯示的道具</param>
        /// <param name="quantity">目前持有數量</param>
        public void SetItem(Item item, int quantity)
        {
            ArgumentNullException.ThrowIfNull(item);

            if(quantity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity));
            }

            ItemData = item;

            lbCardItemName.Text = item.Name;
            lbCardItemDescription.Text = item.Description;
            lbCardItemQuantity.Text = $"持有 : {quantity}";
        }

        /// <summary>
        /// 設定卡片是否被選取
        /// </summary>
        /// <param name="selected">是否選取</param>
        public void SetSelected(bool selected)
        {
            IsSelected = selected;
            UpdateCardStyle();
        }

        /// <summary>
        /// 更新卡片外觀
        /// </summary>
        private void UpdateCardStyle()
        {
            if(IsSelected)
            {
                BackColor = Color.FromArgb(45, 53, 70);
            }
            else
            {
                BackColor = Color.FromArgb(37, 44, 59);
            }

            Invalidate();
        }

        /// <summary>
        /// 滑鼠移入卡片
        /// </summary>
        private void ItemCardControl_MouseEnter(object? sender, EventArgs e)
        {
            if(IsSelected == false)
            {
                BackColor = Color.FromArgb(53, 62, 81);
            }
        }

        /// <summary>
        /// 滑鼠離開卡片
        /// </summary>
        private void ItemCardControl_MouseLeave(object? sender, EventArgs e)
        {
            UpdateCardStyle();
        }

        /// <summary>
        /// 點擊卡片
        /// </summary>
        private void ItemCardControl_Click(object? sender, EventArgs e)
        {
            ItemSelected?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// 設定卡片內部控制項的滑鼠事件
        /// </summary>
        private void RegisterChildEvents()
        {
            lbCardItemName.Click += ItemCardControl_Click;
            lbCardItemDescription.Click += ItemCardControl_Click;
            lbCardItemQuantity.Click += ItemCardControl_Click;
        }

        /// <summary>
        /// 繪製卡片選取邊框
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if(IsSelected)
            {
                using Pen pen = new Pen(Color.FromArgb(214, 183, 122), 2);
                Rectangle border = new Rectangle(1, 1, Width - 3, Height - 3);

                e.Graphics.DrawRectangle(pen, border);
            }    
        }
    }
}
