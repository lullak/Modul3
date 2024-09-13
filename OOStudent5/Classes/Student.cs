﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStudent5.Classes
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string SecurityNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Student(string firstName, string surname, string securityNumber, string phone, string email)
        {
            FirstName = firstName;
            Surname = surname;
            SecurityNumber = securityNumber;
            Phone = phone;
            Email = email;
        }

        public bool ControlValues()
        {
            if (String.IsNullOrEmpty(FirstName) || String.IsNullOrEmpty(Surname) || String.IsNullOrEmpty(SecurityNumber)
                || String.IsNullOrEmpty(Phone) || String.IsNullOrEmpty(Email))
            { 
                return false; 
            }
            return true;
        }
        public string[] GetGrades()
        {
            string[] grades = { "Programmering C#\t\tG", "ASP.NET med C#\t\t\tVG", "Frontend utveckling\t\tVG" };
            return grades;
        }
    }
}
