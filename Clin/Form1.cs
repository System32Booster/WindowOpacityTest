using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Clin
{
    public partial class Form1 : Form
    {
        // 定数定義
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_LAYERED = 0x80000;
        private const int LWA_ALPHA = 0x2;

        // WinAPI定義
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        public Form1()
        {
            InitializeComponent();
            trackBarAlpha.Minimum = 0;
            trackBarAlpha.Maximum = 255;
            trackBarAlpha.Value = 255;
            labelAlphaValue.Text = "Alpha: 255";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void trackBarAlpha_Scroll(object sender, EventArgs e)
        {
            labelAlphaValue.Text = $"Alpha: {trackBarAlpha.Value}";
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            int exStyle = GetWindowLong(this.Handle, GWL_EXSTYLE);

            if (checkBoxEnableLayered.Checked)
            {
                exStyle |= WS_EX_LAYERED;
                SetWindowLong(this.Handle, GWL_EXSTYLE, exStyle);

                byte alpha = (byte)trackBarAlpha.Value;
                SetLayeredWindowAttributes(this.Handle, 0, alpha, LWA_ALPHA);
            }
            else
            {
                exStyle &= ~WS_EX_LAYERED;
                SetWindowLong(this.Handle, GWL_EXSTYLE, exStyle);

                // フル不透明に戻す
                this.Opacity = 1.0;
            }
        }
    }
}
