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
        const int defaultPassScore = 500;//默认初始分数
        double mouseNum = 1;//平均每秒出现的地鼠的个数
        public int totalScore = 0;//总分
        public int thisScore = 0;//当前关卡分数
        public int passScore = defaultPassScore;//需要过关的分数
        public int lastpassScore = defaultPassScore;//上一关通关的分数
        public int level = 1;//当前关卡等级
        public int EXISTTIME = 1000;//地鼠存在的时间
        public int KILLEDEXISTTIME = 500;//地鼠被打后存在的时间
        public int[] life = new int[9];//地鼠还剩余的时间
        PictureBox[] mouse;
        Launch launch;
        public GameUI(Launch launch)
        {
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            this.launch = launch;
            InitializeComponent();
            mouse = new PictureBox[] { mouse1, mouse2, mouse3, mouse4, mouse5, mouse6, mouse7, mouse8, mouse9 };
            for (int i = 0; i < 9; ++i)
            {
                mouse[i].Click += new System.EventHandler(this.mouseHit);
                mouse[i].MouseDown += launch.HammerDown;
                mouse[i].MouseUp += launch.HammerUp;
            }
            this.MouseDown += launch.HammerDown;
            this.MouseUp += launch.HammerUp;
            gameTime.Enabled = true;
            mouseGen.Enabled = true;
            Start();
            Pause();
        }
        public void Start()//开始游戏
        {
            for (int i = 0; i < 9; ++i)
            {
                life[i] = 0;
                mouse[i].Tag = 0;
            }
            totalScore = 0;
            thisScore = 0;
            passScore = defaultPassScore;
            lastpassScore = defaultPassScore;
            level = 1;
            LbTotalScore.Text = "0";
            LbThisScore.Text = "0";
            LbPassScore.Text = defaultPassScore.ToString();
            LbLevel.Text = "1";
            timeRest.Width = 380;
            Continue();
        }
        public void Continue()//继续游戏
        {
            for (int i = 0; i < 9; ++i)
            {
                mouse[i].Visible = true;
            }
            gameTime.Start();
            mouseGen.Start();
        }
        public void Pause()//暂停游戏
        {
            for(int i=0;i<9;++i)
            {
                mouse[i].Visible = false;
            }
            gameTime.Stop();
            mouseGen.Stop();
        }
        void StartNextLevel()
        {
            Pause();
            if(totalScore>=passScore)
            {
                NextLevelUI nextLevel = new NextLevelUI(this);
                this.Controls.Add(nextLevel);
                nextLevel.BringToFront();
                nextLevel.Focus();
            }
            else
            {
                MessageBox.Show("game over");
                Pause();
            }
        }
        public void NextLevel()
        {
            Continue();
            for(int i=0;i<9;++i)
            {
                mouse[i].BackgroundImage = null;
            }
            timeRest.Width = 380;
            level++;
            LbLevel.Text = level.ToString();
            thisScore = 0;
            LbThisScore.Text = "0";
            int tmp = lastpassScore + passScore;
            lastpassScore = passScore;
            passScore = tmp;
            LbPassScore.Text = passScore.ToString();
            gameTime.Enabled = true;
            mouseGen.Enabled = true;
        }
        private void mouseHit(object sender, EventArgs e)
        {
            PictureBox mouse = sender as PictureBox;
            if (mouse.BackgroundImage != null&& Convert.ToInt32(mouse.Tag)!=0)
            {
                mouse.BackgroundImage = Properties.Resources.被打后;
                mouse.Tag = 0;
                totalScore += 100;
                thisScore += 100;
                LbTotalScore.Text = totalScore.ToString();
                LbThisScore.Text=thisScore.ToString();
                AnimationLabel al = new AnimationLabel();
                al.Text = "+100";
                al.Parent = (sender as PictureBox);
                SoundPlayer player = new SoundPlayer(Properties.Resources.Hit);
                player.Play();
            }
        }

        Random rd = new Random();
        private void mouseGen_Tick(object sender, EventArgs e)//生成地鼠
        {
            for (int i=0;i<9;++i)
            {
                if (life[i] == 0)
                {
                    mouse[i].BackgroundImage = null;
                    mouse[i].Tag = 0;
                }
                else
                {
                    life[i] -= mouseGen.Interval;
                }
            }
            if(rd.Next(0,100)<(mouseNum*10))
            {
                int gen = rd.Next(0, 9);
                do
                {
                    gen = rd.Next(0, 9);
                } while (mouse[gen].BackgroundImage != null);
                mouse[gen].BackgroundImage = Properties.Resources.地鼠;
                mouse[gen].Tag = 1;
                life[gen] = EXISTTIME;

            }
        }
        private void gameTime_Tick(object sender, EventArgs e)
        {
            if (timeRest.Width >= 220)
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
                mouseGen.Enabled = false;
                StartNextLevel();
            }
        }

        private void GameUI_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.SendToBack();
                Pause();
            }
        }
    }
}
