using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Management_Systems
{
    public interface IAutomobile
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public decimal Price { get; set; }

        public void DisplayInfo();        
        public decimal GetPrice();
        public string GetName();
    }
}
