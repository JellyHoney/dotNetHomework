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
    public partial class GameUI : UserControl
    {
        Launch launch;
        PictureBox[] animal = new PictureBox[100];
        public GameUI(Launch launch)
        {
            InitializeComponent();
            this.launch = launch;
            for (int i = 0; i < 100; ++i)
            {
                animal[i] = new PictureBox();
                animal[i].Location = new System.Drawing.Point(i / 10 * 50, i % 10 * 50);
                animal[i].Width = 50;
                animal[i].Height = 50;
                animal[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                panel1.Controls.Add(animal[i]);
            }
            GenAnimal();
        }
        void GenAnimal()
        {
            Random rd = new Random();
            for(int i=0;i<100;++i)
            {
                animal[i].BackgroundImage = Animal.GetAnimal(rd.Next(0, 20));
            }
        }
    }
}
