using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4___BBOB
{
    public class UsedCar : StockUsed
    {
        public UsedCar(int price, int year, string manufacturer, string model, int amountOfPreviousOwners, int amount) : base(price, year, manufacturer, model, amountOfPreviousOwners, amount)
        {
        }
        public override string Presentation()
        {
            string basePresentation = base.Presentation();
            return String.Format("(Bil) {0}", basePresentation);
        }
    }

    public class ForSaleUsedCar : ForSaleStockUsed
    {
        public ForSaleUsedCar(int price, int year, string manufacturer, string model, int amountOfPreviousOwners, int amount) : base(price, year, manufacturer, model, amountOfPreviousOwners, amount)
        {
        }
        public override string Presentation()
        {
            string basePresentation = base.Presentation();
            return String.Format("(Bil) {0}", basePresentation);
        }
    }
}