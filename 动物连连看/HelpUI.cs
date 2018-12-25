using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 动物连连看
{
    public partial class HelpUI : UserControl
    {
        Launch launch;
        int selectedPic = 1;
        public HelpUI(Launch launch)
        {
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            InitializeComponent();
            this.launch = launch;
            this.MouseDown += launch.Launch_MouseDown;
            this.MouseUp += launch.Launch_MouseUp;
        }
        private void rightButton_Click(object sender, EventArgs e)
        {
            if(selectedPic==1)
            {
                selectedPic = 2;
            }
            else
            {
                selectedPic = 1;
            }
            if (selectedPic == 1)
            {
                this.BackgroundImage = Properties.Resources.help1;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.help2;
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (selectedPic == 1)
            {
                selectedPic = 2;
            }
            else
            {
                selectedPic = 1;
            }
            if(selectedPic==1)
            {
                this.BackgroundImage = Properties.Resources.help1;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.help2;
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            launch.Controls.Remove(this);
            this.Dispose();
        }
    }
}
