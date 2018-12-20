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
        public Form1()
        {
            InitializeComponent();
            rd = new Random();
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
            String s = "";
            for (int i = 0; i < 6; ++i)
            {
                num[i] = rd.Next(1, 7);
                s += num[i].ToString();
            }
            richTextBox1.Text = s;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
