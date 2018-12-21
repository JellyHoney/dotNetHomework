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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        int InfoCheck(string userName, string password,string cpassword)
        {
            DataTable dt;
            dt = SqlClass.Fill("select * from account where userName='" + userName + "'");
            if(dt.Rows.Count!=0)
            {
                MessageBox.Show("账号已存在");
                return 1;
            }
            if(!password.Equals(cpassword))
            {
                MessageBox.Show("两次密码不一致");
                return 2;
            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = richTextBox1.Text;
            string password = richTextBox2.Text;
            string cpassword = richTextBox3.Text;
            if(InfoCheck(userName, password, cpassword)==0)
            {
                SqlClass.NonQuery("insert into account(userName,password) values('" + userName + "','" + Encrypt.MD5Encrypt32(password) + "')");
            }
            
        }
    }
}
