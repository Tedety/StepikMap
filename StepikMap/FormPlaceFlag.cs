using System;
using System.Windows.Forms;

namespace StepikMap
{
    public partial class FormPlaceFlag : Form
    {
        public Form form;
        public int Flag_X;
        public int Flag_Y;

        public FormPlaceFlag(Form formOfStructure, int flag_X, int flag_Y)
        {
            InitializeComponent();
            Flag_X = flag_X;
            Flag_Y = flag_Y;
            form = formOfStructure;
            CountFlags();
        }

        private void buttonPlace_Click(object sender, EventArgs e)
        {
            FormMap.FreeFlags--;
            CountFlags();
            PlaceFlag();

            FormMap.labelFreeFlags_Count();
            Close();
        }

        public void PlaceFlag()
        {
            var newFlag = new Flag(Flag_X, Flag_Y, form);
            newFlag.BringToFront();
            Flag.CheckPointFlags.Add(newFlag);
        }

        public void CountFlags()
        {
            labelCountFlags.Text = $"Осталось разместить флажков-чекпоинтов: {FormMap.FreeFlags}";
        }
    }
}
