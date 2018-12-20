using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }
        private int lcm(int a, int b)
        {
            if (gcd(a, b) == 0)
            {
                return 0;
            }
            return a*b/gcd(a,b);
        }
        private String conver(String a)
        {
            String res = "";
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] >= '0' && a[i] <= '9')
                {
                    res += a[i];
                }
            }
            if (res.Length == 0)
            {
                res = "0";
            }
            return res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = conver(textBox1.Text);
            textBox2.Text = conver(textBox2.Text);
            int a=int.Parse(textBox1.Text);
            int b=int.Parse(textBox2.Text);
            int c = gcd(a, b);
            int d = lcm(a, b);
            textBox3.Text = c.ToString();
            textBox4.Text = d.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
