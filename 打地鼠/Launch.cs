using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace 打地鼠
{
    public partial class Launch : Form
    {
        public Boolean soundsOn = true;
        public Launch()
        {
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            InitializeComponent();
            this.Cursor = HammerCursor.HammerUp();
            LaunchUI launchUI = new LaunchUI(this);
            this.Controls.Add(launchUI);
        }
        public void HammerDown(object sender, MouseEventArgs e)
        {
            this.Cursor = HammerCursor.HammerDown();
        }
        public void HammerUp(object sender, MouseEventArgs e)
        {
            this.Cursor = HammerCursor.HammerUp();
        }
    }
}
