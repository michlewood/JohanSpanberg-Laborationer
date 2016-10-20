using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4___BBOB
{
    public abstract class TotalStock
    {
        public int Price { get; set; }

        public int Year { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Amount { get; set; }

        public TotalStock(int price, int year, string manufacturer, string model, int amount)
        {
            Price = price;
            Year = year;
            Manufacturer = manufacturer;
            Model = model;
            Amount = amount;
        }

        public virtual string Presentation()
        {
            return String.Format("{0} kr - {1} - {2} {3}. {4} i lager.", Price, Year, Manufacturer, Model, Amount);
        }
    }

    public abstract class ForSaleTotalStock
    {
        public int Price { get; set; }

        public int Year { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Amount { get; set; }

        public ForSaleTotalStock(int price, int year, string manufacturer, string model, int amount)
        {
            Price = price;
            Year = year;
            Manufacturer = manufacturer;
            Model = model;
            Amount = amount;
        }

        public virtual string Presentation()
        {
            return String.Format("{0} kr - {1} - {2} {3}. {4} i lager.", Price, Year, Manufacturer, Model, Amount);
        }
    }
}