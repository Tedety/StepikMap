using System;
using System.Windows.Forms;

namespace StepikMap
{
    public partial class FormPlaceFlag : Form
    {
        public Structure clickedStructure;
        public Form formOfStructure;
        public int Flag_X;
        public int Flag_Y;

        public FormPlaceFlag(Form formOfStructure, Structure clickedPictureBoxStructure, int flag_X, int flag_Y)
        {
            InitializeComponent();
            clickedStructure = clickedPictureBoxStructure;
            Flag_X = flag_X;
            Flag_Y = flag_Y;
            this.formOfStructure = formOfStructure;
            CountFlags();
        }

        private void buttonPlace_Click(object sender, EventArgs e)
        {
            FormMap.FreeFlags--;
            CountFlags();
            PlaceFlag();
            FormMap.labelFreeFlags_Count();
            Flag.CheckPointFlags.Add(new Flag(Flag_X, Flag_Y, formOfStructure));
            Close();
            Flag.BringToUpFlags();
        }

        public void PlaceFlag()
        {
            var newFlag = new Flag(Flag_X, Flag_Y, formOfStructure);
            newFlag.BringToFront();
            newFlag.Parent = clickedStructure;
            Flag.CheckPointFlags.Add(newFlag);
        }

        public void CountFlags()
        {
            labelCountFlags.Text = $"Осталось разместить флагов: {FormMap.FreeFlags}";
        }
    }
}
