namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("MIKE", "Math");

            Student Jane = new Student("Jane", John);
            Student Joe = new Student("Joe", John);

            Student Melissa = new Student("Melissa", Mike);
            Student Matt = new Student("Matt", Mike);

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
