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
        String opString = "";
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
        private int Calc(int a,int b,char op)
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
            s = '0' + s;
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
                    while(topOpv>0&&level(s[i])<=level(opv[topOpv]))
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
            oldString += newString;
            newString = "";
            opString = "";
            newString = CalcExpression(oldString);
            textBox1.Text = oldString + "=" + Environment.NewLine + newString;
            oldString = "";
        }
        private void NumOp(string Num)
        {
            oldString += opString;
            opString = "";
            newString += Num;
            textBox1.Text = oldString + Environment.NewLine + newString;
        }
        private void OpOp(string op)
        {
            oldString += newString;
            opString = op;
            newString = "";
            textBox1.Text = oldString + opString + Environment.NewLine + newString;
        }
        private void buttonNumClick(object sender, EventArgs e)
        {
            NumOp(((Button)sender).Name);
        }
        private void buttonOpClick(object sender, EventArgs e)
        {
            OpOp(((Button)sender).Name);
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
            opString = "";
        }
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Equal();
                    break;
                case Keys.NumPad0:
                    NumOp("0");
                    break;
            }*/
        }
    }
}
