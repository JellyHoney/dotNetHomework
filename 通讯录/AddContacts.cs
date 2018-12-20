using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 通讯录
{
    public partial class AddContacts : UserControl
    {
        Contacts con;
        public AddContacts(Contacts con)
        {
            InitializeComponent();
            this.con = con;
            comboBox1.Items.Add(con.gname);
            comboBox1.Text = con.gname;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlClass.NonQuery("insert into contacts(name,num,gid) values('" + textBox1.Text + "','" + textBox2.Text + "'," + con.gid+")");
            con.FreshContacts();
        }
    }
}
