﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        string name, major;
        double gpa;

        public Student(string aName, string aMajor, double aGpa) 
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }
        public bool HasHonors()
        { 
            if (gpa >= 3.5)
            {
                return true;
            } else { return false; }
        }
    }
}
