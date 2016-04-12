
namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageage;
            person.sumofallages = 0;
            //string spousename;
            person p1 = new person();
            p1.spouse = new person();
            bool ans;

            System.Console.WriteLine("           (Enter information for p1 )");
            System.Console.WriteLine("First name? ");
            p1.firstname = System.Console.ReadLine();
            System.Console.WriteLine("Last name? ");
            p1.lastname = System.Console.ReadLine();
            System.Console.WriteLine("Age? ");
            p1.age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("what is ur marrital status : married?");
            ans = bool.Parse(System.Console.ReadLine());
            if (ans == true)
            {
                System.Console.WriteLine("spouse First name? ");
                p1.spouse.firstname = System.Console.ReadLine();
                System.Console.WriteLine("spouse Age? ");
                p1.spouse.age = int.Parse(System.Console.ReadLine());
                p1.spousename = p1.spouse.firstname + " " + p1.lastname;
                    
            }
            else
            { p1.spousename = "no spouse";

            }

            person p2 = new person();
            p2.spouse = new person();
            System.Console.WriteLine("           (Enter information for p2)");
            System.Console.WriteLine("First name? ");
            p2.firstname = System.Console.ReadLine();
            System.Console.WriteLine("Last name? ");
            p2.lastname = System.Console.ReadLine();
            System.Console.WriteLine("enter ur age");
            p2.age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("what is ur marrital status : married?");
            ans = bool.Parse(System.Console.ReadLine());
            if (ans == true)
            {
                System.Console.WriteLine("spouse First name? ");
                p2.spouse.firstname = System.Console.ReadLine();
                System.Console.WriteLine("spouse Age? ");
                p2.spouse.age = int.Parse(System.Console.ReadLine());
                p2.spousename = p2.spouse.firstname + " " + p2.lastname;
            }
            else
            {
                p2.spousename = "no spouse";

            }
          
            person.sumofallages =p1.age+p1.spouse.age+p2.age+p2.spouse.age;

            averageage = person.sumofallages / 4;


            System.Console.WriteLine("           ( Print persons and spouse's name and age)"+"\n");
            p1.printNameandAge();
            p2.printNameandAge();
            System.Console.WriteLine("total age is:  "+person.sumofallages);
            System.Console.WriteLine("average age is:  " + averageage);
            System.Console.WriteLine("press any key to continue");
            System.Console.ReadKey();
        }
    }
}
 