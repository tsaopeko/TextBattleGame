using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TextBattleGame.SaveSystem;

namespace TextBattleGame.Forms
{
    public partial class SaveLoadForm : Form
    {
        private bool _isSaveMode = true;    // 目前選取的操作方式
        private readonly Action<int> _saveAction;   // 執行存檔時呼叫的操作
        private readonly Action<int> _loadAction;   // 執行讀檔時呼叫的操作
        private readonly bool _allowSaveMode;   // 是否允許切換到存檔模式
        public SaveLoadForm()
        {
            InitializeComponent();

            _allowSaveMode = true;
            SetMode(true);
            RefreshAllSlots();
        }

        /// <summary>
        /// 建立可執行存檔與讀檔的表單
        /// </summary>
        /// <param name="saveAction">存檔操作</param>
        /// <param name="loadAction">讀檔操作</param>
        public SaveLoadForm(Action<int> saveAction, Action<int> loadAction, bool isSaveMode = true)
        {
            InitializeComponent();

            _allowSaveMode = isSaveMode;
            _saveAction = isSaveMode ? saveAction : null;
            _loadAction = loadAction;

            SetMode(isSaveMode);
            RefreshAllSlots();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetMode(bool isSaveMode)
        {
            _isSaveMode = isSaveMode;

            // 更新存檔按鈕外觀
            btnSaveMode.BackColor = isSaveMode ? Color.FromArgb(124, 92, 220) : Color.FromArgb(37, 45, 60);
            btnSaveMode.ForeColor = isSaveMode ? Color.White : Color.FromArgb(190, 199, 213);
            btnSaveMode.Font = new Font("Microsoft JhengHei UI", 10F, isSaveMode ? FontStyle.Bold : FontStyle.Regular);

            // 更新讀檔按鈕外觀
            btnLoadMode.BackColor = isSaveMode ? Color.FromArgb(37, 45, 60) : Color.FromArgb(124, 92, 220);
            btnLoadMode.ForeColor = isSaveMode ? Color.FromArgb(190, 199, 213) : Color.White;
            btnLoadMode.Font = new Font("Microsoft JhengHei UI", 10F, isSaveMode ? FontStyle.Regular : FontStyle.Bold);

            string actionText = isSaveMode ? "儲存" : "讀取";

            btnSlot1Action.Text = actionText;
            btnSlot2Action.Text = actionText;
            btnSlot3Action.Text = actionText;

            btnSaveMode.Enabled = _allowSaveMode;   // 只有存檔模式才能點擊存檔操作
        }

        private void btnSaveMode_Click(object sender, EventArgs e)
        {
            SetMode(true);
        }

        private void btnLoadMode_Click(object sender, EventArgs e)
        {
            SetMode(false);
        }

        /// <summary>
        /// 更新指定存檔槽的顯示資訊
        /// </summary>
        /// <param name="slotNumber">存檔槽編號</param>
        /// <param name="playerNameLabel">角色名稱標籤</param>
        /// <param name="detailsLabel">存檔詳細資訊標籤</param>
        private void RefreshSlotInfo(int slotNumber, Label playerNameLabel, Label detailsLabel)
        {
            SaveLoadSystem saveSystem = new SaveLoadSystem();

            GameSaveData saveData = saveSystem.Load(slotNumber);    // 讀取指定存檔槽

            if (saveData == null)
            {
                playerNameLabel.Text = "尚無存檔";
                detailsLabel.Text = "等級 : -- 階段 : -- 存檔時間 : --";
                return;
            }

            playerNameLabel.Text = saveData.PlayerName; // 顯示角色名稱
            // 顯示等級, 階段與存檔時間
            detailsLabel.Text = $"等級 : {saveData.Level} " + $"階段 : {saveData.CurrentStage} " + $"存檔時間 : {saveData.SavedAt:yyyy/MM/dd HH:mm}";
        }

        /// <summary>
        /// 執行第一個存檔槽的操作
        /// </summary>
        private void btnSlot1Action_Click(object sender, EventArgs e)
        {
            if(_isSaveMode)
            {
                ExecuteSave(1);
                return;
            }

            ExecuteLoad(1);
        }

        /// <summary>
        /// 更新三個存檔槽的顯示資訊
        /// </summary>
        private void RefreshAllSlots()
        {
            RefreshSlotInfo(1, lbSlot1PlayerName, lbSlot1Details);
            RefreshSlotInfo(2, lbSlot2PlayerName, lbSlot2Details);
            RefreshSlotInfo(3, lbSlot3PlayerName, lbSlot3Details);
        }

        /// <summary>
        /// 執行第二個存檔槽的操作
        /// </summary>
        private void btnSlot2Action_Click(object sender, EventArgs e)
        {
            if (_isSaveMode)
            {
                ExecuteSave(2);
                return;
            }

            ExecuteLoad(2);
        }

        /// <summary>
        /// 執行第三個存檔槽的操作
        /// </summary>
        private void btnSlot3Action_Click(object sender, EventArgs e)
        {
            if (_isSaveMode)
            {
                ExecuteSave(3);
                return;
            }

            ExecuteLoad(3);
        }

        /// <summary>
        /// 執行指定存檔槽的存檔操作
        /// </summary>
        /// <param name="slotNumber">存檔槽編號</param>
        private void ExecuteSave(int slotNumber)
        {
            if(_saveAction == null)
            {
                MessageBox.Show("目前無法執行存檔, 請從遊戲畫面開啟", "冒險紀錄", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveLoadSystem saveSystem = new SaveLoadSystem();

            // 如果該槽位已有存檔, 先詢問是否覆蓋
            if(saveSystem.SaveExists(slotNumber))
            {
                DialogResult result = MessageBox.Show($"存檔槽{slotNumber}已有紀錄, 確定要覆蓋嗎?", "覆蓋存檔確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result != DialogResult.Yes)
                {
                    return;
                }
            }

            _saveAction.Invoke(slotNumber);

            RefreshAllSlots();
        }

        /// <summary>
        /// 執行指定存檔槽的讀檔操作
        /// </summary>
        /// <param name="slotNumber">存檔槽編號</param>
        private void ExecuteLoad(int slotNumber)
        {
            if(_loadAction == null)
            {
                MessageBox.Show("目前無法執行讀檔", "冒險紀錄", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveLoadSystem saveSystem = new SaveLoadSystem();

            if(saveSystem.SaveExists(slotNumber) == false)
            {
                MessageBox.Show("此存檔槽沒有可讀取的紀錄", "讀取存檔", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _loadAction.Invoke(slotNumber);
        }
    }
}
