﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static StepikMap.Student;

namespace StepikMap
{
    public partial class FormReadData : Form
    {
        public string[] ReadenData;
        double[] points;

        public FormReadData()
        {
            InitializeComponent();
            labelError.ForeColor = Color.Red;
        }

        private void buttonReadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            textPath.Text = openFileDialog.FileName;
            ReadenData = File.ReadAllLines(textPath.Text);

            int cnt = 1;
            foreach (string student in ReadenData)
            {
                string[] splitedStudent = student.Split(new char[] { ',' });
                string name = splitedStudent[0];
                string surname = splitedStudent[1];

                points = new double[splitedStudent.Length - 2];

                for (int i = 0; i < points.Length; i++)
                {
                    string point = splitedStudent[i + 2].Replace('.', ',');
                    points[i] = Convert.ToDouble(point);
                }

                Students.Add(new Student(name, surname, points, (FlagColor)cnt));
                cnt++;
                if (cnt == 7) break;
            }

            FormMap.FreeFlags = points.Length;
            FormMap.labelFreeFlags_Count();

            Close();
        }
    }
}
