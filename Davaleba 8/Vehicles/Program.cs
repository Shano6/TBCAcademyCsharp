namespace GroundTransportApp
{
    public enum TransportCategory
    {
        Combat,
        Consumer,
        PublicTransport,
        Sports
    }

    public abstract class Vehicle
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public abstract void DisplayInfo();
    }

    public class CombatVehicle : Vehicle
    {
        public int FirePower { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Combat Vehicle - {Name} ({Year})");
            Console.WriteLine($"Fire Power: {FirePower}");
            Console.WriteLine();
        }
    }

    public class ConsumerVehicle : Vehicle
    {
        public int PassengerCapacity { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Consumer Vehicle - {Name} ({Year})");
            Console.WriteLine($"Passenger Capacity: {PassengerCapacity}");
            Console.WriteLine();
        }
    }

    public class PublicTransportVehicle : Vehicle
    {
        public int RouteNumber { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Public Transport Vehicle - {Name} ({Year})");
            Console.WriteLine($"Route Number: {RouteNumber}");
            Console.WriteLine();
        }
    }

    public class SportsVehicle : Vehicle
    {
        public string SportsType { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Sports Vehicle - {Name} ({Year})");
            Console.WriteLine($"Sports Type: {SportsType}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a transport category:");
                Console.WriteLine("1. Combat");
                Console.WriteLine("2. Consumer");
                Console.WriteLine("3. Public Transport");
                Console.WriteLine("4. Sports");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine()!;
                Console.WriteLine();

                if (choice == "0")
                {
                    break;
                }

                if (int.TryParse(choice, out int categoryChoice) && categoryChoice >= 1 && categoryChoice <= 4)
                {
                    TransportCategory selectedCategory = (TransportCategory)(categoryChoice - 1);
                    CreateVehicle(selectedCategory);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                }
            }
        }

        static void CreateVehicle(TransportCategory category)
        {
            Vehicle vehicle = null!;

            Console.Write("Enter the vehicle name: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter the year of manufacture: ");
            int year = Convert.ToInt32(Console.ReadLine());

            switch (category)
            {
                case TransportCategory.Combat:
                    Console.Write("Enter the fire power: ");
                    int firePower = Convert.ToInt32(Console.ReadLine());

                    vehicle = new CombatVehicle
                    {
                        Name = name,
                        Year = year,
                        FirePower = firePower
                    };
                    break;

                case TransportCategory.Consumer:
                    Console.Write("Enter the passenger capacity: ");
                    int passengerCapacity = Convert.ToInt32(Console.ReadLine());

                    vehicle = new ConsumerVehicle
                    {
                        Name = name,
                        Year = year,
                        PassengerCapacity = passengerCapacity
                    };
                    break;

                case TransportCategory.PublicTransport:
                    Console.Write("Enter the route number: ");
                    int routeNumber = Convert.ToInt32(Console.ReadLine());

                    vehicle = new PublicTransportVehicle
                    {
                        Name = name,
                        Year = year,
                        RouteNumber = routeNumber
                    };
                    break;

                case TransportCategory.Sports:
                    Console.Write("Enter the sports type: ");
                    string sportsType = Console.ReadLine()!;

                    vehicle = new SportsVehicle
                    {
                        Name = name,
                        Year = year,
                        SportsType = sportsType
                    };
                    break;
            }

            if (vehicle != null)
            {
                Console.WriteLine();
                Console.WriteLine("Vehicle Created Successfully:");
                vehicle.DisplayInfo();
            }
        }
    }
}
