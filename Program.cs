
namespace Test_3
{
    class Program
    {
      
            static void Main(string[] args)
            {
                Instructor1 John = new Instructor1("John", "English");
                Instructor1 Mike = new Instructor1("MIKE", "Math");

                Student1 Jane = new Student1("Jane", John);
                Student1 Joe = new Student1("Joe", John);

                Student1 Melissa = new Student1("Melissa", Mike);
                Student1 Matt = new Student1("Matt", Mike);

                John.SetStudentGrade(Jane, 95);
                John.SetStudentGrade(Joe, 85);
                Mike.SetStudentGrade(Melissa, 90);
                Mike.SetStudentGrade(Matt, 92);

                Jane.PrintStudentInfo();
                Joe.PrintStudentInfo();
                Melissa.PrintStudentInfo();
                Matt.PrintStudentInfo();

                System.Console.WriteLine();
                System.Console.ReadKey();


            }
        }
    }
    

