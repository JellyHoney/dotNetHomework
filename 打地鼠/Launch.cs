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
        public Launch()
        {
            InitializeComponent();
            this.Cursor = HammerCursor.HammerUp();
            LaunchUI lui = new LaunchUI(this);
            this.Controls.Add(lui);
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
