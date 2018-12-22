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
        public LaunchUI(Launch launch)
        {
            InitializeComponent();
            this.launch = launch;
            this.MouseDown += launch.HammerDown;
            this.MouseUp += launch.HammerUp;
        }
        private void PicNewGame_Click(object sender, EventArgs e)
        {
            GameUI gameUI = new GameUI(launch);
            launch.Controls.Add(gameUI);
            launch.Controls.Remove(this);
        }
        private void PicContinueGame_Click(object sender, EventArgs e)
        {

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
