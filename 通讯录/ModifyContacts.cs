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
    public partial class ModifyContacts : UserControl
    {
        Contacts con;
        public ModifyContacts(Contacts con)
        {
            InitializeComponent();
            this.con = con;
            comboBox1.Items.Add(con.gname);
            comboBox1.Text = con.gname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlClass.NonQuery("update contacts set name='" + textBox1.Text + "',num='" + textBox2.Text + "' where id=" + con.id);
            con.FreshContacts();
        }
    }
}
