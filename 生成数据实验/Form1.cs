using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 生成数据实验
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            DataSet Ds = new DataSet("My database");
            textBox1.Text += "数据库的名称为:" + Ds.DataSetName;
            DataTable Dt = new DataTable("student information table");
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "数据库表格生成成功,表格名为:" + Dt.TableName;
            Ds.Tables.Add(Dt);
            Dt.Columns.Add("ID", typeof(System.Guid));
            Dt.Columns.Add("学号", typeof(System.String));
            Dt.Columns.Add("姓名", typeof(System.String));
            Dt.Columns.Add("性别", typeof(System.String));
            Dt.Columns.Add("专业", typeof(System.String));
            for (int i = 0; i < 10; i++)
            {
                DataRow Dr = Dt.NewRow();
                Dr[0] = Guid.NewGuid();
                Dr[1] = rd.Next(10000, 10100);
                Dr[2] = createname();
                Dr[3] = createsex();
                Dr[4] = createmajor();
                Dt.Rows.Add(Dr);
            }
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "生成十条数据!";
            dataGridView1.DataSource = Ds.Tables["student information table"];
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 45;
            dataGridView1.Columns[3].Width = 20;
            dataGridView1.Columns[4].Width = 140;
        }
        private string createname()
        {
            byte[] name = new byte[6];
            int area;
            int order;
            for (int j = 0; j < 3; j++)
            {
                area = rd.Next(16, 56) + 0xa0;
                if (area != 55)
                {
                    order = rd.Next(1, 95) + 0xa0;
                }
                else
                    order = rd.Next(1, 90) + 0xa0;
                name[j * 2] = (byte)area;
                name[j * 2 + 1] = (byte)order;
            }
            return Encoding.GetEncoding("GB2312").GetString(name);
        }
        private string createsex()
        {
            int sex = rd.Next(0, 2);
            if (sex == 0)
                return "男";
            else
                return "女";
        }
        private string createmajor()
        {
            int major = rd.Next(0, 2);
            if (major == 0)
                return "软件工程";
            else
                return "计算机科学与技术";
        }
    }
}
