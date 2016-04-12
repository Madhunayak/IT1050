
namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageage;
            person.sumofallages = 0;
            
            person p1 = new person();
            p1.spouse = new person();
          

            System.Console.WriteLine("           (Enter information for p1 )");
            p1.getinformation();
            System.Console.WriteLine("           (Enter information for p2 )");
            person p2 = new person();
            p2.spouse = new person();
            p2.getinformation();
          
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
 