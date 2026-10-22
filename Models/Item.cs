using System;
using System.Collections.Generic;
using System.Text;

namespace TextBattleGame.Models
{
    /// <summary>
    /// 道具類型
    /// </summary>
    public enum ItemType
    {
        HealthPotion, ManaPotion
    }
    /// <summary>
    /// 遊戲道具資料
    /// </summary>
    public class Item
    {
        public int Id { get; set; } // 道具唯一編號
        public string Name { get; set; } = string.Empty;    // 道具名稱
        public string Description { get; set; } = string.Empty;  // 道具說明
        public ItemType Type { get; set; }  // 道具類型
        public int RestoreAmount { get; set; }  // 恢復數值
    }

    /// <summary>
    /// 道具使用結果
    /// </summary>
    public enum ItemUseResult
    {
        Success,    // 成功使用
        NoItemSelected, // 尚未選取道具
        InsufficientQuantity,   // 持有數量不足
        AlreadyAtMaximum,   // 生命值或魔力值已滿
        InvalidItem // 道具資料無效
    }

    public static class ItemIds
    {
        public const int HealthPotion = 1;  // 生命藥水ID
        public const int ManaPotion = 2;    // 魔力藥水ID
    }
}
