using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static StepikMap.FlagColor;
using static StepikMap.Student;


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
        Orange,
        Purple
    }
    public partial class Flag : PictureBox
    {
        protected Form form;
        public static List<Flag> CheckPointFlags = new List<Flag>();
        public static List<List<Flag>> StudentsFlags = new List<List<Flag>>();

        public const int Radius = 60;

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
            { Purple , @"Images\FlagPurple.png" }
        };

        public Flag(int x, int y, Form form, FlagColor flagColor = Red)
        {
            Left = x;
            Top = y;
            this.form = form;
            Load(FlagsColor[flagColor]);
            SizeMode = PictureBoxSizeMode.StretchImage;
            BackColor = Color.Transparent;
            Width = 32;
            Height = 32;
            form.Controls.Add(this);
            Parent = form;
        }

        public static void PlaceAroundFlag(int index)
        {
            int countCheckPointStudents = CountCheckPointStudents(index);

            if (countCheckPointStudents > 0)
            {
                int angle = 360 / countCheckPointStudents;

                int placedStudentsFlags = 0;

                for (int i = 0; i < countCheckPointStudents; i++)
                {
                    var student = Students[i];
                    int currentAngle = placedStudentsFlags * angle;

                    double cos = Math.Cos(currentAngle);
                    double sin = Math.Sin(currentAngle);

                    if (!((currentAngle >= 0 && currentAngle <= 90) || (currentAngle >= 270 && currentAngle <= 360)))
                    {
                        cos = -cos;
                    }

                    if (!(currentAngle >= 0 && currentAngle <= 180))
                    {
                        sin = -sin;
                    }

                    if (student.Points[index] > 0)
                    {
                        int x = Convert.ToInt32(CheckPointFlags[index].Left + Radius * cos);
                        int y = Convert.ToInt32(CheckPointFlags[index].Top + Radius * sin);

                        var newFlag = new Flag(x, y, CheckPointFlags[index].form, student.Color);
                        newFlag.Parent = CheckPointFlags[index].form;

                        while (StudentsFlags.Count <= index)
                        {
                            StudentsFlags.Add(new List<Flag>());
                        }
                        StudentsFlags[index].Add(newFlag);
                        newFlag.BringToFront();
                        placedStudentsFlags++;
                    }

                }
            }
        }

        public static int CountCheckPointStudents(int index)
        {
            int count = 0;

            foreach (var student in Students)
            {
                if (student.Points[index] > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
