using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace 动物连连看
{
    class Animal
    {
        static int img_width = 163;
        public static Image GetAnimal(int n)
        {
            if (n >= 21) return null;
            Bitmap bmp = new Bitmap(img_width, img_width);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle destRect = new Rectangle(0, 0, img_width, img_width);
            Rectangle srcRect = new Rectangle(n % 4 * img_width, n / 4 * img_width, img_width, img_width);
            if(n/4==3)
            {
                srcRect = new Rectangle(n % 4 * img_width+10, n / 4 * img_width, img_width, img_width);
            }
            g.DrawImage(Properties.Resources.animal, destRect, srcRect, GraphicsUnit.Pixel);
            g.Dispose();
            return bmp;
        }
    }
}
