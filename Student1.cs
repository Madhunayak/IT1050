using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3
{
    class Student1
    {
       
            private String Name;
            private int Grade = 0;
            private Instructor1 Teacher;


            public Student1(string Studentname, Instructor1 Teacher1)
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
                System.Console.WriteLine("Student Name:- " + this.Name + " Grade:- " + this.Grade +"   "+ Teacher.PrintInstructorInfo());

            }

        }
    }


