using System.Collections.Generic;
using System.Windows.Forms;
using System;
using static StepikMap.Flag;
using static StepikMap.Student;

namespace StepikMap
{
    public partial class FormMap : Form
    {
        private readonly int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        private readonly int screenHeight = Screen.PrimaryScreen.Bounds.Height;

        public static int FreeFlags = 0;


        public FormMap()
        {
            InitializeComponent();
            pictureBoxMap.Width = screenWidth;
            pictureBoxMap.Height = screenHeight;



            MouseDown += new MouseEventHandler(FormMap_MouseDown);

            //Не актуально
            //structures = new List<Structure>()
            //{
            //    new Structure(150, 250, this, @"Images\cave.png", pictureBoxMap),
            //    new Structure(1000, 300, this, @"Images\castle.png", pictureBoxMap),
            //    new Structure(550, 550, this , @"Images\Swamp.png", pictureBoxMap)
            //};
        }

        private void FormMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (FreeFlags == 0)
            {
                MessageBox.Show("Нет свободных флагов");
            }

            else
            {
                FormPlaceFlag formPlaceFlag = new FormPlaceFlag(this, e.X, e.Y);
                formPlaceFlag.ShowDialog();
            }
        }

        private void buttonReadData_Click(object sender, EventArgs e)
        {
            FormReadData formReadData = new FormReadData();
            formReadData.Show();
        }

        private void buttonPlaceFlags_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckPointFlags.Count; i++)
            {
                PlaceAroundFlag(i);
            }
        }


        public static void labelFreeFlags_Count()
        {
            labelFreeFlag.Text = "Свободных флажков-чекпоинтов: " + FreeFlags;
        }

    }
}
