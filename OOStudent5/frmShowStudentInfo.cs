﻿using OOStudent5.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOStudent5
{
    public partial class frmShowStudentInfo : Form
    {
        public frmShowStudentInfo(Student student)
        {
            InitializeComponent();
            label1.Text = student.FirstName;
            label2.Text = student.Surname;
            label3.Text = student.SecurityNumber;
            label4.Text = student.Phone;
            label5.Text = student.Email;
        }
    }
}
