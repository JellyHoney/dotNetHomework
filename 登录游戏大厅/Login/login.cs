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
    public partial class login : Form
    {
        public int id=0;
        public login()
        {
            InitializeComponent();
            SqlClass.ConnectTest();
        }
        private void InfoCheck(string userName, string password)
        {
            password = Encrypt.MD5Encrypt32(password);
            DataTable dt = SqlClass.Fill("select * from account where userName='" + userName + "'");
            if (dt.Rows.Count==0)
            {
                MessageBox.Show("账号不存在");
                return;
            }
            if(!dt.Rows[0]["password"].ToString().Equals(password))
            {
                MessageBox.Show("密码错误");
                return;
            }
            id = Convert.ToInt32(dt.Rows[0]["id"]);
            this.Close();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InfoCheck(textBox1.Text, textBox2.Text);
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            InfoCheck(textBox1.Text, textBox2.Text);
        }
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }
        private void BtnMinimized_Click(object sender, EventArgs e)
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
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("账号"))
            {
                textBox1.Text = "";
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "账号";
                textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("密码"))
            {
                textBox2.Text = "";
                textBox2.UseSystemPasswordChar = true;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "密码";
                textBox2.UseSystemPasswordChar = false;
                textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        Boolean mouseHold = false;
        int mouseX, mouseY, FramX, FramY;
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
