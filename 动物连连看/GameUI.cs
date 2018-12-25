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
            this.pic = new PictureBox[MAXROW, MAXCOLUMN];
            for (int i = 0; i < MAXROW; ++i)
            {
                for (int j = 0; j < MAXCOLUMN; ++j)
                {
                    this.pic[i, j] = new PictureBox();
                    this.pic[i, j].Location = new Point(picWidth * j, picWidth * i);
                    this.pic[i, j].Name = "pic" + (i * MAXCOLUMN + j).ToString();
                    this.pic[i, j].Width = picWidth;
                    this.pic[i, j].Height = picWidth;
                    this.pic[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    this.panel1.Controls.Add(this.pic[i, j]);
                    this.pic[i, j].Click += new EventHandler(this.PicClick);
                }
            }
        }
        private void GenPic()
        {
            int[] a = new int[MAXROW * MAXCOLUMN];
            int t, index;
            for (int i = 0; i < a.Length; i += 2)
            {
                a[i] = rd.Next(1, 16);
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
                    this.pic[i, j].Name = a[i * MAXCOLUMN + j].ToString();
                    this.pic[i, j].Visible = true;
                    vis[i + 1, j + 1] = 1;
                }
            }
        }
        private Boolean Erase()
        {
            this.pic[firstX - 1, firstY - 1].Visible = false;
            this.pic[secondX - 1, secondY - 1].Visible = false;
            vis[firstX, firstY] = 0;
            vis[secondX, secondY] = 0;
            cnt++;
            if (cnt * 2 == MAXROW * MAXCOLUMN)
            {
            //    button1.Enabled = false;
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

        private Boolean Line()
        {
            if (!this.pic[firstX - 1, firstY - 1].Visible || !this.pic[secondX - 1, secondY - 1].Visible) return false;
            if (this.pic[firstX - 1, firstY - 1].Name != this.pic[secondX - 1, secondY - 1].Name) return false;
            if (firstX == secondX && firstY == secondY) return false;
            for (int k = 0; k < 4; ++k)
            {
                int tx = firstX, ty = firstY;
                for (int i = 0; i < MAXCOLUMN; ++i)
                {
                    tx += dx[k]; ty += dy[k];
                    if (tx == secondX && ty == secondY) return Erase();
                    if (tx < 0 || tx > MAXROW + 1 || ty < 0 || ty > MAXCOLUMN + 1 || vis[tx, ty] == 1) break;
                    for (int k1 = 0; k1 < 4; ++k1)
                    {
                        int tx1 = tx, ty1 = ty;
                        for (int j = 0; j < MAXCOLUMN; ++j)
                        {
                            tx1 += dx[k1]; ty1 += dy[k1];
                            if (tx1 == secondX && ty1 == secondY) return Erase();
                            if (tx1 < 0 || tx1 > MAXROW + 1 || ty1 < 0 || ty1 > MAXCOLUMN + 1 || vis[tx1, ty1] == 1) break;
                            for (int k2 = 0; k2 < 4; ++k2)
                            {
                                int tx2 = tx1, ty2 = ty1;
                                for (int l = 0; l < MAXCOLUMN; ++l)
                                {
                                    tx2 += dx[k2]; ty2 += dy[k2];
                                    if (tx2 == secondX && ty2 == secondY) return Erase();
                                    if (tx2 < 0 || tx2 > MAXROW + 1 || ty2 < 0 || ty2 > MAXCOLUMN + 1 || vis[tx2, ty2] == 1) break;
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
            //     ((PictureBox)sender).Visible = false;
            for (int i = 0; i < MAXROW; ++i)
            {
                for (int j = 0; j < MAXCOLUMN; ++j)
                {
                    if (this.pic[i, j] == (PictureBox)sender)
                    {
                        if (vis[i + 1, j + 1] == 1)
                        {
                            if (firstX == 0 && firstY == 0)
                            {
                                firstX = i + 1;
                                firstY = j + 1;
                                this.pic[i, j].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                            }
                            else
                            {
                                secondX = i + 1;
                                secondY = j + 1;
                                this.pic[firstX - 1, firstY - 1].BorderStyle = System.Windows.Forms.BorderStyle.None;
                                Line();
                                firstX = firstY = secondX = secondY = 0;
                            }
                        }
                    }
                }
            }
        }
        
        private void GameStart()
        {
            GenPic();
            firstX = firstY = secondX = secondY = 0;
            cnt = 0;
        }
    }
}