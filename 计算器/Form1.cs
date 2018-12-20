using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        String oldString = "";
        String newString = "";
        public Form1()
        {
            InitializeComponent();
            MyInit();
        }
        int level(char c)
        {
            int res = 0;
            switch (c)
            {
                case '+':
                    res = 0;
                    break;
                case '-':
                    res = 0;
                    break;
                case '*':
                    res = 1;
                    break;
                case '/':
                    res = 1;
                    break;
                case '(':
                    res = 2;
                    break;
                case ')':
                    res = 2;
                    break;
                case '#':
                    res = -1;
                    break;
                default:
                    res = 0;
                    break;
            }
            return res;
        }
        private int Calc(int a,int b,int op)
        {
            if(op=='+')
            {
                return a+b;
            }
            if(op=='-')
            {
                return a-b;
            }
            if(op=='*')
            {
                return a*b;
            }
            if(op=='/')
            {
                return a/b;
            }
            return 0;
        }
        private String CalcExpression(String s)
        {
            int opnum = 0;
            const int N = 100;
            int[] ops=new int[N];
            char[] opv=new char[N];
            int topOps=0,topOpv=0;
            s += '#';
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    opnum = opnum * 10 + s[i] - '0';
                }
                else
                {
                    ops[++topOps]=opnum;
                    opnum = 0;
                    while(topOpv>0&&level(s[i])<level(opv[topOpv]))
                    {
                        ops[topOps - 1] = Calc(ops[topOps - 1], ops[topOps], opv[topOpv]);
                        topOps--;
                        topOpv--;
                    }
                    opv[++topOpv] = s[i];
                }
            }
            return ops[1].ToString();
        }

        private void Equal()
        {
            textBox1.Text = textBox1.Text + "=" + Environment.NewLine + CalcExpression(textBox1.Text);
        }

        private void buttonNumClick(object sender, EventArgs e)
        {
            newString += ((Button)sender).Name;
            textBox1.Text = oldString + Environment.NewLine + newString;
        //    textBox1.Text += ((Button)sender).Name;
        }
        private void buttonOpClick(object sender, EventArgs e)
        {
            newString += ((Button)sender).Name;
            textBox1.Text = oldString + Environment.NewLine + newString;
            if (newString.Length > 1)
            {
                oldString = oldString + newString;
                newString = "";
            }
        }

        private void buttonEqualClick(object sender, EventArgs e)
        {
            Equal();
        }
        private void buttonDotClick(object sender, EventArgs e)
        {
           // textBox1.Text = CalcExpression(textBox1.Text);
        }

        private void buttonBackSpaceClick(object sender, EventArgs e)
        {
            textBox1.Text = CalcExpression(textBox1.Text);
        }

        private void buttonClearClick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            oldString = "";
            newString = "";
        }
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Equal();
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
