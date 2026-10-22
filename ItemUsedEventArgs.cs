using System;
using System.Collections.Generic;
using System.Text;

namespace TextBattleGame
{
    /// <summary>
    /// 道具使用事件資料
    /// </summary>
    public class ItemUsedEventArgs : EventArgs
    {
        public int ItemId { get; }  // 使用的道具編號

        public ItemUsedEventArgs(int itemId)
        {
            ItemId = itemId;
        }
    }
}
