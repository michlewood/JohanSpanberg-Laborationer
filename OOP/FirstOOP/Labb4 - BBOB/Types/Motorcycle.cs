using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4___BBOB
{
    public class Motorcycle : StockNew
    {
        public Motorcycle(int price, int year, string manufacturer, string model, int warrantyPeriod, int amount) : base(price, year, manufacturer, model, warrantyPeriod, amount)
        {
        }
        public override string Presentation()
        {
            string basePresentation = base.Presentation();
            return String.Format("(MC) {0}", basePresentation);
        }
    }
}