﻿using OOStudent5.Classes;

namespace OOStudent5
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        Student student = null;
        public void GetStudent()
        {
            student = new Student(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            GetStudent();
            if (!student.ControlValues())
            {
                MessageBox.Show("Fyll i alla uppgifter.");
                return;
            }
            MessageBox.Show($"Du har fyllt in följande uppgifter: \n{student.FirstName}" +
                $"\n{student.Surname}\n{student.SecurityNumber}\n{student.Phone}\n{student.Email}\nstämmer det?");
        }

        private void buttonGetGrades_Click(object sender, EventArgs e)
        {
            GetStudent();
            if (!student.ControlValues())
            {
                MessageBox.Show("Fyll i alla uppgifter.");
                return;
            }

            string[] grades = student.GetGrades();
            listBoxCourses.Items.Add(grades[0]);
            listBoxCourses.Items.Add(grades[1]);
            listBoxCourses.Items.Add(grades[2]);

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>{textBox1,textBox2,textBox3,textBox4,textBox5};
            for (int i = 0; i < textBoxes.Count; i++)
            {
                textBoxes[i].Text = "";
            }
        }
    }
}
