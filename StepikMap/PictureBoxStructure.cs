using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StepikMap
{
    public class PictureBoxStructure : PictureBox
    {
        public List<Point> listOfPoints {  get; set; }
        private Graphics g;
        protected Form form;
        public PictureBoxStructure(int x, int y, Form form, string path, PictureBox pictureBox)
        {
            this.Left = x;
            this.Top = y;
            g = form.CreateGraphics();
            this.form = form;
            this.Load(path);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.Transparent;
            form.Controls.Add(this);
            this.Parent = pictureBox;
            this.Width += 125;
            this.Height += 100;
        }
    }
}
