using System;
using System.Collections.Generic;
using System.Text;

namespace TextBattleGame.Models
{
    /// <summary>
    /// 道具資料管理類別
    /// </summary>
    public class ItemRepository
    {
        private readonly List<Item> _items = new()
        {
            new Item
            {
                Id = 1,
                Name = "生命藥水",
                Description = "恢復50點生命值",
                Type = ItemType.HealthPotion,
                RestoreAmount = 50
            },
            new Item
            {
                Id = 2,
                Name = "魔力藥水",
                Description = "恢復30點魔力值",
                Type = ItemType.ManaPotion,
                RestoreAmount = 30
            }
        };

        /// <summary>
        /// 根據道具編號取得道具資料
        /// </summary>
        /// <param name="id">道具編號</param>
        /// <returns>找到的道具</returns>
        public Item? GetById(int id)
        {
            return _items.FirstOrDefault(item => item.Id == id);
        }

        /// <summary>
        /// 取得所有道具的基本資料
        /// </summary>
        /// <returns>所有道具資料</returns>
        public List<Item> GetAll()
        {
            return _items.ToList();
        }
    }
}
