using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            show person = new show();
            person.getcostumerinput();
            person.ticketcostcalculation();
           

            System.Console.WriteLine("Do u want to buy anything : Answer with Y or N");

            string input = System.Console.ReadLine();
            if (input == "Y")
            {
                person.getinputforconcessionstand();

                double totalvalue = person.calculateconcessioncost(count1, count2, count3, count4, count5);
                System.Console.WriteLine("concession buy total value is:" + totalvalue);

            }
            else { System.Console.WriteLine("thank u");

            }

            System.Console.WriteLine("calculate total expence");
            if()

            System.Console.WriteLine("press any key to continue");
            System.Console.ReadKey();
        

            





    }
    }
}
