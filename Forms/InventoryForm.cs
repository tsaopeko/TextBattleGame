using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TextBattleGame.Controls;
using TextBattleGame.Models;
using TextBattleGame.Systems;

namespace TextBattleGame.Forms
{
    public partial class InventoryForm : Form
    {
        private readonly ItemRepository _itemRepository;    // 道具資料來源
        private readonly InventorySystem _inventorySystem;  // 玩家背包系統
        private ItemCardControl? _selectedCard; // 目前選取的道具卡片
        private ItemType? _selectedCategory;    // 目前選取的道具分類
        private readonly bool _isBattleMode;    // 背包目前是否處於戰鬥使用模式
        private readonly Player _player;
        public event EventHandler<ItemUsedEventArgs>? ItemUsedInBattle;    // 戰鬥中成功使用道具時觸發
        private readonly Func<bool>? _isBattleEnded;    // 檢查戰鬥是否已結束
        public InventoryForm(Player player, ItemRepository itemRepository, InventorySystem inventorySystem, bool isBattleMode = false, Func<bool>? isBattleEnded = null)
        {
            InitializeComponent();

            _player = player ?? throw new ArgumentNullException(nameof(player));
            _itemRepository = itemRepository ?? throw new ArgumentNullException(nameof(itemRepository));
            _inventorySystem = inventorySystem ?? throw new ArgumentNullException(nameof(inventorySystem));
            _isBattleMode = isBattleMode;
            _isBattleEnded = isBattleEnded;

            LoadItemCards();
        }

        /// <summary>
        /// 載入玩家持有的道具卡片
        /// </summary>
        private void LoadItemCards()
        {
            flpItems.Controls.Clear();

            Dictionary<int, int> items = _inventorySystem.GetAllItems();

            foreach (KeyValuePair<int, int> entry in items)
            {
                // 取得道具基本資料
                Item? item = _itemRepository.GetById(entry.Key);

                // 道具不存在或數量不正確時不建立卡片
                if (item == null || entry.Value <= 0)
                {
                    continue;
                }

                // 若已選擇分類 只顯示符合條件的道具
                if (_selectedCategory.HasValue && item.Type != _selectedCategory.Value)
                {
                    continue;
                }

                // 建立道具卡片
                ItemCardControl card = new ItemCardControl();

                // 設定卡片資料
                card.SetItem(item, entry.Value);

                // 註冊卡片選取事件
                card.ItemSelected += ItemCard_ItemSelected;

                // 加入卡片容器
                flpItems.Controls.Add(card);
            }

            // 切換分類後, 清除舊卡片的選取狀態
            _selectedCard = null;
            lbItemName.Text = "尚未選取道具";
            lbItemQuantity.Text = "持有數量 : 0";
            lbItemDescription.Text = "選取道具後, 這裡會顯示道具說明";
            btnUseItem.Enabled = false;
        }

        /// <summary>
        /// 處理道具卡片選取事件
        /// </summary>
        private void ItemCard_ItemSelected(object? sender, EventArgs e)
        {
            if (sender is not ItemCardControl card)
            {
                return;
            }

            // 取消上一張卡片的選取狀態
            if (_selectedCard != null)
            {
                _selectedCard.SetSelected(false);
            }

            // 紀錄並選取目前的卡片
            _selectedCard = card;
            _selectedCard.SetSelected(true);

            // 更新底部道具詳細資訊
            if (card.ItemData == null)
            {
                return;
            }

            lbItemName.Text = card.ItemData.Name;
            lbItemDescription.Text = card.ItemData.Description;
            lbItemQuantity.Text = $"持有數量 : {_inventorySystem.GetQuantity(card.ItemData.Id)}";

            // 選取道具後才允許操作
            btnUseItem.Enabled = true;
        }

        /// <summary>
        /// 切換道具分類
        /// </summary>
        /// <param name="category">要顯示的道具分類, null代表全部</param>
        private void ChangeCategory(ItemType? category)
        {
            _selectedCategory = category;

            LoadItemCards();

            // 更新分類按鈕外觀
            UpdateCategoryButtons();
        }

        /// <summary>
        /// 更新分類按鈕的選取外觀
        /// </summary>
        private void UpdateCategoryButtons()
        {
            SetCategoryButtonStyle(btnAllItems, _selectedCategory.HasValue == false);
            SetCategoryButtonStyle(btnHealthItems, _selectedCategory == ItemType.HealthPotion);
            SetCategoryButtonStyle(btnManaItems, _selectedCategory == ItemType.ManaPotion);
        }

        /// <summary>
        /// 設定分類按鈕的外觀
        /// </summary>
        private void SetCategoryButtonStyle(Button button, bool selected)
        {
            if (selected)
            {
                button.BackColor = Color.FromArgb(214, 183, 122);
                button.ForeColor = Color.FromArgb(23, 27, 39);
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 204, 148);
            }
            else
            {
                button.BackColor = Color.FromArgb(37, 44, 59);
                button.ForeColor = Color.FromArgb(240, 235, 221);
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(53, 62, 81);
            }
        }

        private void btnAllItems_Click(object sender, EventArgs e)
        {
            ChangeCategory(null);
        }

        private void btnHealthItems_Click(object sender, EventArgs e)
        {
            ChangeCategory(ItemType.HealthPotion);
        }

        private void btnManaItems_Click(object sender, EventArgs e)
        {
            ChangeCategory(ItemType.ManaPotion);
        }

        /// <summary>
        /// 使用目前選取的道具
        /// </summary>
        private void btnUseItem_Click(object sender, EventArgs e)
        {
            if (_isBattleMode && (_isBattleEnded?.Invoke() ?? true))
            {
                btnUseItem.Enabled = false;
                MessageBox.Show("戰鬥已經結束, 無法使用道具", "無法使用", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 確認已經選取道具
            if (_selectedCard?.ItemData == null)
            {
                MessageBox.Show("請先選取要使用的道具", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Item item = _selectedCard.ItemData; // 取得選取的道具

            ItemUseResult result = _inventorySystem.UseItem(_player, item.Id);  // 使用道具

            // 根據結果顯示訊息
            switch (result)
            {
                case ItemUseResult.Success:
                    MessageBox.Show($"成功使用「{item.Name}」!", "使用成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadItemCards();    // 重新載入背包, 更新道具數量
                    // 更新背包道具數量
                    if(_isBattleMode)
                    {
                        ItemUsedInBattle?.Invoke(this, new ItemUsedEventArgs(item.Id));
                    }
                    break;
                case ItemUseResult.AlreadyAtMaximum:
                    MessageBox.Show(item.Type == ItemType.HealthPotion ? "目前生命值已滿, 無法使用生命藥水" : "目前魔力值已滿, 無法使用魔力藥水",
                        "無法使用", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case ItemUseResult.InsufficientQuantity:
                    MessageBox.Show("道具數量不足", "無法使用", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("無法使用這個道具", "使用失敗", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CloseInventory()
        {
            Close();
        }
    }
}
