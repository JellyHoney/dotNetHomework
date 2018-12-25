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
    public partial class LaunchUI : UserControl
    {
        Launch launch;
        public LaunchUI(Launch launch)
        {
            InitializeComponent();
            this.launch = launch;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpUI helpUI = new HelpUI(launch);
            launch.Controls.Add(helpUI);
            helpUI.BringToFront();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            launch.Controls["gameUI"].BringToFront();
        }
    }
}
