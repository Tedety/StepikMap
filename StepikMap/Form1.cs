using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StepikMap
{
    public partial class FormMap : Form
    {
        const string pathFlagsLocation = @"C:\Users\Tpyma\Desktop\Anteiku\Работа\Курсовая 1\StepikMap\StepikMap\AnyFiles\Flags1.txt";

        public FormMap()
        {
            InitializeComponent();
        }

        //private void pictureBoxMap_MouseDown(object sender, MouseEventArgs e)
        //{
        //    PictureBoxFlag pictureBoxFlag = new PictureBoxFlag(e.X, e.Y, this);
        //    pictureBoxFlag.Parent = pictureBoxMap;
        //}

        private void buttonLoadFlags_Click(object sender, EventArgs e)
        {
            var flagsLocation = File.ReadAllLines(pathFlagsLocation);
            var flags = new List<PictureBoxFlag>();

            for (int i = 0; i < flagsLocation.Length; i++)
            {
                var location = flagsLocation[i].Split();
                int x = Convert.ToInt32(location[0]) - 16, y = Convert.ToInt32(location[1]) -16;


                flags.Add(new PictureBoxFlag(x, y, this));
                flags[i].Parent = pictureBoxMap;
            }

        }
    }
}
