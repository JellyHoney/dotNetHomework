using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace 登录游戏大厅
{
    public partial class GameCenter : Form
    {
        public GameCenter(int id)
        {
            InitializeComponent();
        }

        Boolean mouseHold = false;
        int mouseX, mouseY, FramX, FramY;

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void pictureBoxMouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.Height += 15;
            pictureBox.Width += 15;
        }
        private void pictureBoxMouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.Height -= 15;
            pictureBox.Width -= 15;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\大学\dotNet\homework\打地鼠\bin\Debug\打地鼠.exe");
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Process.Start(@"D:\大学\dotNet\homework\动物连连看\bin\Debug\动物连连看.exe");
        }
        private void GameCenter_MouseDown(object sender, MouseEventArgs e)
        {
            mouseHold = true;
            FramX = this.Left;
            FramY = this.Top;
            mouseX = Cursor.Position.X;
            mouseY = Cursor.Position.Y;
            this.Cursor = Cursors.SizeAll;
        }
        private void GameCenter_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseHold)
            {
                this.Left = FramX + Cursor.Position.X - mouseX;
                this.Top = FramY + Cursor.Position.Y - mouseY;
            }
        }
        private void GameCenter_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            mouseHold = false;
        }
    }
}
