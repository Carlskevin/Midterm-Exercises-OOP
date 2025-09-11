using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a car type:");
            Console.WriteLine("1. Sports Car");
            Console.WriteLine("2. Pickup Car");
            Console.Write("Enter your choice (1 or 2): ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.Write("Invalid choice. Please enter 1 or 2: ");
            }

            Console.Write("Enter brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter color: ");
            string color = Console.ReadLine();

            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter top speed (km/h): ");
                int topSpeed = int.Parse(Console.ReadLine());

                SportsCar sportsCar = new SportsCar(brand, color, year, topSpeed);
                sportsCar.ShowSportsCarInfo();
            }
            else
            {
                Console.Write("Enter load capacity (in tons): ");
                double loadCapacity = double.Parse(Console.ReadLine());

                PickupCar pickupCar = new PickupCar(brand, color, year, loadCapacity);
                pickupCar.ShowPickupCarInfo();
            }

            Console.ReadKey();
        }
    }
}
