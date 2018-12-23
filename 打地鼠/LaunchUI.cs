using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打地鼠
{
    public partial class LaunchUI : UserControl
    {
        Launch launch;
        GameUI gameUI;
        public LaunchUI(Launch launch)
        {
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            InitializeComponent();
            this.launch = launch;
            this.MouseDown += launch.HammerDown;
            this.MouseUp += launch.HammerUp;
            gameUI = new GameUI(launch);
        //    this.Controls.Add(gameUI);
      //      this.BringToFront();
         //   gameUI.SendToBack();
            //    this.Focus();
        }
        private void PicNewGame_Click(object sender, EventArgs e)
        {
            this.Controls.Add(gameUI);
            gameUI.BringToFront();
            gameUI.Focus();
            gameUI.Start();
        }
        private void PicContinueGame_Click(object sender, EventArgs e)
        {
            gameUI.BringToFront();
            gameUI.Continue();
        }
        private void PicSetting_Click(object sender, EventArgs e)
        {
            SettingUI settingUI = new SettingUI(launch);
            launch.Controls.Add(settingUI);
            settingUI.BringToFront();
        }
        private void PicIntroduce_Click(object sender, EventArgs e)
        {

        }
        private void PicQuit_Click(object sender, EventArgs e)
        {
            launch.Close();
        }
        Boolean mouseHold = false;
        int mouseX, mouseY, FramX, FramY;
        private void PicTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseHold = true;
            FramX = launch.Left;
            FramY = launch.Top;
            mouseX = Cursor.Position.X;
            mouseY = Cursor.Position.Y;
            this.Cursor = Cursors.SizeAll;
        }
        private void PicTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseHold)
            {
                launch.Left = FramX + Cursor.Position.X - mouseX;
                launch.Top = FramY + Cursor.Position.Y - mouseY;
            }
        }
        private void PicTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseHold = false;
            this.Cursor = HammerCursor.HammerUp();
        }
    }
}
