using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 圆体时钟
{
    public partial class Form1 : Form
    {
        private float mWidth;
        private float mHeight;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        float mRadius;
        Color bgColor;
        Color secondColor;
        Color minuteColor;
        Color hourColor;
        Color circleColor;
        Color markColor;
        private void Form1_Load(object sender, EventArgs e)
        {
            mWidth = this.ClientSize.Width;
            mHeight = this.ClientSize.Height;
            mRadius = (float)(Math.Min(mWidth, mHeight) * 0.45);
            bgColor = Color.White;
            secondColor = Color.Black;
            minuteColor = Color.Blue;
            hourColor = Color.Red;
            circleColor = Color.Gray;
            markColor = Color.Gray;
        }
        private void OnDraw()
        {
            this.Refresh();
            g = this.CreateGraphics();
            g.TranslateTransform((float)(mWidth / 2), (float)(mHeight / 2));
         //   g.Clear(DefaultBackColor);
            //get current time
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            //draw second
            Pen secondp = new Pen(secondColor, 2);
            g.RotateTransform(second * 6);
            g.DrawLine(secondp, 0, 40, 0, -(float)(mRadius));
            //draw minute
            Pen minutep = new Pen(secondColor, 4);
            g.RotateTransform(-second * 6);
            g.RotateTransform((float)(minute*6+second*0.1));
            g.DrawLine(minutep, 0, 20, 0, -(float)(mRadius / 1.5));
            //draw hour
            Pen hourp = new Pen(secondColor, 6);
            g.RotateTransform((float)(-minute * 6 - second * 0.1));
            g.RotateTransform((float)(hour * 30 + minute * 30/60 +second*30/3600));
            g.DrawLine(hourp, 0, 20, 0, -(float)(mRadius / 2));

            g.RotateTransform((float)(-hour * 30 - minute * 30 / 60 - second * 30 / 3600));

            if (hour > 12)
            {
                hour -= 12;
                String hourS = hour.ToString();
                if (hour < 10)
                {
                    hourS = '0' + hourS;
                }
                String minuteS = minute.ToString();
                if (minute < 10)
                {
                    minuteS = '0' + minuteS;
                }
                label1.Text = hourS + ":" + minuteS + "PM";
            }
            else
            {
                String hourS = hour.ToString();
                if (hour < 10)
                {
                    hourS = '0' + hourS;
                }
                String minuteS = minute.ToString();
                if (minute < 10)
                {
                    minuteS = '0' + minuteS;
                }
                label1.Text = hourS + ":" + minuteS + "PM";
            }
          //  this.Text = "时钟 "+richTextBox1.Text;
            this.Text = "时钟 " + DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            OnDraw();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 630;
            OnDraw();
        }

    }
}
