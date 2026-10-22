using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace TextBattleGame.SaveSystem
{
    /// <summary>
    /// 負責管理遊戲存檔與讀檔
    /// </summary>
    public class SaveLoadSystem
    {
        public const int MaxSaveSlots = 3;  // 最大存檔槽數量
        private readonly string _saveDirectory; // 存檔資料夾路徑

        /// <summary>
        /// 建立存檔系統
        /// </summary>
        public SaveLoadSystem()
        {
            _saveDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TextBattleGame", "Saves");

            Directory.CreateDirectory(_saveDirectory);  // 建立資料夾
        }

        /// <summary>
        /// 取得指定存檔槽的檔案路徑
        /// </summary>
        /// <param name="slotNumber">存檔槽編號, 範圍1到3</param>
        /// <returns>存檔檔案完整路徑</returns>
        private string GetSaveFilePath(int slotNumber)
        {
            if(slotNumber < 1 || slotNumber > MaxSaveSlots)
            {
                throw new ArgumentOutOfRangeException(nameof(slotNumber), $"存檔槽編號必須介於1到{MaxSaveSlots}");
            }

            return Path.Combine(_saveDirectory, $"slot{slotNumber}.json");
        }

        /// <summary>
        /// 將遊戲資料儲存至指定存檔槽
        /// </summary>
        /// <param name="slotNumber">存檔槽編號</param>
        /// <param name="saveData">要儲存的遊戲資料</param>
        public void Save(int slotNumber, GameSaveData saveData)
        {
            if(saveData == null)
            {
                throw new ArgumentNullException(nameof(saveData));
            }

            string filePath = GetSaveFilePath(slotNumber);

            saveData.SaveVersion = 1;
            saveData.SavedAt = DateTime.Now;

            // JsonSerializer.Serialize()：物件轉成 JSON, WriteIndented = true 會讓 JSON 保留縮排，方便之後檢查存檔內容。
            string json = JsonSerializer.Serialize(saveData, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(filePath, json);  // File.WriteAllText()：寫入檔案
        }

        /// <summary>
        /// 從指定存檔槽讀取遊戲資料
        /// </summary>
        /// <param name="slotNumber">存檔槽編號</param>
        /// <returns>讀取成功時回傳遊戲資料, 存檔不存在時回傳null</returns>
        public GameSaveData Load(int slotNumber)
        {
            string filePath = GetSaveFilePath(slotNumber);

            if(File.Exists(filePath) == false)
            {
                return null;
            }

            try
            {
                string json = File.ReadAllText(filePath);   // 讀取JSON文字

                GameSaveData saveData = JsonSerializer.Deserialize<GameSaveData>(json); // 將JSON還原成GameSaveData物件

                return saveData;
            }
            catch (JsonException ex)
            {
                throw new InvalidDataException($"存檔槽{slotNumber}的JSON格式不正確", ex);
            }
        }

        /// <summary>
        /// 檢查指定存檔槽是否存在存檔
        /// </summary>
        /// <param name="slotNumber">存檔槽編號</param>
        /// <returns>存檔存在時回傳true, 否則回傳false</returns>
        public bool SaveExists(int slotNumber)
        {
            string filePath = GetSaveFilePath(slotNumber);

            return File.Exists(filePath);
        }

        /// <summary>
        /// 取得指定存檔槽的資料
        /// </summary>
        /// <param name="slotNumber">存檔槽編號</param>
        /// <returns>存檔資料, 或沒有則回傳null</returns>
        public GameSaveData GetSaveInfo(int slotNumber)
        {
            return Load(slotNumber);
        }
    }
}
