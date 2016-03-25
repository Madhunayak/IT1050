using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Instructor
    {
        private String Name;
        private String CourseName;


        public Instructor(string TName,string TcourseName)
        { this.Name = TName;
            this.CourseName = TcourseName;

        }
        public void SetStudentGrade(Student Student1, int Grade1)
        {
            Student1.Setgrade(Grade1);
        }

        public string PrintInstructorInfo ()
        {
          return (" Instructor Name: " + this.Name + " Course Name: " + this.CourseName);
        }
    }
}
