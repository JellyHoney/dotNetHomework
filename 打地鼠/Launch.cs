using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打地鼠
{
    public partial class Launch : Form
    {
        public Launch()
        {
            InitializeComponent();
            InitMouse();
        }
        void InitMouse()
        {
            SetMouseHamorUp();
        }
        void SetMouseHamorDown()
        {
            Image fn = Properties.Resources.锤子落下;
            Bitmap bitmap = new Bitmap(fn);
            IntPtr handle = bitmap.GetHicon();
            Cursor myCursor = new Cursor(handle);
            this.Cursor = myCursor;
        }
        void SetMouseHamorUp()
        {
            Image fn = Properties.Resources.锤子;
            Bitmap bitmap = new Bitmap(fn);
            IntPtr handle = bitmap.GetHicon();
            Cursor myCursor = new Cursor(handle);
            this.Cursor = myCursor;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Launch_MouseDown(object sender, MouseEventArgs e)
        {
            SetMouseHamorDown();

        }
        private void Launch_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void Launch_MouseUp(object sender, MouseEventArgs e)
        {

            SetMouseHamorUp();
        }
    }
}
