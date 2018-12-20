using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 猜数字
{
    public partial class Form1 : Form
    {
        int ans;
        Random rd;
        public Form1()
        {
            InitializeComponent();
            MyInitializeComponent();
            rd = new Random();
            ans = rd.Next(0, 100);
            score.Text = "7";
        }

        private void NextRound()
        {
            score.Text = "7";
            ans = rd.Next(0, 100);
            for (int i = 0; i < 100; ++i)
            {
                this.num[i].Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(score.Text) < 0)
            {
                totScore.Text = (Convert.ToInt32(totScore.Text) + Convert.ToInt32(score.Text)).ToString();
            }
            NextRound();
         //   MessageBox.Show(ans.ToString());
        }
        private void num_Click(object sender, EventArgs e)
        {
            String s = ((Button)sender).Name;
            int now = Convert.ToInt32(s);
            if (now == ans)
            {
                MessageBox.Show("you win");
                totScore.Text=(Convert.ToInt32(totScore.Text)+Convert.ToInt32(score.Text)).ToString();
                NextRound();
            }
            else if (now < ans)
            {
                for (int i = 0; i <= now; ++i)
                {
                    this.num[i].Enabled = false;
                }
                score.Text = (Convert.ToInt32(score.Text)-1).ToString();
            }
            else
            {
                for (int i = now; i < 100; ++i)
                {
                    this.num[i].Enabled = false;
                }
                score.Text = (Convert.ToInt32(score.Text) - 1).ToString();
            }
         //   MessageBox.Show(s);
        }
    }
}
