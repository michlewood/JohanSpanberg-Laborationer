using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4___BBOB
{
    public class UsedMotorCycle : StockUsed
    {
        public UsedMotorCycle(int price, int year, string manufacturer, string model, int amountOfPreviousOwners, int amount) : base(price, year, manufacturer, model, amountOfPreviousOwners, amount)
        {
        }
        public override string Presentation()
        {
            string basePresentation = base.Presentation();
            return String.Format("(MC) {0}", basePresentation);
        }
    }

    public class ForSaleUsedMotorCycle : ForSaleStockUsed
    {
        public ForSaleUsedMotorCycle(int price, int year, string manufacturer, string model, int amountOfPreviousOwners, int amount) : base(price, year, manufacturer, model, amountOfPreviousOwners, amount)
        {
        }
        public override string Presentation()
        {
            string basePresentation = base.Presentation();
            return String.Format("(MC) {0}", basePresentation);
        }
    }
}