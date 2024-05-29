﻿using System.Drawing;
using System.Windows.Forms;

namespace StepikMap
{
    public partial class PictureBoxFlag : PictureBox
    {
        private Graphics g;
        protected Form form;

        public PictureBoxFlag(int x, int y, Form form)
        {
            this.Left = x;
            this.Top = y;
            g = form.CreateGraphics();
            this.form = form;
            this.Load(@"Images\RedFlag2.png");
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.Transparent;
            this.Width = 32;
            this.Height = 32;
            form.Controls.Add(this);
        }
    }
}
