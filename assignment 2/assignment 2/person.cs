namespace assignment_2
{
    class person
    {
        

        public string firstname, lastname,spousefirstname;
         public int age,spouseage;
        public static double sumofallages;
        public static int p1 = 0;
        
        

            public void getinformation()
        {
            System.Console.WriteLine("Enter ur first name  ");
            this.firstname = System.Console.ReadLine();
            System.Console.WriteLine("Enter ur lastname ");
            this.lastname = System.Console.ReadLine();
            System.Console.WriteLine("Enter ur age ");
            this.age =int.Parse( System.Console.ReadLine());
            System.Console.WriteLine("Enter ur spouse firstname ");
            this.spousefirstname = System.Console.ReadLine();
            System.Console.WriteLine("Enter ur spouseage ");
            this.spouseage = int.Parse(System.Console.ReadLine());

        }

        public double totalages()
        {
            int totalage = this.age + this.spouseage;
            return totalage;
        }
        public string getfullname()
        

        {
            return this.firstname + "   " + this.lastname;
             

        }
        public string spousefullName()
        {
            return this.spousefirstname + "  " + this.lastname;

        }

       
        public void printNameandAge()
        {
            p1++;
            System.Console.WriteLine("person"+p1+"'s "+"name is : " + this.getfullname());
            System.Console.WriteLine("person"+p1+"'s "+" age is : " + this.age);
            System.Console.WriteLine("person"+p1+"'s "+" spouse name is : " + this.spousefullName());
            System.Console.WriteLine("perrson" + p1 + "'s " + "spouse age is : " + this.spouseage + "\n");

        }
        
            
        }
        
    
}
