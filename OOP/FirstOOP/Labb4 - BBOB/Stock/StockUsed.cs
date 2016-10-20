using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4___BBOB
{
    public abstract class StockUsed : TotalStock
    {
        public StockUsed(int price, int year, string manufacturer, string model, int amountOfPreviousOwners, int amount) : base(price, year, manufacturer, model, amount)
        {
            AmountOfPreviousOwners = amountOfPreviousOwners;
        }

        public int AmountOfPreviousOwners { get; set; }

        public override string Presentation()
        {
            string basePresentation = base.Presentation();
            return String.Format("{0} {1} tidigare ägare.", basePresentation, AmountOfPreviousOwners);
        }
    }
}