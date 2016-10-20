using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4___BBOB
{
    class Economy
    {
        private double totalAmountOfCash = 5000000;

        public double TotalAmountOfCash
        {
            get { return totalAmountOfCash; }
            set { totalAmountOfCash = value; }
        }

        public void IncomingBid()
        {
            
        }
        
        public double RandomizedBid(double minimum, double maximum)
        {
            Random bidGenerator = new Random();

            return bidGenerator.NextDouble() * (maximum - minimum) + minimum;
        }

        public int RandomizedNumberOfOffers(int minimum, int maximum)
        {
            Random numberOfOffersGenerator = new Random();

            return numberOfOffersGenerator.Next(minimum, maximum);
        }

    }
}
