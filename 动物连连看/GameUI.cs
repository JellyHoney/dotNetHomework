using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 动物连连看
{
    public partial class GameUI : UserControl
    {
        Launch launch;
        PictureBox[,] pic;
        int picWidth = 48;
        int[] dx = new int[4] { 1, -1, 0, 0 };
        int[] dy = new int[4] { 0, 0, 1, -1 };
        Random rd = new Random();
        const int MAXROW = 8;
        const int MAXCOLUMN = 13;
        int[,] vis = new int[MAXROW + 2, MAXCOLUMN + 2];
        int firstX, firstY, secondX, secondY;
        int cnt;
        public GameUI(Launch launch)
        {
            this.launch = launch;
            InitializeComponent();
            InitPic();
            //    GenPic();
            GameStart();

        }
        private void InitPic()
        {
            for (int i = 0; i < MAXROW + 2; ++i)
            {
                for (int j = 0; j < MAXCOLUMN + 2; ++j)
                {
                    vis[i, j] = -1;
                }
            }
            this.pic = new PictureBox[MAXROW, MAXCOLUMN];
            for (int i = 0; i < MAXROW; ++i)
            {
                for (int j = 0; j < MAXCOLUMN; ++j)
                {
                    this.pic[i, j] = new PictureBox();
                    this.pic[i, j].Location = new Point(picWidth * j, picWidth * i);
                    this.pic[i, j].Width = picWidth;
                    this.pic[i, j].Height = picWidth;
                    this.pic[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    this.pic[i, j].Tag = new KeyValuePair<int, int>(i, j);
                    this.pic[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pic[i, j].Click += new EventHandler(this.PicClick);
                    this.panel1.Controls.Add(this.pic[i, j]);
                }
            }
        }
        private void GenPic()
        {
            int[] a = new int[MAXROW * MAXCOLUMN];
            int t, index;
            for (int i = 0; i < a.Length; i += 2)
            {
                a[i] = rd.Next(0, 20);
                a[i + 1] = a[i];
            }
            for (int i = 1; i < a.Length; ++i)
            {
                index = rd.Next(0, i);
                t = a[i]; a[i] = a[index]; a[index] = t;
            }
            for (int i = 0; i < MAXROW; ++i)
            {
                for (int j = 0; j < MAXCOLUMN; j++)
                {
                    this.pic[i, j].BackgroundImage = Animal.GetAnimal(a[i * MAXCOLUMN + j]);
                    this.pic[i, j].Visible = true;
                    vis[i + 1, j + 1] = a[i * MAXCOLUMN + j];
                }
            }
        }
        private Boolean Erase()
        {
            this.pic[firstX - 1, firstY - 1].Visible = false;
            this.pic[secondX - 1, secondY - 1].Visible = false;
            vis[firstX, firstY] = -1;
            vis[secondX, secondY] = -1;
            cnt++;
            if (cnt * 2 == MAXROW * MAXCOLUMN)
            {
                MessageBox.Show("您赢了");
            }
            return true;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            PauseUI pauseUI = new PauseUI(launch);
            launch.Controls.Add(pauseUI);
            pauseUI.BringToFront();
        }

        private void BoomButton_Click(object sender, EventArgs e)
        {
            for (firstX = 1; firstX <= MAXROW; ++firstX)
            {
                for (firstY = 1; firstY <= MAXCOLUMN; ++firstY)
                {
                    for (secondX = 1; secondX <= MAXROW; ++secondX)
                    {
                        for (secondY = 1; secondY <= MAXCOLUMN; ++secondY)
                        {
                            if (pic[firstX - 1, firstY - 1].Visible == false) continue;
                            if (pic[secondX - 1, secondY - 1].Visible == false) continue;
                            if (Line())
                            {
                                firstX = firstY = secondX = secondY = 0;
                                return;
                            }
                        }
                    }
                }
            }
        }

        void Fresh()
        {
            this.panel1.SuspendLayout();
            int t, index;
            for (int i = 0; i < MAXROW * MAXCOLUMN; ++i)
            {
                index = rd.Next(0, i);
                t = vis[i / MAXCOLUMN + 1, i % MAXCOLUMN + 1];
                vis[i / MAXCOLUMN + 1, i % MAXCOLUMN + 1] = vis[index / MAXCOLUMN + 1, index % MAXCOLUMN + 1];
                vis[index / MAXCOLUMN + 1, index % MAXCOLUMN + 1] = t;
            }
            for (int i = 0; i < MAXROW * MAXCOLUMN; ++i)
            {
                pic[i / MAXCOLUMN, i % MAXCOLUMN].BackgroundImage = Animal.GetAnimal(vis[i / MAXCOLUMN + 1, i % MAXCOLUMN + 1]);
                if (pic[i / MAXCOLUMN, i % MAXCOLUMN].BackgroundImage==null)
                {
                    pic[i / MAXCOLUMN, i % MAXCOLUMN].Visible = false;
                }
                else
                {
                    pic[i / MAXCOLUMN, i % MAXCOLUMN].Visible = true;
                }
            }
            this.panel1.ResumeLayout(false);
        }
        private void FreshButton_Click(object sender, EventArgs e)
        {
            Fresh();
        }

        private Boolean Line()
        {
            if (vis[firstX, firstY] != vis[secondX, secondY]) return false;
            if (firstX == secondX && firstY == secondY) return false;
            for (int k = 0; k < 4; ++k)
            {
                int tx = firstX, ty = firstY;
                for (int i = 0; i < MAXCOLUMN; ++i)
                {
                    tx += dx[k]; ty += dy[k];
                    if (tx == secondX && ty == secondY) return Erase();
                    if (tx < 0 || tx > MAXROW + 1 || ty < 0 || ty > MAXCOLUMN + 1 || vis[tx, ty] >= 0) break;
                    for (int k1 = 0; k1 < 4; ++k1)
                    {
                        int tx1 = tx, ty1 = ty;
                        for (int j = 0; j < MAXCOLUMN; ++j)
                        {
                            tx1 += dx[k1]; ty1 += dy[k1];
                            if (tx1 == secondX && ty1 == secondY) return Erase();
                            if (tx1 < 0 || tx1 > MAXROW + 1 || ty1 < 0 || ty1 > MAXCOLUMN + 1 || vis[tx1, ty1] >= 0) break;
                            for (int k2 = 0; k2 < 4; ++k2)
                            {
                                int tx2 = tx1, ty2 = ty1;
                                for (int l = 0; l < MAXCOLUMN; ++l)
                                {
                                    tx2 += dx[k2]; ty2 += dy[k2];
                                    if (tx2 == secondX && ty2 == secondY) return Erase();
                                    if (tx2 < 0 || tx2 > MAXROW + 1 || ty2 < 0 || ty2 > MAXCOLUMN + 1 || vis[tx2, ty2] >= 0) break;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        private void PicClick(object sender, EventArgs e)
        {
            KeyValuePair<int, int> keyValuePair = (KeyValuePair<int, int>)(sender as PictureBox).Tag;
            int i = keyValuePair.Key;
            int j = keyValuePair.Value;
            if (firstX == 0 && firstY == 0)
            {
                firstX = i + 1;
                firstY = j + 1;
                this.pic[i, j].Image = Properties.Resources.frame;
            }
            else
            {
                secondX = i + 1;
                secondY = j + 1;
                this.pic[firstX - 1, firstY - 1].Image = null;
                if(Line())
                {
                    firstX = firstY = secondX = secondY = 0;
                }
                else
                {
                    firstX = secondX;
                    firstY = secondY;
                    this.pic[i, j].Image = Properties.Resources.frame;
                }
            }
        }
        
        public void GameStart()
        {
            GenPic();
            firstX = firstY = secondX = secondY = 0;
            cnt = 0;
        }
    }
}