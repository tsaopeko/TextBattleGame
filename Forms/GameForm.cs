using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TextBattleGame.Models;
using TextBattleGame.Systems;
using TextBattleGame.SaveSystem;

namespace TextBattleGame.Forms
{
    public partial class GameForm : Form
    {
        private readonly Player _player;
        private Enemy _enemy;
        private readonly ExperienceSystem _experienceSystem;
        private BattleManager _battleManager;
        private int _currentStage = 1;  // 紀錄玩家目前所在的戰鬥階段
        private readonly EnemyGenerator _enemyGenerator;
        private readonly SkillSystem _skillSystem = new SkillSystem();
        private readonly SkillRepository _skillRepository = new SkillRepository();
        private readonly ItemRepository _itemRepository;    // 道具資料管理器
        private readonly InventorySystem _inventorySystem;  // 玩家背包管理系統
        private InventoryForm? _inventoryForm;  // 目前開啟中的背包視窗
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            int Msg,
            IntPtr wParam,
            IntPtr lParam
        );

        public GameForm(Player player) : this(player, 1, null)
        {
        }

        private GameForm(Player player, int initialStage, Dictionary<int, int>? savedInventory)
        {
            InitializeComponent();

            _player = player ?? throw new ArgumentNullException(nameof(player));

            _currentStage = initialStage;

            _itemRepository = new ItemRepository(); // 建立道具資料管理器

            _inventorySystem = new InventorySystem(_itemRepository);    // 建立背包管理系統

            EnemyDataRepository enemyDataRepository = new EnemyDataRepository();    // 建立怪物資料管理器

            List<EnemyData> enemyDatasList = enemyDataRepository.GetAll();  // 取得所有怪物的基礎資料

            _enemyGenerator = new EnemyGenerator(enemyDatasList);   // 建立怪物生成器

            // 讀取首領階段設定, 並將首領註冊到怪物生成器
            Dictionary<int, string> bossStageSettings = enemyDataRepository.GetBossStageSettings();

            foreach (KeyValuePair<int, string> setting in bossStageSettings)
            {
                // 根據設定的首領名稱, 尋找對應的怪物資料
                EnemyData? bossData = enemyDatasList.FirstOrDefault(enemy => enemy.IsBoss && enemy.Name == setting.Value);

                // 如果設定的首領不存在, 就明確指出設定錯誤
                if (bossData == null)
                {
                    throw new InvalidOperationException($"第{setting.Key}階段設定的首領「{setting.Value}」不存在, 請檢查怪物資料");
                }
                // 將首領註冊到指定階段
                _enemyGenerator.RegisterBoss(setting.Key, bossData);
            }

            _experienceSystem = new ExperienceSystem(_skillSystem);

            InitializeSkills();
            InitializeBattle();

            if (savedInventory == null)
            {
                InitializeInventory();  // 新遊戲給予初始道具
            }
            else
            {
                _inventorySystem.RestoreItems(savedInventory);  // 讀取存檔還原存檔中的道具
            }

            RefreshPlayerStatus();
            RefreshEnemyStatus();
            RefreshStageStatus();
        }
        public GameForm(GameSaveData saveData) : this(CreatePlayerFromSave(saveData), GetSaveStage(saveData), GetSaveInventory(saveData))
        {
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            lbPlayerName.Text = _player.Name;

            prgPlayerMP.ProgressColor = Color.FromArgb(167, 139, 250);
            prgPlayerMP.TrackColor = Color.FromArgb(58, 65, 79);

            prgEnemyHP.ProgressColor = Color.FromArgb(244, 108, 122);
            prgEnemyHP.TrackColor = Color.FromArgb(58, 65, 79);

            prgExperience.ProgressColor = Color.FromArgb(176, 138, 46);
            prgExperience.TrackColor = Color.FromArgb(58, 65, 79);
        }
        #region 設計標題列的拖曳、最小化、最大化、關閉功能
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            PressMouseDown(e);
        }

        private void lbGameTitle_MouseDown(object sender, MouseEventArgs e)
        {
            PressMouseDown(e);
        }

        private void PressMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, (IntPtr)0x2, IntPtr.Zero);
            }
        }
        #endregion

        #region 顯示角色資訊表單
        private void ShowCharacterInfoForm()
        {
            using (CharacterInfoForm characterInfoForm = new(_player, _experienceSystem))
            {
                characterInfoForm.ShowDialog(this);
            }

            RefreshPlayerStatus();
        }

        private void pnlPlayerCard_Click(object sender, EventArgs e)
        {
            ShowCharacterInfoForm();
        }

        private void lbPlayerName_Click(object sender, EventArgs e)
        {
            ShowCharacterInfoForm();
        }

        private void lbPlayerLevel_Click(object sender, EventArgs e)
        {
            ShowCharacterInfoForm();
        }
        private void lbPlayerAttack_Click(object sender, EventArgs e)
        {
            ShowCharacterInfoForm();
        }

        private void lbPlayerDefense_Click(object sender, EventArgs e)
        {
            ShowCharacterInfoForm();
        }
        #endregion

        /// <summary>
        /// 更新角色戰鬥數值顯示
        /// </summary>
        private void RefreshPlayerStatus()
        {
            lbPlayerName.Text = _player.Name;   // 更新角色名稱

            // 更新HP與MP顯示
            lbPlayerHP.Text = $"HP : {_player.CurrentHP} / {_player.MaxHP}";
            lbPlayerMP.Text = $"MP : {_player.CurrentMP} / {_player.MaxMP}";

            // 更新HP與MP的進度條顯示
            prgPlayerHP.Maximum = Math.Max(1, _player.MaxHP);
            prgPlayerHP.Value = Math.Clamp(_player.CurrentHP, prgPlayerHP.Minimum, prgPlayerHP.Maximum);
            prgPlayerMP.Maximum = Math.Max(1, _player.MaxMP);
            prgPlayerMP.Value = Math.Clamp(_player.CurrentMP, prgPlayerMP.Minimum, prgPlayerMP.Maximum);

            // 更新角色等級與戰鬥數值顯示
            lbPlayerLevel.Text = $"Lv.{_player.Level}";
            lbPlayerAttack.Text = $"物理攻擊 : {_player.PhysicalAttack}";
            lbPlayerDefense.Text = $"防禦力 : {_player.Defense}";

            // 取得目前等級所需的經驗值
            int requiredExp = _experienceSystem.GetRequiredExperience(_player.Level);

            // 避免最高等級或需求經驗值為零
            if (requiredExp <= 0)
            {
                lbExperience.Text = "EXP : 最高等級";
                prgExperience.Minimum = 0;
                prgExperience.Maximum = 100;
                prgExperience.Value = 100;
                return;
            }

            // 更新經驗條範圍
            prgExperience.Minimum = 0;
            prgExperience.Maximum = requiredExp;

            // 確保目前經驗值不超出進度條允許的範圍
            int currentExp = Math.Clamp(_player.Experience, 0, requiredExp);

            // 更新經驗條填滿程度
            prgExperience.Value = currentExp;

            // 更新經驗值文字
            lbExperience.Text = $"EXP : {currentExp} / {requiredExp}";
        }

        /// <summary>
        /// 收集目前遊戲狀態, 建立存檔資料
        /// </summary>
        /// <returns>目前遊戲的存檔資料</returns>
        private GameSaveData CreateSaveData()
        {
            return new GameSaveData
            {
                PlayerName = _player.Name,
                Level = _player.Level,
                Experience = _player.Experience,
                StatPoints = _player.StatPoints,

                Strength = _player.Strength,
                Vitality = _player.Vitality,
                Intelligence = _player.Intelligence,
                Dexterity = _player.Dexterity,

                CurrentStage = _currentStage,
                InventoryItems = _inventorySystem.GetAllItems()
            };
        }

        /// <summary>
        /// 根據存檔資料建立並還原玩家角色
        /// </summary>
        /// <param name="saveData">讀取到的遊戲存檔資料</param>
        /// <returns>還原完成的玩家角色</returns>
        private static Player CreatePlayerFromSave(GameSaveData saveData)
        {
            if (saveData == null)
            {
                throw new ArgumentNullException(nameof(saveData));
            }

            Player player = new Player(saveData.PlayerName);    // 先建立角色, 再還原存檔中的完整資料 

            player.RestoreSaveData(saveData.PlayerName, saveData.Level, saveData.Experience, saveData.StatPoints,
                saveData.Strength, saveData.Vitality, saveData.Intelligence, saveData.Dexterity);

            return player;
        }

        /// <summary>
        /// 按下普通攻擊
        /// </summary>
        private void btnNormalAttack_Click(object sender, EventArgs e)
        {
            BattleTurnResult result = _battleManager.PlayerAttack();

            RefreshPlayerStatus();
            RefreshEnemyStatus();

            // 將本回合戰鬥文字接續到紀錄最後面
            rtbBattleLog.AppendText(result.Message + Environment.NewLine);

            // 自動捲動到最新一筆戰鬥紀錄
            rtbBattleLog.SelectionStart = rtbBattleLog.TextLength;
            rtbBattleLog.ScrollToCaret();

            if (result.BattleEnded)
            {
                HandleBattleEnded(result);
            }
        }

        /// <summary>
        /// 初始化敵人
        /// </summary>
        private void InitializeBattle()
        {
            _enemy = _enemyGenerator.GenerateEnemyForStage(_currentStage);
            _battleManager = new BattleManager(_player, _enemy, _experienceSystem);
        }

        /// <summary>
        /// 更新戰鬥畫面中的怪物資訊
        /// </summary>
        private void RefreshEnemyStatus()
        {
            // 更新怪物名稱
            lbEnemyName.Text = _enemy.Name;
            // 更新怪物的資訊
            lbEnemyStats.Text = $"攻擊力 : {_enemy.Attack}  防禦力 : {_enemy.Defense}";
            // 更新怪物HP顯示
            lbEnemyHP.Text = $"HP : {_enemy.CurrentHP} / {_enemy.MaxHP}";
            // 更新HP進度條顯示
            prgEnemyHP.Maximum = Math.Max(1, _enemy.MaxHP);
            prgEnemyHP.Value = Math.Clamp(_enemy.CurrentHP, prgEnemyHP.Minimum, prgEnemyHP.Maximum);
        }

        /// <summary>
        /// 處理戰鬥結束後的畫面狀態
        /// </summary>
        private void HandleBattleEnded(BattleTurnResult result)
        {
            if (result.EnemyIsDead)
            {
                lbBattleStatus.Text = $"戰鬥勝利!獲得{result.ExperienceGained}點經驗";
                if (result.LevelGained > 0)
                {
                    lbBattleStatus.Text += $", 升級至Lv.{_player.Level}";
                }

                ShowUnlockedSkills(result.NewlyUnlockedSkills);
            }
            else if (result.PlayerIsDead)
            {
                // 套用死亡經驗懲罰
                int penalty = _experienceSystem.ApplyDeathPenalty(_player);

                // 死亡後恢復生命值與魔力
                _player.CurrentHP = _player.MaxHP;
                _player.CurrentMP = _player.MaxMP;

                _currentStage = Math.Max(1, _currentStage - 1);
                // 顯示死亡懲罰結果
                lbBattleStatus.Text = $"角色死亡!扣除{penalty}點經驗值, 已退回第{_currentStage}階段";

                // 更新玩家狀態與經驗值顯示
                RefreshPlayerStatus();
                RefreshStageStatus();
            }
            else if (result.PlayerFled)
            {
                // 逃跑後退回上一階段, 最低停留在第1階段
                _currentStage = Math.Max(1, _currentStage - 1);
                // 更新目前階段的畫面
                RefreshStageStatus();
                // 顯示逃跑結果
                lbBattleStatus.Text = $"成功逃跑!已退回第{_currentStage}階段";
            }

            lbBattleStatus.Visible = true;
            btnRetryBattle.Visible = true;
            btnNextStage.Visible = result.EnemyIsDead;

            // 停用所有戰鬥操作按鈕
            btnNormalAttack.Enabled = false;
            btnMagicAttack.Enabled = false;
            btnInventory.Enabled = false;
            btnFlee.Enabled = false;
        }

        /// <summary>
        /// 處理戰鬥中使用道具後的敵人反擊
        /// </summary>
        public void HandleItemUsedInBattle()
        {
            BattleTurnResult result = _battleManager.EnemyCounterAttack();  // 執行敵人反擊

            // 更新玩家與敵人狀態
            RefreshPlayerStatus();
            RefreshEnemyStatus();

            // 顯示戰鬥訊息
            rtbBattleLog.AppendText(result.Message + Environment.NewLine);
            rtbBattleLog.SelectionStart = rtbBattleLog.TextLength;
            rtbBattleLog.ScrollToCaret();

            // 如果玩家死亡, 沿用既有的戰鬥結束處理
            if (result.BattleEnded)
            {
                HandleBattleEnded(result);

                _inventoryForm?.CloseInventory();
            }
        }
        private void ResetBattle()
        {
            // 恢復玩家HP/MP至最大值
            _player.CurrentHP = _player.MaxHP;
            _player.CurrentMP = _player.MaxMP;
            
            InitializeBattle(); // 建立新的怪物及戰鬥管理器

            ResetBattleUI();    // 重設戰鬥介面

            // 更新玩家與敵人的畫面資訊
            RefreshEnemyStatus();
            RefreshPlayerStatus();

            RefreshStageStatus();   // 更新目前階段資訊
        }

        private void btnRetryBattle_Click(object sender, EventArgs e)
        {
            ResetBattle();
        }

        private void RefreshStageStatus()
        {
            lbCurrentStage.Text = $"第{_currentStage}階段";
        }

        private void btnNextStage_Click(object sender, EventArgs e)
        {
            if (_enemy.IsDead == false)
            {
                return;
            }

            _currentStage++;
            RefreshStageStatus();

            ResetBattle();
        }

        /// <summary>
        /// 處理逃跑按鈕的 Click 事件，執行離場或中斷當前交互流程的相關邏輯。
        /// </summary>
        private void btnFlee_Click(object sender, EventArgs e)
        {
            BattleTurnResult result = _battleManager.Flee();    // 執行逃跑

            // 只有成功逃跑才退還本場戰鬥使用的道具
            if (result.PlayerFled)
            {
                _battleManager.RefundUsedItems(_inventorySystem);
            }

            rtbBattleLog.AppendText(result.Message + Environment.NewLine);
            rtbBattleLog.SelectionStart = rtbBattleLog.TextLength;
            rtbBattleLog.ScrollToCaret();

            // 處理戰鬥結束
            if (result.BattleEnded)
            {
                HandleBattleEnded(result);
            }
        }

        private void btnMagicAttack_Click(object sender, EventArgs e)
        {
            // 戰鬥已結束時, 不允許使用技能
            if (_battleManager is null)
            {
                return;
            }

            // 開啟技能選擇視窗
            using SkillSelectForm form = new SkillSelectForm(_player, _skillSystem);

            // 玩家關閉視窗或沒有選擇技能時, 不執行攻擊
            if (form.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            Skill? selectedSkill = form.SelectedSkill;

            if (selectedSkill is null)
            {
                return;
            }

            BattleTurnResult result = _battleManager.UseSkill(selectedSkill);

            rtbBattleLog.AppendText(result.Message + Environment.NewLine);

            rtbBattleLog.SelectionStart = rtbBattleLog.TextLength;
            rtbBattleLog.ScrollToCaret();

            RefreshPlayerStatus();
            RefreshEnemyStatus();

            if (result.BattleEnded)
            {
                HandleBattleEnded(result);
            }
        }

        /// <summary>
        /// 從技能資料庫載入技能, 並登錄至技能系統
        /// </summary>
        private void InitializeSkills()
        {
            List<Skill> skills = _skillRepository.GetAll();

            foreach (Skill skill in skills)
            {
                _skillSystem.AddSkill(skill);
            }
        }

        /// <summary>
        /// 顯示本次升級解鎖的技能
        /// </summary>
        /// <param name="skills">新解鎖的技能清單</param>
        private void ShowUnlockedSkills(List<Skill> skills)
        {
            if (skills == null || skills.Count == 0)
            {
                return;
            }

            string skillNames = string.Join(Environment.NewLine, skills.Select(skill => $"˙{skill.Name}"));

            MessageBox.Show(this, $"恭喜升級!解鎖以下技能:{Environment.NewLine}{Environment.NewLine}{skillNames}", "技能解鎖", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 處理開啟背包的事件
        /// </summary>
        private void btnInventory_Click(object sender, EventArgs e)
        {
            using (InventoryForm inventoryForm = new InventoryForm(_player, _itemRepository, _inventorySystem,
                _battleManager != null && _battleManager.IsBattleEnded == false, () => _battleManager == null || _battleManager.IsBattleEnded))
            {
                _inventoryForm = inventoryForm;

                inventoryForm.ItemUsedInBattle += InventoryForm_ItemUsedInBattle;   // 訂閱戰鬥中使用道具的事件
                inventoryForm.ShowDialog(this);

                _inventoryForm = null;  // 背包關閉後, 清除目前的視窗參考
            }

            RefreshPlayerStatus();  // 背包關閉後更新玩家狀態
        }

        /// <summary>
        /// 處理戰鬥中成功使用道具的事件
        /// </summary>
        private void InventoryForm_ItemUsedInBattle(object? sender, ItemUsedEventArgs e)
        {
            _battleManager.RecordItemUsed(e.ItemId);    // 紀錄本場戰鬥使用的道具

            HandleItemUsedInBattle();   // 處理敵人反擊與戰鬥狀態更新
        }

        /// <summary>
        /// 初始化玩家背包與初始道具
        /// </summary>
        private void InitializeInventory()
        {
            // 初始化玩家起始道具
            _inventorySystem.AddItem(ItemIds.HealthPotion, 3);
            _inventorySystem.AddItem(ItemIds.ManaPotion, 3);
        }

        /// <summary>
        /// 設定遊戲起始階段
        /// </summary>
        /// <param name="stage">起始階段</param>
        private void SetCurrentStage(int stage)
        {
            if (stage < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(stage), "階段必須大於或等於1");
            }

            _currentStage = stage;
        }

        /// <summary>
        /// 取得並驗證存檔中的關卡
        /// </summary>
        private static int GetSaveStage(GameSaveData saveData)
        {
            if (saveData == null)
            {
                throw new ArgumentNullException(nameof(saveData));
            }

            if (saveData.CurrentStage < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(saveData.CurrentStage), "存檔中的關卡必須大於或等於1");
            }

            return saveData.CurrentStage;
        }

        /// <summary>
        /// 取得並驗證存檔中的背包資料
        /// </summary>
        private static Dictionary<int, int> GetSaveInventory(GameSaveData saveData)
        {
            if (saveData == null)
            {
                throw new ArgumentNullException(nameof(saveData));
            }

            if (saveData.InventoryItems == null)
            {
                throw new ArgumentException("存檔中的背包資料不存在", nameof(saveData));
            }

            return saveData.InventoryItems;
        }

        /// <summary>
        /// 將目前遊戲進度儲存至指定存檔槽
        /// </summary>
        /// <param name="slotNumber">存檔槽編號</param>
        private void SaveGameToSlot(int slotNumber)
        {
            try
            {
                SaveLoadSystem saveSystem = new SaveLoadSystem();

                GameSaveData saveData = CreateSaveData();   // 取得目前遊戲資料

                saveSystem.Save(slotNumber, saveData);  // 寫入指定存檔槽

                MessageBox.Show("遊戲進度已成功儲存", "存檔完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"存檔失敗:\n{ex.Message}", "存檔錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 開啟冒險紀錄表單
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveLoadForm form = new SaveLoadForm(SaveGameToSlot, LoadGameFromSlot))
            {
                form.ShowDialog(this);
            }
        }

        /// <summary>
        /// 讀取指定存檔槽
        /// </summary>
        /// <param name="slotNumber">存檔槽編號</param>
        private void LoadGameFromSlot(int slotNumber)
        {
            SaveLoadSystem saveSystem = new SaveLoadSystem();

            GameSaveData saveData = saveSystem.Load(slotNumber);    // 讀取指定存檔槽的資料

            if(saveData == null)
            {
                MessageBox.Show("此存檔槽沒有可讀取的紀錄", "讀取存檔", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 檢查存檔階段是否合理
                if (saveData.CurrentStage < 1)
                {
                    MessageBox.Show("存檔階段資料不正確, 無法讀取", "讀取存檔失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _inventorySystem.RestoreItems(saveData.InventoryItems); // 還原存檔中的背包物品

                // 還原目前角色資料, 並恢復滿HP 滿MP
                _player.RestoreSaveData(saveData.PlayerName, saveData.Level, saveData.Experience, saveData.StatPoints,
                    saveData.Strength, saveData.Vitality, saveData.Intelligence, saveData.Dexterity);

                _currentStage = saveData.CurrentStage;  // 還原目前階段

                InitializeBattle(); // 重新初始化目前階段的戰鬥

                ResetBattleUI();    // 重設戰鬥介面

                // 更新角色與敵人畫面
                RefreshPlayerStatus();
                RefreshEnemyStatus();
                RefreshStageStatus();

                MessageBox.Show($"角色「{_player.Name}」的資料已還原", "讀取存檔", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"存檔資料不正確, 無法讀取\n{ex.Message}", "讀取存檔失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show($"存檔內容損壞, 無法讀取\n{ex.Message}", "讀取存檔失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"無法讀取存檔檔案\n{ex.Message}", "讀取存檔失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"沒有權限讀取存檔檔案\n{ex.Message}", "讀取存檔失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 重設戰鬥介面
        /// </summary>
        private void ResetBattleUI()
        {
            rtbBattleLog.Clear();   // 清除上一場戰鬥紀錄

            // 隱藏戰鬥結束相關訊息
            lbBattleStatus.Visible = false;
            btnRetryBattle.Visible = false;
            btnNextStage.Visible = false;

            // 恢復戰鬥操作按鈕
            btnNormalAttack.Enabled = true;
            btnMagicAttack.Enabled = true;
            btnInventory.Enabled = true;
            btnFlee.Enabled = true;
        }
    }
}
