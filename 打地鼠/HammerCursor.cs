using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace 打地鼠
{
    internal class HammerCursor
    {
        public static Cursor HammerUp()
        {
            Image fn = Properties.Resources.锤子;
            Bitmap bitmap = new Bitmap(fn);
            IntPtr handle = bitmap.GetHicon();
            Cursor myCursor = new Cursor(handle);
            return myCursor;
        }
        public static Cursor HammerDown()
        {
            Image fn = Properties.Resources.锤子落下;
            Bitmap bitmap = new Bitmap(fn);
            IntPtr handle = bitmap.GetHicon();
            Cursor myCursor = new Cursor(handle);
            return myCursor;
        }
    }
}
