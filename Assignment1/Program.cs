using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_no_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Firstname;
            string Middleinitial;
            string Lastname;
            System.Console.Write("Enter your First name:- ");
                    Firstname = System.Console.ReadLine();
            System.Console.Write("Enter your Middleinitial:-  ");
            Middleinitial =  System.Console.ReadLine();
            System.Console.Write("Enter your Last name:- ");
            Lastname = System.Console.ReadLine();
            String Fullname;
            Fullname =  Firstname  +" " + Middleinitial +"." +  Lastname + "\n";
            System.Console.Write("your full name is --  "+ Fullname+"\n"+"\n");


            int Heightfeet;
            System.Console.Write("What is your height in feet: ");
            Heightfeet = int.Parse(System.Console.ReadLine());
            double Hieghtinches;
            System.Console.Write("How many inches beyond your base height in feet to add to your height: ");
            Hieghtinches = double.Parse(System.Console.ReadLine());
            double Totalheightcm;
            Totalheightcm = ((Heightfeet * 12) + Hieghtinches)*2.54;
            System.Console.Write("Your total height in cm is :-- "+Totalheightcm +"cm"+"\n"+"\n");
            System.Console.Write("What is your age:--");
            int Age;
            Age= int.Parse(System.Console.ReadLine());
            bool Iscitizen;
            System.Console.Write("you r citizen of USA -(true or false):---");
             Iscitizen= bool.Parse(System.Console.ReadLine());
            bool Canvote;
            Canvote = Age >= 18 && Iscitizen == true;
            System.Console.Write("You can vote:   " + Canvote+"\n"+"\n");


            System.Console.Write("press any key to continue:...");
            System.Console.ReadKey();

                   }
    }
}
