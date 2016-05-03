using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class student
    {
        private string Name;
        private int No;
        //private int studentcount;

      
        


        public static string  inputstudentsno(string p)
        {
            System.Console.WriteLine(p);
            return System.Console.ReadLine();
        }


        public  static int  noofstudents(string p)
        {
            return int.Parse(inputstudentsno(p));
        }
        
    
        public void studentinfo()
        { System.Console.WriteLine("Enter student name:   " );
            this.Name = System.Console.ReadLine();
            System.Console.WriteLine("enter student no:   "  );
            this.No = int.Parse(System.Console.ReadLine());
        }

        public  void  printstudentname()
        {
           System.Console.WriteLine("student name:   " +this.Name );
        System.Console.WriteLine(" student no:   " + this .No );
        }
    }

}
