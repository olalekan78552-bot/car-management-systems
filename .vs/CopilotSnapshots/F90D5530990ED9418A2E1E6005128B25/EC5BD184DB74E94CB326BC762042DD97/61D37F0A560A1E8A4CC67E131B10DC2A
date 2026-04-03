using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace Car_Management_Systems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAutomobile> inventory = new List<IAutomobile>();
            
            bool runProgram = true;

            Console.WriteLine($"Welcome to the dealership center.");
            Console.WriteLine($"---------------------------------");

            while (runProgram)
            {
                Console.WriteLine("\nChoose the operation you will like to perform.\n");
                Console.Write("1. Add Car\n2. Add Truck\n3. Display Inventory\n4. Sell car\n5. Total Value of current Inventory\n6. Exit.\n\nSelect an Option: ");

                int answer;
                while (!int.TryParse(Console.ReadLine(), out answer) || answer <= 0 || answer > 6)
                {
                    Console.Write("Enter a valid number: ");
                }

                switch (answer)
                {
                    case 1:
                        AddCar(inventory);
                        break;

                    case 2:
                        AddTruck(inventory);
                        break;

                    case 3:
                        DisplayInventory(inventory);
                        break;

                    case 4:
                        SellCar(inventory);
                        break;

                    case 5:
                        TotalValue(inventory);
                        break;

                    case 6:
                        runProgram = false;
                        break;

                    default:
                        break;
                }
            }            
        }

        public static void GetMake(IAutomobile automobile)
        {
            string make;

            bool valid = false;

            while(!valid)
            {
                Console.Write($"Enter car make: ");
                make = Console.ReadLine();
                try
                {                                       
                    automobile.Make = make;
                    valid = true;

                }

                catch (Exception)
                {
                    Console.WriteLine("Make cannot be empty.");
                }
            }
        }

        public static void GetModel(IAutomobile automobile)
        {
            string model;
            bool valid = false;

            while(!valid)
            {
                Console.Write($"Enter car Model: ");
                model = Console.ReadLine();

                try
                {
                    automobile.Model = model;
                    valid = true;
                }

                catch (Exception)
                {
                    Console.WriteLine($"Model cannot be empty.");
                }
            }
        }

        public static void GetDoor(IAutomobile automobile)
        {
            Car car = (Car)automobile;
            int door;
            bool valid = false;

            while (!valid)
            {
                Console.Write($"Enter number of doors: ");
                try
                {

                    while (!int.TryParse(Console.ReadLine(), out door))
                    {
                        Console.Write($"Invalid Entry\nEnter number of doors: ");
                    }
                    car.Door = door;
                    valid = true;
                }

                catch (Exception)
                {
                    Console.WriteLine("Door must be 2 or 4");
                }
            }

        }

        public static void GetPrice(IAutomobile automobile)
        {
            decimal price;
            bool valid = false;

            while(!valid)
            {
                Console.Write($"Enter car price: ");
                try
                {
                    while (!decimal.TryParse(Console.ReadLine(), out price))
                    {
                        Console.Write($"Invalid Enry\nEnter car price: ");
                    }

                    automobile.Price = price;
                    valid = true;

                }

                catch(Exception)
                {
                    Console.WriteLine($"Price cannot be less than or equal to zero");
                }
            }
        }

        public static void GetMileage(IAutomobile automobile)
        {
            int mileage;
            bool valid = false;

            while(!valid)
            {
                Console.Write($"Enter car mileage: ");
                try
                {
                    
                    while (!int.TryParse(Console.ReadLine(), out mileage))
                    {
                        Console.Write($"Invalid Entry\nEnter car mileage: ");
                    }

                    automobile.Mileage = mileage;
                    valid = true;
                }

                catch (Exception)
                {
                    Console.WriteLine($"Mileage canot be less than zero.");
                }
            }

        }

        public static void GetDrive(IAutomobile automobile)
        {

            bool valid = false;
            Truck truck = (Truck)automobile;

            while(!valid)
            {
                Console.Write($"Enter drive type. 2WD for 2 wheel drive | 4WD for 4 wheel | AWD for All wheel drive\nEnter: ");
                string drive = Console.ReadLine();
                try
                {
                    truck.Drive = drive;
                    valid = true;

                }
                catch(Exception)
                {
                    Console.WriteLine($"Enter a valid drive type.");
                }
            }

        }

        // Add Car Method
        static void AddCar(List<IAutomobile> inventory)
        {
            Car car = new Car();

            Console.WriteLine($"\n<<<<Add a New Car>>>>");

            GetMake(car);
            GetModel(car);
            GetDoor(car);
            GetPrice(car);
            GetMileage(car);

            inventory.Add(car);
            Console.WriteLine($"\nCar has been added to inventory.");
            
        }

        //Add truck Method         
        static void AddTruck(List<IAutomobile> inventory)
        {
            Truck truck = new Truck();

            Console.WriteLine($"\n<<<<Add a Truck>>>>");

            GetMake(truck);
            GetModel(truck);
            GetDrive(truck);
            GetPrice(truck);
            GetMileage(truck);

            inventory.Add(truck);
            Console.WriteLine($"\nCar has been added to inventory.");
        }

        // display inventory
        public static void DisplayInventory(List<IAutomobile> inventory)
        {
            Console.WriteLine($"<<<<Inventory>>>>\n");
            if (inventory.Count == 0)
            {
                Console.WriteLine($"There is no vehicle in Inventory.");
                return;
            }
            foreach (IAutomobile automobile in inventory)
            {
                Console.WriteLine();
                automobile.DisplayInfo();
            }
        }

        public static void SellCar(List<IAutomobile> inventory)
        {
            Console.WriteLine($"\n<<<<Current Inventory>>>>");

            if (inventory.Count == 0)
            {
                Console.WriteLine($"\nWe are currently out of vehicles\n");
                return;
            }

            if (inventory.Count != 0)
            {
                int number = 1;
                foreach (IAutomobile autoName in inventory)
                {                    
                    Console.Write(number + ". " + autoName.GetName() + "\n");
                    number++;
                }

                int carNumber;
                Console.Write("Select the vehicle number: ");
                while(!int.TryParse(Console.ReadLine(), out carNumber) || carNumber <= 0 || carNumber > inventory.Count)
                {
                    Console.Write($"Invalid Entry\nSelect vehicle Number: ");
                }

                carNumber = carNumber - 1;
                
                IAutomobile selectedCar = inventory[carNumber];
                Console.WriteLine();
                selectedCar.DisplayInfo();

                Console.Write($"Do you want to continue with purchase: Y/N: ");
                string answer = Console.ReadLine().Trim().ToLower();

                while (!string.Equals(answer, "Y", StringComparison.OrdinalIgnoreCase) && !string.Equals(answer, "N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write($"Enter Y/N for answer: ");
                    answer = Console.ReadLine();

                }
                if (string.Equals(answer, "Y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Car sold");
                }

                else
                {
                    return;
                }
                inventory.Remove(selectedCar); 
            }
        }

        // total Inventory
        public static void TotalValue(List<IAutomobile> inventory)
        {
            decimal total = 0;
            
            foreach(IAutomobile automobile in inventory)
            {
                total += automobile.GetPrice();
            }

            Console.WriteLine($"Total inventory is ${total}");
        }

        
    }
}
