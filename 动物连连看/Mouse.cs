using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace 动物连连看
{
    internal class Mouse
    {
        public static Cursor MouseUp()
        {
            Image fn = Properties.Resources.mouse;
            Bitmap bitmap = new Bitmap(fn);
            IntPtr handle = bitmap.GetHicon();
            Cursor myCursor = new Cursor(handle);
            return myCursor;
        }
        public static Cursor MouseDown()
        {
            Image fn = Properties.Resources.mouseDown;
            Bitmap bitmap = new Bitmap(fn);
            IntPtr handle = bitmap.GetHicon();
            Cursor myCursor = new Cursor(handle);
            return myCursor;
        }
    }
}
