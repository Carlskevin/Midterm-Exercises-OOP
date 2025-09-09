using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_with_inout
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carls Kevin Belleza
            //SECTION: IT306
            //

            // Call method to get sports car details    
            Console.Write("Enter sports car color: ");
            string sportsCarColor = Console.ReadLine();
            Console.Write("Enter sports car model: ");
            string sportsCarModel = Console.ReadLine();
            Console.Write("Enter sports car year: ");
            int sportsCarYear = int.Parse(Console.ReadLine());
            Console.Write("Enter sports car top speed: ");
            int topSpeed = int.Parse(Console.ReadLine());

            SportsCar sportsCar = new SportsCar(sportsCarColor, sportsCarModel, sportsCarYear, topSpeed);
            sportsCar.SportsCarInfo();

            Console.ReadKey();
        }
    }
}
