using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tshirt sando = new Sando { Price = 3500, Discount = 500 };
            Tshirt polo = new Polo { Price = 5000, Discount = 600 };
            Tshirt croptop = new Croptop { Price = 1000, Discount = 70 };

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\tTshirt Price");
            Console.ResetColor();
            Console.WriteLine($"\nSando Price after Discount: {sando.DiscountedPrice}");
            Console.WriteLine($"Polo Price after Discount: {polo.DiscountedPrice}");
            Console.WriteLine($"Croptop Price after Discount: {croptop.DiscountedPrice}");


            Console.ReadKey();
        }
    }
}
