using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StepikMap
{
    public class PictureBoxStructure : PictureBox
    {
        public PictureBoxStructure()
        { }
        public List<Point> listOfPoints { get; set; }
        private Graphics g;
        protected Form form;

        //List<List<int>> allCoordinatesOfStructure;
        public PictureBoxStructure(int x, int y, Form form, string path, PictureBox pictureBox)
        {
            Left = x;
            Top = y;
            g = form.CreateGraphics();
            this.form = form;
            Load(path);
            SizeMode = PictureBoxSizeMode.StretchImage;
            BackColor = Color.Transparent;
            form.Controls.Add(this);
            Parent = pictureBox;
            Width += 125;
            Height += 100;

            //allCoordinatesOfStructure = new List<List<int>>(Height * Width);
            //foreach (var coordinateOfStructure in allCoordinatesOfStructure) { }

            for (int i = x; i < x + Height; i++)
            {
                for (int j = y; j < y + Width; j++)
                {
                    listOfPoints.Add(new Point(i, j));
                }
            }

            public static void pictureBoxStructure_MouseDown(object sender, MouseEventArgs e)
            {

            }
        }
    }
}
