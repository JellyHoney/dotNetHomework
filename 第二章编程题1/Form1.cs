using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 第二章编程题1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] s=textBox1.Text.Split(' ');
            textBox1.Text = "";
            foreach (String t in s)
            {
                textBox1.Text += t;
            }
            
        }
    }
}
