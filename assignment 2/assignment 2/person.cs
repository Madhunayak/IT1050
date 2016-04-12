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
        bool ans;
       
        public void getinformation()

        {
            System.Console.WriteLine("First name? ");
            this.firstname = System.Console.ReadLine();
            System.Console.WriteLine("Last name? ");
            this.lastname = System.Console.ReadLine();
            System.Console.WriteLine("Age? ");
            this.age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("what is ur marrital status : married?");
            ans = bool.Parse(System.Console.ReadLine());
            sumofallages += this.age;

            if (ans == true)
            {
                System.Console.WriteLine("spouse First name? ");
                this.spouse.firstname = System.Console.ReadLine();
                System.Console.WriteLine("spouse Age? ");
                this.spouse.age = int.Parse(System.Console.ReadLine());
                this.spousename = this.spouse.firstname + " " + this.lastname;

            }
            else
            {
                this.age = 0;
                this.spousename = "no spouse";

            }
            sumofallages += this.spouse.age;
        }

        public string getfullname()
        {
            return this.firstname + " " + this.lastname;
           // sumofallages = +this.age;
        }
       // public double sum()
        //{
           // sumofallages +=this.age;
       // }

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
        
    

