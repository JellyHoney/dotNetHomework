﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 动物连连看
{
    public partial class Launch : Form
    {
        LaunchUI launchUI;
        public GameUI gameUI;
        public Launch()
        {   
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Cursor = Mouse.MouseUp();
            launchUI = new LaunchUI(this);
            this.Controls.Add(launchUI);
            gameUI = new GameUI(this);
            this.Controls.Add(gameUI);

        }

        public void Launch_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Mouse.MouseDown();
        }

        public void Launch_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Mouse.MouseUp();
        }
    }
}
