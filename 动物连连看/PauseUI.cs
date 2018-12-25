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
    public partial class PauseUI : UserControl
    {
        Launch launch;
        public PauseUI(Launch launch)
        {
            this.launch = launch;
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            launch.Controls["gameUI"].BringToFront();
            launch.Controls.Remove(this);
        }

        private void ReturnMenuButton_Click(object sender, EventArgs e)
        {

            launch.Controls["launchUI"].BringToFront();
            launch.Controls.Remove(this);
        }
    }
}
