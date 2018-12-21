using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
