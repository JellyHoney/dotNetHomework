using System;
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
    public partial class AnimationPic : PictureBox
    {
        Timer timer;
        int life = 1000;
        public AnimationPic()
        {
            InitializeComponent();
            this.ParentChanged += new EventHandler(this.ResetLocation);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        private void Kill(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timer.Dispose();
            this.Dispose();
        }
        private void ResetLocation(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                timer = new Timer
                {
                    Interval = life
                };
                timer.Tick += new EventHandler(this.Kill);
                timer.Enabled = true;
                this.BringToFront();
            }
        }
    }
}
