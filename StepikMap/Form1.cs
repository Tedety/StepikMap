using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace StepikMap
{
    public partial class FormMap : Form
    {
        const string pathFlagsLocation = @"C:\Users\Tpyma\Desktop\Anteiku\Работа\Курсовая 1\StepikMap\StepikMap\AnyFiles\Flags1.txt";

        private int screenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
        private int screenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

        public List<PictureBoxStructure> structures = new List<PictureBoxStructure>();

        public FormMap()
        {
            InitializeComponent();
            pictureBoxMap.Width = screenWidth;
            pictureBoxMap.Height = screenHeight;

            structures = new List<PictureBoxStructure>()
            {
                new PictureBoxStructure(150, 250, this, @"Images\cave.png", pictureBoxMap),
                new PictureBoxStructure(1000, 300, this, @"Images\castle.png", pictureBoxMap)
            };
        }
    }
}
