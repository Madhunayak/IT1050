using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class show
    {

        string show1;
        int childno;
        double childcost;
        int Adultno;
        double Adultcost;
        int seniorno;
        double seniorcost;
        double totalcost;
        int TotalCount;
        double Mchild=3.99 ;
        double MAdult=5.99 ;
       double MSenior =4.50;
       double EChild = 6.99;
        double EAdult = 10.99;
       double ESenior = 8.50;

      




        public void getcostumerinput()
        {
            System.Console.WriteLine("which show u r going");
            this.show1 = System.Console.ReadLine();
            System.Console.WriteLine("how many children");
            this.childno = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("how many Adults");
            this.Adultno = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("how many Seniors");
            this.seniorno = int.Parse(System.Console.ReadLine());
           
        }


        public double ticketcostcalculation()
        {
            if (this.show1 == "m")
            {
             
                this.totalcost = this.childno * Mchild+ this.Adultno * this.MAdult + this.seniorno * this.MSenior;
                return totalcost;
            }
            else if(this.show1=="E")
            {
                this.totalcost = this.childno * EChild + this.Adultno * this.EAdult + this.seniorno * this.ESenior;
                return totalcost;
            }
            else { System.Console.WriteLine("sorry");
            }

        }
      public void getinputforconcessionstand()
        {
          
            System.Console.WriteLine("small soda no:");
            int count1 = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("large soda no:");
            int count2 = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("hotdog no:");
            int count3 = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("popcorn no:");
            int count4 = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("candy no:");
            int count5 = int.Parse(System.Console.ReadLine());
        }




            public double calculateconcessioncost(int smallsoda,int largesoda,int hotdog,int popcorn,int candy)
             {
            double smallsodavalue = smallsoda * 3.50;
            double largesodavalue = largesoda * 5.99;
            double hotdogvalue = hotdog * 3.99;
            double popcornvalue = popcorn * 4.50;
            double candyvalue = candy * 1.99;
            return  smallsodavalue + largesodavalue + hotdogvalue + popcornvalue + candyvalue;
        }

       public double discount1()
        { if (> 0)

           
        }
            
    }






}
