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
    public partial class AddGroup : UserControl
    {
        Contacts con;
        public AddGroup(Contacts con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length!=0)
            {
                SqlClass.NonQuery("insert into groups(gname) values('" + textBox1.Text + "')");
                con.FreshContacts();
            }
        }
    }
}
