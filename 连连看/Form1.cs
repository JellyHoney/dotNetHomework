using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 连连看
{
    public partial class Form1 : Form
    {
        int cnt;
        Image[] images = new Image[16];
        Random rd=new Random();
        int [,]vis = new int[MAXSIZE + 2,MAXSIZE + 2];
        int[] dx = new int[4] { 1, -1, 0, 0 };
        int[] dy = new int[4] { 0, 0, 1, -1 };
        public Form1()
        {
            MyInitializeComponent();
            InitializeComponent();
            images[0] = Properties.Resources._1;
            images[1] = Properties.Resources._2;
            images[2] = Properties.Resources._3;
            images[3] = Properties.Resources._4;
            images[4] = Properties.Resources._5;
            images[5] = Properties.Resources._6;
            images[6] = Properties.Resources._7;
            images[7] = Properties.Resources._8;
            images[8] = Properties.Resources._9;
            images[9] = Properties.Resources._10;
            images[10] = Properties.Resources._11;
            images[11] = Properties.Resources._12;
            images[12] = Properties.Resources._13;
            images[13] = Properties.Resources._14;
            images[14] = Properties.Resources._15;
            images[15] = Properties.Resources._16;
        }
        private Boolean Erase()
        {
            this.pic[firstX-1, firstY-1].Visible = false;
            this.pic[secondX-1, secondY-1].Visible = false;
            vis[firstX, firstY] = 0;
            vis[secondX, secondY] = 0;
            cnt++;
            if (cnt * 2 == MAXSIZE * MAXSIZE)
            {
                button1.Enabled = false;
                MessageBox.Show("您赢了");
            }
            return true;
        }
        private Boolean Line()
        {
            //     MessageBox.Show(firstX.ToString() + " "+firstY.ToString() + " " + secondX.ToString() + " " + secondY.ToString());
            if (!this.pic[firstX - 1, firstY - 1].Visible || !this.pic[secondX - 1, secondY - 1].Visible) return false;
            if (this.pic[firstX - 1, firstY - 1].Image != this.pic[secondX - 1, secondY - 1].Image) return false;
            if (firstX == secondX && firstY == secondY) return false;
            for(int k=0;k<4;++k)
            {
                int tx = firstX, ty = firstY;
                for (int i = 0; i < MAXSIZE; ++i)
                {
                    tx += dx[k];ty += dy[k];
                    if (tx == secondX && ty == secondY) return Erase();
                    if (tx < 0 || tx > MAXSIZE + 1 || ty < 0 || ty > MAXSIZE + 1 || vis[tx, ty] == 1) break;
                    for(int k1=0;k1<4;++k1)
                    {
                        int tx1 = tx, ty1 = ty;
                        for(int j=0;j<MAXSIZE;++j)
                        {
                            tx1 += dx[k1];ty1 += dy[k1];
                            if (tx1 == secondX && ty1 == secondY) return Erase();
                            if (tx1 < 0 || tx1 > MAXSIZE + 1 || ty1 < 0 || ty1 > MAXSIZE + 1 || vis[tx1, ty1] == 1) break;
                            for (int k2 = 0; k2 < 4; ++k2)
                            {
                                int tx2 = tx1, ty2 = ty1;
                                for (int l = 0; l < MAXSIZE; ++l)
                                {
                                    tx2 += dx[k2]; ty2 += dy[k2];
                                    if (tx2 == secondX && ty2 == secondY) return Erase();
                                    if (tx2 < 0 || tx2 > MAXSIZE + 1 || ty2 < 0 || ty2 > MAXSIZE + 1 || vis[tx2, ty2] == 1) break;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        int firstX, firstY, secondX, secondY;

        private void button1_Click(object sender, EventArgs e)
        {
            for(firstX=1;firstX<=MAXSIZE;++firstX)
            {
                for(firstY=1;firstY<=MAXSIZE;++firstY)
                {
                    for(secondX=1;secondX<=MAXSIZE;++secondX)
                    {
                        for(secondY=1;secondY<=MAXSIZE;++secondY)
                        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            GameStart();
        }
        private void PicClick(object sender, EventArgs e)
        {
       //     ((PictureBox)sender).Visible = false;
            for(int i=0;i<MAXSIZE;++i)
            {
                for(int j=0;j<MAXSIZE;++j)
                {
                    if(this.pic[i,j]==(PictureBox)sender)
                    {
                        if(vis[i+1,j+1]==1)
                        {
                            if(firstX==0&&firstY==0)
                            {
                                firstX = i+1;
                                firstY = j+1;
                                this.pic[i, j].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                            }
                            else
                            {
                                secondX = i+1;
                                secondY = j+1;
                                this.pic[firstX - 1, firstY - 1].BorderStyle = System.Windows.Forms.BorderStyle.None;
                                Line();
                                firstX = firstY = secondX = secondY = 0;
                            }
                        }
//                        MessageBox.Show(i.ToString() + " " + j.ToString());
                    }
                }
            }
        }

        private void GameStart()
        {
            int[] a = new int[MAXSIZE * MAXSIZE];
            int t,index;
            for(int i=0;i<a.Length;i+=2)
            {
                a[i] = rd.Next(1, 16);
                a[i + 1] = a[i];
            }
            for(int i=1;i<a.Length;++i)
            {
                index = rd.Next(0, i);
                t = a[i];a[i] = a[index];a[index] = t;
            }
            for(int i = 0; i < MAXSIZE; ++i)
            {
                for(int j = 0; j < MAXSIZE; j++)
                {
                    this.pic[i, j].Image = images[a[i*MAXSIZE+j]];
                    this.pic[i, j].Name = a[i * MAXSIZE + j].ToString();
                    this.pic[i, j].Visible = true;
                    vis[i + 1, j + 1] = 1;

                }
            }
            firstX = firstY = secondX = secondY = 0;
            cnt = 0;

        }
        private void 开始ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GameStart();
        }
    }
}
