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
    public partial class Launch : Form
    {
        int id;
        public Launch()
        {
            InitializeComponent();
            SqlClass.ConnectTest();
        }
        private int InfoCheck(string userName, string password)
        {
            password = Encrypt.MD5Encrypt32(password);
            DataTable dt = SqlClass.Fill("select * from account where userName='" + userName + "'");
            if (dt.Rows.Count==0)
            {
                MessageBox.Show("账号不存在");
                return 1;
            }
            if(!dt.Rows[0]["password"].ToString().Equals(password))
            {
                MessageBox.Show("密码错误");
                return 2;
            }
            id = Convert.ToInt32(dt.Rows[0]["id"]);
            return 0;
        }

        Boolean mouseHold = false;
        int mouseX, mouseY, FramX, FramY;


        private void button3_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 注册账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InfoCheck(textBox1.Text, textBox2.Text) == 0)
            {
                GameCenter gm = new GameCenter();
                gm.ShowDialog();
            }

        }

        private void Launch_MouseDown(object sender, MouseEventArgs e)
        {
            mouseHold = true;
            FramX = this.Left;
            FramY = this.Top;
            mouseX = Cursor.Position.X;
            mouseY = Cursor.Position.Y;
            this.Cursor = Cursors.SizeAll;
        }
        private void Launch_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseHold)
            {
                this.Left = FramX + Cursor.Position.X - mouseX;
                this.Top = FramY + Cursor.Position.Y - mouseY;
            }
        }
        private void Launch_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            mouseHold = false;
        }
    }
}
