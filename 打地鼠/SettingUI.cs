using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打地鼠
{
    public partial class SettingUI : UserControl
    {
        Launch launch;
        public SettingUI(Launch launch)
        {
            InitializeComponent();
            this.launch = launch;
            panel1.MouseDown += launch.HammerDown;
            panel1.MouseUp += launch.HammerUp;
            pictureBox1.MouseDown += launch.HammerDown;
            pictureBox1.MouseUp += launch.HammerUp;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }
    }
}
