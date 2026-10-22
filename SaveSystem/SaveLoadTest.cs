using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TextBattleGame.SaveSystem
{
    /// <summary>
    /// 暫時用來測試存檔與讀檔功能
    /// </summary>
    internal static class SaveLoadTest
    {
        public static void Run()
        {
            SaveLoadSystem saveSystem = new SaveLoadSystem();

            GameSaveData testData = new GameSaveData
            {
                PlayerName = "測試角色",
                Level = 5,
                Experience = 200,
                StatPoints = 10,
                Strength = 8,
                Vitality = 7,
                Intelligence = 6,
                Dexterity = 9,
                CurrentStage = 3,
                InventoryItems = new Dictionary<int, int>
                {
                    { 1, 5 },
                    { 2, 3 }
                }
            };

            try
            {
                // 儲存至第一個存檔槽
                saveSystem.Save(1, testData);

                // 確認存檔是否存在
                if (!saveSystem.SaveExists(1))
                {
                    MessageBox.Show("存檔檔案沒有成功建立。");
                    return;
                }

                // 讀取存檔
                GameSaveData loadedData = saveSystem.Load(1);

                if (loadedData == null)
                {
                    MessageBox.Show("讀取失敗，沒有取得存檔資料。");
                    return;
                }

                // 確認讀取的資料與原始資料相同
                bool isCorrect =
                    loadedData.PlayerName == testData.PlayerName &&
                    loadedData.Level == testData.Level &&
                    loadedData.Experience == testData.Experience &&
                    loadedData.CurrentStage == testData.CurrentStage &&
                    loadedData.InventoryItems.Count == testData.InventoryItems.Count &&
                    loadedData.InventoryItems[1] == 5 &&
                    loadedData.InventoryItems[2] == 3;

                MessageBox.Show(
                    isCorrect
                        ? "存檔與讀檔測試成功！"
                        : "讀取成功，但資料比對失敗。");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"存檔測試發生錯誤：\n{ex.Message}");
            }
        }
    }
}
