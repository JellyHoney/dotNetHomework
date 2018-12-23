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
            checkBox1.Checked = launch.soundsOn;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            launch.soundsOn = checkBox1.Checked;
        }
    }
}
