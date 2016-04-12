using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3
{
    class Instructor1
    {
      
        
            private String Name;
            private String CourseName;


            public Instructor1(string TName, string TcourseName)
            {
                this.Name = TName;
                this.CourseName = TcourseName;

            }
            public void SetStudentGrade(Student1 Student2, int Grade1)
            {
                Student2.Setgrade(Grade1);
            }

            public string PrintInstructorInfo()
            {
                return (" Instructor Name: -" + this.Name + " Course Name:- " + this.CourseName);
            }
        }
    }


