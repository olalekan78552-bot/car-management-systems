using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Management_Systems
{
    public class Truck : Automobile
    {
        private string _drive;

        public string Drive
        {
            get{ return _drive; }

            set {
                _drive = value.Trim().ToLower();
                if (!string.Equals(value, "2WD", StringComparison.OrdinalIgnoreCase) && !string.Equals(value, "4WD", StringComparison.OrdinalIgnoreCase) && !string.Equals(value, "AWD", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception();
                }

                _drive = value;
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Mileage: {Mileage} miles");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Drive Type: {Drive} wheel drive.");
        }


    }
}
