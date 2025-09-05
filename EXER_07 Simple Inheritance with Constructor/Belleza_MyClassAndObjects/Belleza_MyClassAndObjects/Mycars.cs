using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_MyClassAndObjects
{
    internal class Mycars
    {
        //Attributes 

        public string name;
        public string color;
        public string model;

        //Method Display to display car details 
        public void Display()
        {
            Console.WriteLine("Car Name: " + name);
            Console.WriteLine(" Car Color: " + color);
            Console.WriteLine("Car Model: " + model);
            Console.WriteLine();
        }

    }
}

        
