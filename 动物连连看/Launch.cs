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
    public partial class Launch : Form
    {
        public Launch()
        {   
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            InitializeComponent();
            LaunchUI launchUI = new LaunchUI(this);
            this.Controls.Add(launchUI);
            this.Cursor = Mouse.MouseUp();
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
