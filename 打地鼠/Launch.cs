using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace 打地鼠
{
    public partial class Launch : Form
    {
        int mouseNum = 1;//每秒出现的地鼠的个数
        PictureBox []mouse;
        public Launch()
        {
            InitializeComponent();
            InitMouse();
            mouse = new PictureBox[] { mouse1, mouse2, mouse3, mouse4, mouse5, mouse6, mouse7, mouse8, mouse9 };
            for(int i=0;i<9;++i)
            {
                mouse[i].Click += new System.EventHandler(this.mouseHit);
                mouse[i].MouseDown += new System.Windows.Forms.MouseEventHandler(this.HammerDown);
                mouse[i].MouseUp += new System.Windows.Forms.MouseEventHandler(this.HammerUp);
            }
        }
        void InitMouse()
        {
            SetMouseHamorUp();
        }
        void SetMouseHamorDown()
        {
            Image fn = Properties.Resources.锤子落下;
            Bitmap bitmap = new Bitmap(fn);
            IntPtr handle = bitmap.GetHicon();
            Cursor myCursor = new Cursor(handle);
            this.Cursor = myCursor;
        }
        void SetMouseHamorUp()
        {
            Image fn = Properties.Resources.锤子;
            Bitmap bitmap = new Bitmap(fn);
            IntPtr handle = bitmap.GetHicon();
            Cursor myCursor = new Cursor(handle);
            this.Cursor = myCursor;

        }
        private void mouseHit(object sender, EventArgs e)
        {
            if((sender as PictureBox).BackgroundImage!=null)
            {
                (sender as PictureBox).BackgroundImage = Properties.Resources.被打后;
                SoundPlayer player = new SoundPlayer(Properties.Resources.Hit);
                player.Play();

                
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HammerDown(object sender, MouseEventArgs e)
        {
            SetMouseHamorDown();

        }
        private void HammerUp(object sender, MouseEventArgs e)
        {

            SetMouseHamorUp();
        }

        Boolean mouseHold = false;
        int mouseX, mouseY, FramX, FramY;

        void InitGame()
        {
        }
        private void PicNewGame_Click(object sender, EventArgs e)
        {
            PicTitle.Visible = false;//关闭标题
            menuPanel.Visible = false;//关闭菜单
            gameTime.Enabled = true;//开始进度条
            mouseGen.Enabled = true;//生成地鼠
            InitGame();
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
            if(timeRest.Width>=300)
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
            if (timeRest.Width==0)
            {
                timeRest.BackColor = Color.GreenYellow;
                gameTime.Enabled = false;
            }
        }

        private void mouseGen_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            for(int i=0;i<9;++i)
            {
                mouse[i].BackgroundImage = null;
            }
            for(int i=0;i<mouseNum;++i)
            {
                mouse[rd.Next(0, 9)].BackgroundImage = Properties.Resources.地鼠;
            }
        }

        private void PicTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseHold = true;
            FramX = this.Left;
            FramY = this.Top;
            mouseX = Cursor.Position.X;
            mouseY = Cursor.Position.Y;
            this.Cursor = Cursors.SizeAll;
        }

        private void PicTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseHold)
            {
                this.Left = FramX + Cursor.Position.X - mouseX;
                this.Top = FramY + Cursor.Position.Y - mouseY;
            }
        }

        private void PicTitle_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            mouseHold = false;
            SetMouseHamorUp();
        }
    }
}
