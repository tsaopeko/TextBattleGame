using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TextBattleGame.Controls
{
    public class GameProgressBar : Control
    {
        private int _minimum = 0;
        private int _maximum = 100;
        private int _value = 100;
        /// <summary>
        /// 取得或設定進度條的最小值
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Minimum
        {
            get => _minimum;
            set
            {
                _minimum = value;
                if (_maximum < _minimum)
                {
                    _maximum = _minimum;
                }
                Value = _value; // 確保 Value 在新的範圍內
                Invalidate(); // 重新繪製控制項
            }
        }
        /// <summary>
        /// 取得或設定進度條的最大值
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Maximum
        {
            get => _maximum;
            set
            {
                _maximum = Math.Max(_minimum, value);
                Value = _value; // 確保 Value 在新的範圍內
                Invalidate(); // 重新繪製控制項
            }
        }
        /// <summary>
        /// 取得或設定進度條的當前值
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Value
        {
            get => _value;
            set
            {
                _value = Math.Clamp(value, _minimum, _maximum);
                Invalidate(); // 重新繪製控制項
            }
        }
        /// <summary>
        /// 儲存進度填滿區域的顏色。
        /// </summary>
        private Color _progressColor = Color.FromArgb(84, 214, 160);
        /// <summary>
        /// 取得或設定進度條的顏色
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ProgressColor 
        { 
            get => _progressColor;
            set
            {
                // 儲存新進度的顏色
                _progressColor = value;
                // 重新繪製控制項
                Invalidate();
            }
        }
        /// <summary>
        /// 儲存進度條背景的顏色。
        /// </summary>
        private Color _trackColor = Color.FromArgb(58, 65, 79);
        /// <summary>
        /// 取得或設定進度條的背景顏色
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color TrackColor 
        {
            get => _trackColor;
            set
            {
                // 儲存新的背景顏色
                _trackColor = value;
                Invalidate();
            }
        } 
        /// <summary>
        /// 初始化 GameProgressBar 控制項
        /// </summary>
        public GameProgressBar()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);
            Size = new Size(300, 14);
            //BackColor = Color.Transparent;
        }
        /// <summary>
        /// 繪製進度條背景與目前進度。
        /// </summary>
        /// <param name="e">繪圖事件參數。</param>
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    // 繪製進度條背景
        //    e.Graphics.Clear(Parent?.BackColor ?? BackColor);

        //    using SolidBrush trackBrush = new SolidBrush(TrackColor);
        //    e.Graphics.FillRectangle(trackBrush, 0, 0, ClientSize.Width, ClientSize.Height);

        //    // 計算目前進度所佔的寬度
        //    double ratio = Maximum == Minimum ? 0 : (double)(Value - Minimum) / (Maximum - Minimum);

        //    int progressWidth = (int)(ClientSize.Width * ratio);

        //    // 繪製進度填滿區域
        //    if (progressWidth > 0)
        //    {
        //        using SolidBrush progressBrush = new SolidBrush(ProgressColor);
        //        e.Graphics.FillRectangle(progressBrush, 0, 0, progressWidth, ClientSize.Height);
        //    }
        //}

        /// <summary>
        /// 繪製具有圓角效果的進度條背景與目前進度。
        /// </summary>
        /// <param name="e">繪圖事件參數。</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 啟用高品質繪圖, 讓圓角邊緣更平滑
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // 清除控制像背景, 避免重繪時留下陰影
            e.Graphics.Clear(Parent?.BackColor ?? BackColor);

            // 取得進度條的繪製範圍
            Rectangle bounds = new Rectangle(0, 0, ClientSize.Width - 1, ClientSize.Height - 1);

            // 高度的一半作為圓角半徑
            int radius = bounds.Height / 2;

            // 繪製圓角背景軌道
            using GraphicsPath trackPath = CreateRoundedPath(bounds, radius);
            using SolidBrush trackBrush = new SolidBrush(TrackColor);
            e.Graphics.FillPath(trackBrush, trackPath);

            // 計算目前進度比例, 避免除以0
            double ratio = Maximum == Minimum ? 0 : (double)(Value - Minimum) / (Maximum - Minimum);

            // 計算進度填滿寬度
            int progressWidth = (int)(bounds.Width * ratio);

            // 有進度時才繪製填滿區域
            if (progressWidth > 0)
            {
                Rectangle progressBounds = new Rectangle(bounds.X, bounds.Y, progressWidth, bounds.Height);

                // 進度區域也使用圓角
                using GraphicsPath progressPath = CreateRoundedPath(progressBounds, radius);
                using SolidBrush progressBrush = new SolidBrush(ProgressColor);

                e.Graphics.FillPath(progressBrush, progressPath);
            }
        }
        /// <summary>
        /// 建立指定範圍與圓角半徑的圓角矩形路徑。
        /// </summary>
        /// <param name="bounds">圖形的矩形範圍。</param>
        /// <param name="radius">圓角半徑。</param>
        /// <returns>可供繪圖使用的圓角路徑。</returns>
        private GraphicsPath CreateRoundedPath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            // 確保圓角直徑不會超過矩形高度或寬度
            int diameter = Math.Min(radius * 2, Math.Min(bounds.Width, bounds.Height));

            // 範圍無效時回傳空路徑
            if(diameter <= 0)
                return path;

            // 依序建立四個圓角
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();

            return path;
        }
    }
}
