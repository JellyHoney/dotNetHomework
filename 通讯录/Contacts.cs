using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 通讯录
{
    public partial class Contacts : Form
    {
        public string gid, gname, id, name;
        public Contacts()
        {
            InitializeComponent();
            FreshContacts();
        }
        private void 添加分组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            AddGroup t = new AddGroup(this);
            t.Location = new System.Drawing.Point(0, 0);
            groupBox1.Controls.Add(t);
            
        }
        private void 添加联系人ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            AddContacts t = new AddContacts(this);
            t.Location = new System.Drawing.Point(0, 0);
            groupBox1.Controls.Add(t);
        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            contextMenuStrip1.Items[1].Enabled = false;
            contextMenuStrip1.Items[2].Enabled = false;
            contextMenuStrip1.Items[3].Enabled = false;

        }

        private void 删除分组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlClass.NonQuery("delete from groups where gid='" + gid + "'");
            FreshContacts();
        }
        private void 删除联系人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlClass.NonQuery("delete from contacts where id='" + id + "'");
            FreshContacts();

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1.SelectedNode = e.Node;
            if (e.Button==MouseButtons.Left)//左键
            {
                if (e.Node.Level == 0)
                {
                    gid = e.Node.Name;
                    gname = e.Node.Text;
                    ModifyGroups mod = new ModifyGroups(this);
                    groupBox1.Controls.Clear();
                    groupBox1.Controls.Add(mod);
                }
                else
                {
                    gid = e.Node.Parent.Name;
                    gname = e.Node.Parent.Text;
                    id = e.Node.Name;
                    ModifyContacts mod = new ModifyContacts(this);
                    groupBox1.Controls.Clear();
                    groupBox1.Controls.Add(mod);

                }
            }
            else//右键
            {
                if(e.Node.Level==0)//右键分组
                {
                    gid = e.Node.Name;
                    gname = e.Node.Text;
                    contextMenuStrip1.Items[1].Enabled = true;
                    contextMenuStrip1.Items[2].Enabled = true;
                }
                else
                {
                    gid = e.Node.Parent.Name;
                    gname = e.Node.Parent.Text;
                    id = e.Node.Name;
                    contextMenuStrip1.Items[2].Enabled = true;
                    contextMenuStrip1.Items[3].Enabled = true;
                }
            }
        }
        public void FreshContacts()
        {
            DataTable dt = new DataTable();
            dt = SqlClass.Fill("select * from groups");
            treeView1.Nodes.Clear();
            for(int i=0;i<dt.Rows.Count;++i)
            {
                treeView1.Nodes.Add(dt.Rows[i]["gid"].ToString(),dt.Rows[i]["gname"].ToString());
            }
            foreach (TreeNode tn in treeView1.Nodes)
            {
                dt = SqlClass.Fill("select * from contacts where gid='" + tn.Name + "'");
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    tn.Nodes.Add(dt.Rows[i]["id"].ToString(), dt.Rows[i]["name"].ToString());
                }
            }
            treeView1.ExpandAll();
        }
    }
}
