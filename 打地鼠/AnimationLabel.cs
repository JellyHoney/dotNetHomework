using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打地鼠
{
    public partial class AnimationLabel : Label
    {
        Timer timer;
        int movePix = 70;//需要上移的像素点
        public AnimationLabel()
        {
            InitializeComponent();
            this.ParentChanged += new EventHandler(this.ResetLocation);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        private void MoveUp(object sender,EventArgs e)
        {
            if(movePix>0)
            {
                this.Location = new Point(this.Location.X, this.Location.Y - 1);
                movePix--;
            }
            else
            {
                timer.Enabled = false;
                timer.Dispose();
                this.Dispose();
            }
        }
        private void ResetLocation(object sender, EventArgs e)
        {
            if(this.Parent!=null)
            {
                this.Location = new Point(0, this.Parent.Height);
                timer = new Timer();
                timer.Interval = 10;
                timer.Tick += new EventHandler(this.MoveUp);
                timer.Enabled = true;
                this.BringToFront();
            }
        }
    }
}
