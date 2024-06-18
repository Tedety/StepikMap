using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static StepikMap.FlagColor;

namespace StepikMap
{
    public enum FlagColor
    {
        Red, 
        Green,
        Blue, 
        Pink,
        Cyan,
        Dark,
        Yellow,
        DarkGreen,
        Violet,
        Orange
    }
    public partial class Flag : PictureBox
    {
        protected Form form;
        public static List<Flag> CheckPointFlags = new List<Flag>();

        private readonly Dictionary<FlagColor, string> FlagsColor = new Dictionary<FlagColor, string>()
        {
            { Red , @"Images\FlagRed.png" },
            { Blue , @"Images\FlagBlue.png" },
            { Pink , @"Images\FlagPink.png" },
            { Green , @"Images\FlagGreen.png" },
            { Cyan , @"Images\FlagCyan.png" },
            { Dark , @"Images\FlagDark.png" },
            { Yellow , @"Images\FlagYellow.png" },
            { DarkGreen , @"Images\FlagDarkGreen.png" },
            { Violet , @"Images\FlagViolet.png" },
            { Orange , @"Images\FlagOrange.png" },
        };

        public Flag(int x, int y, Form form)
        {
            Left = x;
            Top = y;
            this.form = form;
            Load(FlagsColor[Red]);
            SizeMode = PictureBoxSizeMode.StretchImage;
            BackColor = Color.Transparent;
            Width = 32;
            Height = 32;
            form.Controls.Add(this);
        }

        public static void BringToUpFlags()
        {
            foreach (Flag flag in CheckPointFlags)
            {
                flag.UpdateZOrder();
            }
        }
    }
}
