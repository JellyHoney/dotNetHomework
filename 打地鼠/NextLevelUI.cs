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
    public partial class NextLevelUI : UserControl
    {
        GameUI gameUI;
        public NextLevelUI(GameUI gameUI)
        {
            InitializeComponent();
            this.gameUI = gameUI;
            this.LbThisScore.Text = this.gameUI.thisScore.ToString();
            this.LbPassScore.Text = this.gameUI.passScore.ToString();
            this.LbTotalScore.Text = this.gameUI.totalScore.ToString();
            this.LbThisLevel.Text = this.gameUI.level.ToString();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gameUI.NextLevel();
            gameUI.Controls.Remove(this);
        }
    }
}
