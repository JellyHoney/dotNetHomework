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
            InitializeComponent();
            //  TODO:  在  InitComponent  调用后添加任何初始化 
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //开启双缓冲
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
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
