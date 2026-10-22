using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using TextBattleGame.Models;
using TextBattleGame.SaveSystem;

namespace TextBattleGame.Forms
{
    public partial class StartForm : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            int Msg,
            IntPtr wParam,
            IntPtr lParam
        );
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCharacterName.Text))
            {
                MessageBox.Show("請輸入角色名稱", "建立角色", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCharacterName.Focus();
                return;
            }

            Player player = new Player(txtCharacterName.Text);
            using (GameForm gameForm = new GameForm(player))
            {
                this.Hide();
                gameForm.ShowDialog();
                this.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PressMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, (IntPtr)0x2, IntPtr.Zero);
            }
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            PressMouseDown(e);
        }

        private void lbHeaderTitle_MouseDown(object sender, MouseEventArgs e)
        {
            PressMouseDown(e);
        }

        /// <summary>
        /// 從指定存檔槽讀取遊戲
        /// </summary>
        /// <param name="slotNumber">存檔槽編號</param>
        private void LoadGameFromSlot(int slotNumber)
        {
            SaveLoadSystem saveSystem = new SaveLoadSystem();

            try
            {
                // 讀取指定存檔槽
                GameSaveData saveData = saveSystem.Load(slotNumber);

                if (saveData == null)
                {
                    MessageBox.Show("這個存檔沒有存檔資料", "讀取存檔", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 使用存檔資料建立遊戲
                using (GameForm gameForm = new GameForm(saveData))
                {
                    this.Hide();
                    gameForm.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取存檔失敗:\n{ex.Message}", "讀取存檔", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            using (SaveLoadForm form = new SaveLoadForm(null, LoadGameFromSlot, false))
            {
                form.ShowDialog(this);
            }
        }
    }
}
