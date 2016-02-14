using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            long Salary;
            System.Console.WriteLine("what is ur salary  :  ");
            Salary = long.Parse(System.Console.ReadLine());
            System.Console.WriteLine("your salary is:" + Salary);

            System.Console.WriteLine("press any key to continue");
            System.Console.ReadKey();


        }
    }
}
