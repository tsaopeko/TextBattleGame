using System;
using System.Collections.Generic;
using System.Text;

namespace TextBattleGame.SaveSystem
{
    /// <summary>
    /// 保存單一遊戲存檔所需的資料
    /// </summary>
    public class GameSaveData
    {
        public int SaveVersion { get; set; } = 1;   // 存檔格式版本, 用於日後更新存檔結構
        public DateTime SavedAt { get; set; }   // 存檔時間
        public string PlayerName { get; set; } = string.Empty;  // 角色名稱
        public int Level { get; set; }      // 角色等級
        public int Experience { get; set; }     // 目前經驗值
        public int StatPoints { get; set; }     // 剩餘能力點
        public int Strength { get; set; }   // 力量
        public int Vitality { get; set; }   // 體質
        public int Intelligence { get; set; }   // 智力
        public int Dexterity { get; set; }  // 敏捷
        public int CurrentStage { get; set; } = 1;  // 目前遊戲階段
        public Dictionary<int, int> InventoryItems { get; set; } = new();   // 背包道具編號與持有數量
    }
}
