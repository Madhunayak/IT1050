
namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double  averageage;
            person p1 = new person();
            System.Console.WriteLine("           (Enter information for p1)");
            p1.getinformation();
            
            person p2 = new person();
            System.Console.WriteLine("           (Enter information for p2)");
            p2.getinformation();
            person.sumofallages = p1.totalages()+ p2.totalages() ;
            averageage = person.sumofallages / 4;


            System.Console.WriteLine("           ( Print persons and spouse's name and age)"+"\n");
          
            p1.printNameandAge();
            p2.printNameandAge();
            System.Console.WriteLine("total age is"+person.sumofallages);
            System.Console.WriteLine("average age is" + averageage);
            System.Console.WriteLine("press any key to continue");
            System.Console.ReadKey();
        }
    }
}
