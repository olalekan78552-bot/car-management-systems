using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Management_Systems
{

    // Automobile Base Class
    public abstract class Automobile : IAutomobile
    {
        private string _make;
        private string _model;
        private int _mileage;
        private decimal _price;
        // Base Class fields
        public string Make
        {
            get { return _make; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception();
                }

                _make = value;
            }
        }
        public string Model
        {
            get { return _model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception();
                }

                _model = value;

            }
        }
        

        // decimal property
        // if price is less than zero
        // throw an exception
        // otherwise, set price to value
        public decimal Price
        {
            get { return _price; }
            set { 
                    if (value <= 0)
                    {
                        throw new Exception();
                    }

                _price = value;

            }
        }

        // mileage property
        // if mileage is less than 0
        // throw an exception
        // otherwise set mileage to value
        public int Mileage
        {
            get { return _mileage; }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }

                _mileage = value;
            }
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Mileage: {Mileage} miles");
            Console.WriteLine($"Price: ${Price}");
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public string GetName()
        {
            return Make + " " + Model;
        }
    }
}
