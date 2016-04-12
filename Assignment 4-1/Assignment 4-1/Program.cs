using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_1
{
    class Program
    {
        static void Main(string[] args)

        {
            double Totalconcessionexpence = 0;
            movie Person = new movie();
                Person.getcostumerinput();
            double Ticketexpence = Person.ticketcostcalculation();
            System.Console.WriteLine("total ticket expence is" +Ticketexpence );

            System.Console.WriteLine("Do u want to buy anything : Answer with Y or N");

                string input = System.Console.ReadLine();

            if (input == "Y"||input=="y")
                {
                    Person.getinputforconcessionstand();
                    Totalconcessionexpence = Person.calculateconcessioncost();
                    System.Console.WriteLine("concession buy total value is:" + Totalconcessionexpence);

                }
                else {
                    System.Console.WriteLine("thank u");

                }

              
            double Totalexpence = Ticketexpence  + Totalconcessionexpence - Person.promotion();
            System.Console.WriteLine("your  total expence is now:  "+Totalexpence);

            System.Console.WriteLine("press any key to continue");
                System.Console.ReadKey();



        
    

}
    }
}
