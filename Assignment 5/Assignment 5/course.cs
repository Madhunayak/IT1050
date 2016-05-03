using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class course
    {
        private string CName;
        private int Crn;
       
    

        public void  createcourse()
        {
            System.Console.WriteLine("Enter course name:   ");
            this.CName =System.Console.ReadLine();
            System.Console.WriteLine(" Enter CRN :  ");
                this.Crn =int.Parse(System .Console .ReadLine ());

        }
      public  void printcourse(student s)
        {
            
            System.Console.WriteLine("course name   " + this.CName);
            System.Console.WriteLine("CRN is   " + this.Crn);
            s.printstudentname();


        }


    }
}
