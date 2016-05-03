using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            course[] c = new course[10];

            int i = 0;
            string input = "again";
            string ans = "y";
            while (ans == "y")
            {
                int t = 0;

               

                while (input == "again")
                {
                    
                    c[i] = new course();
                    c[i].createcourse();
                    int count = student.noofstudents("how many students in ur class:   ");

                    student[] s = new student[count];
                    for (int j = 0; j < count; j++)
                    {
                        s[j] = new student();
                        s[j].studentinfo();
                    }
                    for (t = 0; t <count ; t++)
                    {
                        c[i].printcourse(s[t]);
                     }
                    System.Console.WriteLine("Is this correct? Y or N ");
                    string input1 = System.Console.ReadLine();
                    if (input1 == "n")
                    {
                       
                       System.Console.WriteLine("enter data again:  ");
                        input = "again";
                    }
                    else
                    {
                        input = "done";
                   
                    }
                    
                }

                System.Console.WriteLine("do  u want to create  new course again? Y or N");
                ans= System.Console.ReadLine();
                if (ans == "y") { i++; input = "again"; }

            }
          
            System.Console.ReadKey();
        }
    }
}
