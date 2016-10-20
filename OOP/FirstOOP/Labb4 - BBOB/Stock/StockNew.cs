using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4___BBOB
{
    public abstract class StockNew : TotalStock
    {
        public StockNew(int price, int year, string manufacturer, string model, int warrantyPeriod, int amount) : base(price, year, manufacturer, model, amount)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        public int WarrantyPeriod { get; set; }

        public override string Presentation()
        {
            string basePresentation = base.Presentation();
            return String.Format("{0} {1} års garanti.", basePresentation, WarrantyPeriod);
        }

    }

    public abstract class ForSaleStockNew : ForSaleTotalStock
    {
        public ForSaleStockNew(int price, int year, string manufacturer, string model, int warrantyPeriod, int amount) : base(price, year, manufacturer, model, amount)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        public int WarrantyPeriod { get; set; }

        public override string Presentation()
        {
            string basePresentation = base.Presentation();
            return String.Format("{0} {1} års garanti.", basePresentation, WarrantyPeriod);
        }

    }
}