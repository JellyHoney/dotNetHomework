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
    public partial class ModifyGroups : UserControl
    {
        Contacts con;
        public ModifyGroups()
        {
            InitializeComponent();
        }
        public ModifyGroups(Contacts con)
        {
            InitializeComponent();
            this.con = con;
            textBox1.Text = con.gname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlClass.NonQuery("update groups set gname='" + textBox1.Text + "' where gid='"+con.gid+"'");
            con.FreshContacts();
        }
    }
}
