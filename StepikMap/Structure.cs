using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StepikMap
{
    public class Structure : PictureBox
    {
        public Structure()
        { }
        public List<Point> listOfPoints = new List<Point>();

        public List<Flag> pictureBoxFlags = new List<Flag>();

        protected Form form;

        public Structure(int x, int y, Form form, string path, PictureBox pictureBox)
        {
            Left = x;
            Top = y;
            this.form = form;
            Load(path);
            SizeMode = PictureBoxSizeMode.StretchImage;
            BackColor = Color.Transparent;
            form.Controls.Add(this);
            Parent = pictureBox;
            Width *= 2;
            Height *= 2;


            // Список всех точек, которые занимает Структура
            for (int i = x; i < x + Height; i++)
            {
                for (int j = y; j < y + Width; j++)
                {
                    listOfPoints.Add(new Point(i, j));
                }
            }

            MouseDown += new MouseEventHandler(PictureBoxStructure_MouseDown);
        }

        private void PictureBoxStructure_MouseDown(object sender, MouseEventArgs e)
        {
            if (FormMap.FreeFlags == 0)
            {
                MessageBox.Show("Нет свободных флагов");
            }

            else
            {
                Structure structure = sender as Structure;

                FormPlaceFlag formPlaceFlag = new FormPlaceFlag(form, structure, e.X, e.Y);
                formPlaceFlag.ShowDialog();
            }
        }
    }
}
