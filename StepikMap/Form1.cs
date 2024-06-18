using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System;
using System.Data;

namespace StepikMap
{
    public partial class FormMap : Form
    {
        private readonly int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        private readonly int screenHeight = Screen.PrimaryScreen.Bounds.Height;

        public List<Structure> structures = new List<Structure>();

        public static int FreeFlags = 0;


        public FormMap()
        {
            InitializeComponent();
            pictureBoxMap.Width = screenWidth;
            pictureBoxMap.Height = screenHeight;

            structures = new List<Structure>()
            {
                new Structure(150, 250, this, @"Images\cave.png", pictureBoxMap),
                new Structure(1000, 300, this, @"Images\castle.png", pictureBoxMap),
                new Structure(550, 550, this , @"Images\Swamp.png", pictureBoxMap)
            };
        }

        private void buttonReadData_Click(object sender, EventArgs e)
        {
            Clear();

            FormReadData formReadData = new FormReadData();
            formReadData.Show();
        }

        private void buttonPlaceFlags_Click(object sender, EventArgs e)
        { }

        private void Clear()
        {
            Student.Students.Clear();
            Flag.CheckPointFlags.Clear();
        }

        public static void labelFreeFlags_Count()
        {
            labelFreeFlag.Text = "Свободных флагов: " + FreeFlags;
        }
    }
}
