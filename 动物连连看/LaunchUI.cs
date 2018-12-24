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

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpUI helpUI = new HelpUI(launch);
            launch.Controls.Add(helpUI);
            helpUI.BringToFront();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GameUI gameUI = new GameUI(launch);
            launch.Controls.Add(gameUI);
            gameUI.BringToFront();

        }
    }
}
