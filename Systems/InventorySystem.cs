using System;
using System.Collections.Generic;
using System.Text;
using TextBattleGame.Models;

namespace TextBattleGame.Systems
{
    /// <summary>
    /// 背包管理系統
    /// </summary>
    public class InventorySystem
    {
        /// <summary>
        /// 儲存道具編號與持有數量
        /// Key : 道具編號
        /// Value : 持有數量
        /// </summary>
        private readonly Dictionary<int, int> _items = new();
        private readonly ItemRepository _itemRepository;    // 道具資料管理類別

        /// <summary>
        /// 建立背包管理系統
        /// </summary>
        /// <param name="itemRepository">道具資料管理物件</param>
        public InventorySystem(ItemRepository itemRepository)
        {
            _itemRepository = itemRepository ?? throw new ArgumentNullException(nameof(itemRepository));
        }

        /// <summary>
        /// 取得指定道具的持有數量
        /// </summary>
        /// <param name="itemId">道具編號</param>
        /// <returns>持有數量</returns>

        public int GetQuantity(int itemId)
        {
            return _items.TryGetValue(itemId, out int quantity) ? quantity : 0;
        }

        /// <summary>
        /// 增加指定道具的數量
        /// </summary>
        /// <param name="itemId">道具編號</param>
        /// <param name="quantity">增加數量</param>
        /// <returns>是否增加成功</returns>
        public bool AddItem(int itemId, int quantity)
        {
            if(itemId <= 0 || quantity <= 0)
            {
                return false;
            }

            // 確認道具是否存在
            if(_itemRepository.GetById(itemId) == null)
            {
                return false;
            }

            int currentQuantity = GetQuantity(itemId);

            // 避免數量相加時發生整數溢位
            if(currentQuantity > int.MaxValue - quantity)
            {
                return false;
            }

            _items[itemId] = currentQuantity + quantity;

            return true;
        }

        /// <summary>
        /// 移除指定數量的道具
        /// </summary>
        /// <param name="itemId">道具編號</param>
        /// <param name="quantity">移除數量</param>
        /// <returns>是否移除成功</returns>
        public bool RemoveItem(int itemId, int quantity)
        {
            if(itemId <= 0 || quantity <= 0)
            {
                return false;
            }

            int currentQuantity = GetQuantity(itemId);

            if(currentQuantity < quantity)
            {
                return false;
            }

            int remainingQuantity = currentQuantity - quantity;

            if(remainingQuantity == 0)
            {
                _items.Remove(itemId);
            }
            else
            {
                _items[itemId] = remainingQuantity;
            }
            return true;
        }

        /// <summary>
        /// 使用指定道具並恢復玩家生命值或魔力值
        /// </summary>
        /// <param name="player">要使用道具的玩家</param>
        /// <param name="itemId">道具編號</param>
        /// <returns>道具使用結果</returns>
        public ItemUseResult UseItem(Player player, int itemId)
        {
            // 確認玩家是否有效
            if(player == null)
            {
                return ItemUseResult.InvalidItem;
            }

            // 確認道具是否存在
            Item? item = _itemRepository.GetById(itemId);

            if(item == null)
            {
                return ItemUseResult.InvalidItem;
            }

            // 確認道具數量是否足夠
            if(GetQuantity(itemId) <= 0)
            {
                return ItemUseResult.InsufficientQuantity;
            }

            // 根據道具類型執行恢復
            switch(item.Type)
            {
                case ItemType.HealthPotion:
                    // 生命值已滿, 不消耗道具
                    if(player.CurrentHP >= player.MaxHP)
                    {
                        return ItemUseResult.AlreadyAtMaximum;
                    }

                    player.CurrentHP = Math.Min(player.MaxHP, player.CurrentHP + item.RestoreAmount);
                    break;
                case ItemType.ManaPotion:
                    // 魔力值已滿, 不消耗道具
                    if(player.CurrentMP >= player.MaxMP)
                    {
                        return ItemUseResult.AlreadyAtMaximum;
                    }

                    player.CurrentMP = Math.Min(player.MaxMP, player.CurrentMP + item.RestoreAmount);
                    break;
                default:
                    return ItemUseResult.InvalidItem;
            }

            // 恢復成功後才扣除道具
            if(RemoveItem(itemId, 1) == false)
            {
                return ItemUseResult.InsufficientQuantity;
            }

            return ItemUseResult.Success;
        }

        /// <summary>
        /// 取得背包中所有道具的編號與數量
        /// </summary>
        /// <returns>背包內容的副本</returns>
        public Dictionary<int, int> GetAllItems()
        {
            return new Dictionary<int, int>(_items);
        }

        /// <summary>
        /// 退還指定數量的道具
        /// </summary>
        /// <param name="itemId">道具編號</param>
        /// <param name="quantity">退還數量</param>
        /// <returns>是否成功退還</returns>
        public bool RefundItem(int itemId, int quantity)
        {
            // 檢查道具是否存在
            if(_itemRepository.GetById(itemId) == null)
            {
                return false;
            }

            // 數量必須大於0
            if (quantity <= 0)
            {
                return false;
            }

            AddItem(itemId, quantity);  // 加回背包數量

            return true;
        }

        /// <summary>
        /// 以存檔資料完整還原背包內容
        /// </summary>
        /// <param name="savedItems">存檔中的道具編號與數量</param>
        public void RestoreItems(Dictionary<int, int> savedItems)
        {
            if(savedItems == null)
            {
                throw new ArgumentNullException(nameof(savedItems));
            }

            // 先驗證所有道具, 避免還原到一半才發生錯誤
            foreach(KeyValuePair<int, int> item in savedItems)
            {
                if(item.Value <= 0)
                {
                    throw new ArgumentException($"道具ID{item.Key}的數量必須大於0", nameof(savedItems));
                }

                // 確認道具存在於目前的道具資料庫
                if(_itemRepository.GetById(item.Key) == null)
                {
                    throw new ArgumentException($"找不到道具ID:{item.Key}", nameof(savedItems));
                }
            }

            // 驗證通過後, 才完整取代背包內容
            _items.Clear();

            foreach(KeyValuePair<int, int> item in savedItems)
            {
                _items.Add(item.Key, item.Value);
            }
        }
    }
}
