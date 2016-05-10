using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupant;

     
        public Elevator (int maxOccupant,double  maxWeight)
        {
            Occupant = new Passenger[maxOccupant];

            this.MaxWeight = maxWeight;
          
        }

        public void AddOccupant(Passenger passenger, int index)
        {

            Occupant[index] = passenger;
        }
        public double GetCurrentWeight()
        {
            double wt = 0;
            foreach (Passenger p in Occupant)
            {
              wt=wt+ p.GetWeight();
            }
            return wt;
         }

        public bool IsOverMaxCapacity()
        {
            
            if (GetCurrentWeight() > MaxWeight)
            { return true; }
            else { return false; }
        }
    }
}
