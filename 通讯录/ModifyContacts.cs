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
        List<KeyValuePair<string, string>> ls=new List<KeyValuePair<string, string>>();
        public ModifyContacts(Contacts con)
        {
            InitializeComponent();
            this.con = con;
            DataTable dt = new DataTable();
            dt = SqlClass.Fill("select * from groups");
            for(int i=0;i<dt.Rows.Count;++i)
            {
                comboBox1.Items.Add(dt.Rows[i]["gname"].ToString());
                ls.Add(new KeyValuePair<string, string>(dt.Rows[i]["gid"].ToString(),dt.Rows[i]["gname"].ToString() ));
            }
            comboBox1.Text = con.gname;
            dt = SqlClass.Fill("select * from contacts where id=" + con.id);
            textBox1.Text = dt.Rows[0]["name"].ToString();
            textBox2.Text = dt.Rows[0]["num"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show(con.id + " " + ls[comboBox1.SelectedIndex].Key);
            SqlClass.NonQuery("update contacts set name='" + textBox1.Text + "',num='" + textBox2.Text + "' ,gid=" + ls[comboBox1.SelectedIndex].Key + " where id=" + con.id);
            con.FreshContacts();
        }
    }
}
