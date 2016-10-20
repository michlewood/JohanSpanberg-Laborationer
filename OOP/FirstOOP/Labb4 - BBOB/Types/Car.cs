using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4___BBOB
{
    public class Car : StockNew
    {
        public Car(int price, int year, string manufacturer, string model, int warrantyPeriod, int amount) : base(price, year, manufacturer, model, warrantyPeriod, amount)
        {
        }
        public override string Presentation()
        {
            string basePresentation = base.Presentation();
            return String.Format("(Bil) {0}", basePresentation);
        }
    }

    public class ForSaleCar : ForSaleStockNew
    {
        public ForSaleCar(int price, int year, string manufacturer, string model, int warrantyPeriod, int amount) : base(price, year, manufacturer, model, warrantyPeriod, amount)
        {
        }
        public override string Presentation()
        {
            string basePresentation = base.Presentation();
            return String.Format("(Bil) {0}", basePresentation);
        }
    }
}