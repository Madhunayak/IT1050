namespace assignment_2
{
    class person
    {


        public string firstname, lastname;
            public int age;
        public person spouse;
      public static double sumofallages;
        public static int p = 0;
        public string spousename;
        
        
        

            public string getfullname()
        {
            //System.Console.WriteLine("Enter ur first name  ");
           // this.firstname = System.Console.ReadLine();
           // System.Console.WriteLine("Enter ur lastname ");
           // this.lastname = System.Console.ReadLine();
           
           // System.Console.WriteLine("Enter ur age ");
            //this.age =int.Parse( System.Console.ReadLine());
            return this.firstname + " " + this.lastname;
        }


        public void printNameandAge()
        {
            p++;
            System.Console.WriteLine("person" + p + "'s " + "name is : " + this.getfullname());
            System.Console.WriteLine("person" + p + "'s " + " age is : " + this.age);
            System.Console.WriteLine("person" + p + "'s " + "spouse name is : " +this.spousename);
            System.Console.WriteLine("person" + p + "'s " + "spouse age is : " + this.spouse.age);

        }

    }  
        
            
        }
        
    

