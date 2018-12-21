using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 射击游戏
{
    public partial class shotting : Form
    {
        public System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public shotting()
        {
            InitializeComponent();
            player.SoundLocation = @"..\..\Resources\Faster.wav";
            player.Play();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Btn1.Location = new System.Drawing.Point(Btn1.Location.X - 2, Btn1.Location.Y);
        }
    }
}
