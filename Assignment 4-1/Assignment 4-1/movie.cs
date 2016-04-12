using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_1
{
    class movie
    {
       

            string show1;
            int childno;
            int Adultno;
            int seniorno;
            double totalcost;
            double Mchild = 3.99;
            double MAdult = 5.99;
            double MSenior = 4.50;
            double EChild = 6.99;
            double EAdult = 10.99;
            double ESenior = 8.50;
        int totalmoviecount;
             int smallsoda;
              int largesoda;
               int hotdog;
             int popcorn;
               int candy;
        double smallsodavalue;
        double largesodavalue;
        double hotdogvalue;
        double popcornvalue;
        double candyvalue;

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
            this.totalmoviecount = childno + Adultno + seniorno;
            if (this.totalmoviecount >= 3)
            {
                System.Console.WriteLine("You will get free popcorn");
            }

        }


        public double ticketcostcalculation()
        {
            if (this.show1 == "m")
            {
                
              
                this.totalcost = this.childno * Mchild + this.Adultno * this.MAdult + this.seniorno * this.MSenior;
                return totalcost; 
               
            } 
                else if (this.show1 == "e")
                {
                
                this.totalcost = this.childno * EChild + this.Adultno * this.EAdult + this.seniorno * this.ESenior;
                    return totalcost;
                }
                else {
                   System.Console.WriteLine("sorry");
                return totalcost = 0;
                }

          
        }
            public void getinputforconcessionstand()
            {

                System.Console.WriteLine("small soda no:");
                this.smallsoda= int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("large soda no:");
               this. largesoda= int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("hotdog no:");
                this. hotdog = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("popcorn no:");
               this. popcorn = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("candy no:");
                 this.candy= int.Parse(System.Console.ReadLine());
            }




            public double calculateconcessioncost()
            {
               this.smallsodavalue = this.smallsoda * 3.50;
              this. largesodavalue = this.largesoda * 5.99;
                this.hotdogvalue = this.hotdog * 3.99;
                this.popcornvalue =this. popcorn * 4.50;
            if (candy == 3)
            {
                int candycount = candy / 3;
                System.Console.WriteLine("You will get" + candycount + "free candies");
                double candyvalue = this.candy * 1.99;
            }
            else if (candy > 3)
            {
                int candycount = candy / 3;
                System.Console.WriteLine("You will get " + candycount + " free candies");
                System.Console.WriteLine("do u want to pay for" + (candy - candycount) + " candies" + "   or  for " + candy + " candies  ?");
                int count = int.Parse(System.Console.ReadLine());
                if (count == (candy - candycount))
                { System.Console.WriteLine("You will get total " + candy + " candies including  "+candycount+"  free candies");
                    candyvalue = count * 1.99; }
                else {
                    System.Console.WriteLine("You will get total " + (candy + candycount) + "including " +candycount+"free candies");
    
                     candyvalue = count * 1.99;
                }
            }
            
            else {
                 candyvalue = candy * 1.99;
                
            }
                return smallsodavalue + largesodavalue + hotdogvalue + popcornvalue + candyvalue;
            }

       public double promotion()
        {
            if (popcorn >= 1 && largesoda >= 1)
            {
                System.Console.WriteLine("U got $2 discount on movie ticket");
                return Math.Min(popcorn, Math.Min(largesoda, totalmoviecount)) * 2;
            }
            return 0;
        }


}
}
