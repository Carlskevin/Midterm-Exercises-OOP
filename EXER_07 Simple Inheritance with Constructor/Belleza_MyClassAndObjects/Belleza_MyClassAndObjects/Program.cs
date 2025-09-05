using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_MyClassAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Carls Kevin Belleza 
            //IT306

            //Initialize car objects 
            Mycars mycar1 = new Mycars();
            Mycars mycar2 = new Mycars();

            //Set car attributes 
            Console.ForegroundColor = ConsoleColor.Magenta;
            mycar1.name = "BMW";
            mycar1.color = "Black";
            mycar1.model = "X5";

            mycar2.name = "";
            mycar2.color = "red";
            mycar2.model = "C-Class";

            //Display car detials
            mycar1.Display();
            mycar2.Display();   

       
            Console.ReadKey();









        }
    }
}
