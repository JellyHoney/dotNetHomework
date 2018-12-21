using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 搏饼
{
    public partial class Form1 : Form
    {
        Random rd;
        int[] num = new int[6];
        int[] cnt = new int[7];
        Button[] btn = new System.Windows.Forms.Button[6];
        void Myinit()
        {
            for (int i = 0; i < 6; ++i)
            {
                this.btn[i] = new System.Windows.Forms.Button();
                this.btn[i].Location = new System.Drawing.Point(10+i*80, 26);
                this.btn[i].Name = "btn" + i.ToString();
                this.btn[i].Size = new System.Drawing.Size(77, 67);
                this.btn[i].TabIndex = 5;
                this.btn[i].Text = "";
                this.btn[i].UseVisualStyleBackColor = true;
                this.Controls.Add(this.btn[i]);
            }
        }
        public Form1()
        {
            InitializeComponent();
            rd = new Random();
            Myinit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                button1.Text = "停止";
            }
            else
            {
                button1.Text = "开始";
                for (int i = 0; i < 7; ++i)
                {
                    cnt[i] = 0;
                }
                for (int i = 0; i < 6; ++i)
                {
                    cnt[num[i]]++;
                }
                if (cnt[4] >= 4)
                {
                    if (cnt[1] == 2)
                    {
                        price.Text = "状元插金花";
                    }
                    else
                    {
                        price.Text = "状元";
                    }
                }
                else if(cnt[4]==3)
                {
                    price.Text = "三红";
                }
                else if(cnt[4]==2)
                {
                    price.Text = "二举";
                }
                else if(cnt[4]==1)
                {
                    price.Text = "秀才";
                }
                else
                {
                    price.Text = "落榜";
                }
            }
            timer1.Enabled = !timer1.Enabled;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; ++i)
            {
                num[i] = rd.Next(1, 7);
                btn[i].BackgroundImage =Image.FromFile(@"..\..\Resources\" + num[i].ToString() + ".png");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
