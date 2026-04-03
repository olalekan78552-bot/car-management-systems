using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Management_Systems
{
    public class Car : Automobile
    {
        private int _door;
        public int Door
        {
            get { return _door; }
            set { if(value != 2 && value != 4)
                {
                    throw new Exception(); 
                }

                _door = value;

            }

        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Door: {Door} door");
            Console.WriteLine($"Mileage: {Mileage} miles");
            Console.WriteLine($"Price: ${Price}");
        }


    }
}
