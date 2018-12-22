using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace 打地鼠
{
    public partial class GameUI : UserControl
    {
        int mouseNum = 1;//每秒出现的地鼠的个数
        PictureBox[] mouse;
        Launch launch;
        public GameUI(Launch launch)
        {
            this.launch = launch;
            InitializeComponent();
            mouse = new PictureBox[] { mouse1, mouse2, mouse3, mouse4, mouse5, mouse6, mouse7, mouse8, mouse9 };
            for (int i = 0; i < 9; ++i)
            {
                mouse[i].Click += new System.EventHandler(this.mouseHit);
                mouse[i].MouseDown += launch.HammerDown;
                mouse[i].MouseUp += launch.HammerUp;
            }
            gameTime.Enabled = true;
            mouseGen.Enabled = true;
        }
        private void mouseHit(object sender, EventArgs e)
        {
            if ((sender as PictureBox).BackgroundImage != null)
            {
                (sender as PictureBox).BackgroundImage = Properties.Resources.被打后;
                AnimationLabel al = new AnimationLabel();
                al.Text = "+100";
                al.Parent = (sender as PictureBox);
                SoundPlayer player = new SoundPlayer(Properties.Resources.Hit);
                player.Play();
            }
        }
        private void mouseGen_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            for (int i = 0; i < 9; ++i)
            {
                mouse[i].BackgroundImage = null;
            }
            for (int i = 0; i < mouseNum; ++i)
            {
                mouse[rd.Next(0, 9)].BackgroundImage = Properties.Resources.地鼠;
            }
        }
        private void gameTime_Tick(object sender, EventArgs e)
        {
            if (timeRest.Width >= 300)
            {
                timeRest.Width -= 2;
            }
            else
            {
                timeRest.Width -= 1;
            }
            if (timeRest.Width == 100)
            {
                timeRest.BackColor = Color.Red;
            }
            if (timeRest.Width == 0)
            {
                timeRest.BackColor = Color.GreenYellow;
                gameTime.Enabled = false;
            }
        }
    }
}
