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
        }
    }
}
