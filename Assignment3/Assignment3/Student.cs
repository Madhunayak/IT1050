using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Student
    {
        private String Name;
        private int Grade=0;
        private Instructor Teacher;


        public Student(string Studentname , Instructor Teacher1)
        {
            this.Name = Studentname;
            this.Teacher = Teacher1;
        }

        public void Setgrade(int SGrade)
        {
            this.Grade = SGrade;
        }

        public void PrintStudentInfo()
        {
            System.Console.WriteLine("Student Name: " + this.Name + " Grade: " + this.Grade + Teacher.PrintInstructorInfo());
            
        }

    }
}
