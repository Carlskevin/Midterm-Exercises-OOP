using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_with_inout
{
    internal class Car //Base class
    {

        //Properties of the base class
        public string Color;
        public string Model;
        public int Year;

        public Car(string color, string model, int year) //Constructor of the base class
        {
            Color = color;
            Model = model;
            Year = year;
        }
            
        public void CarInfo()//Method to display car details
        {
            Console.WriteLine($"Car: {Model}, Color: {Color}, Year: {Year}");
        }
    }
    internal class SportsCar : Car //Derived class  
    {
        public int TopSpeed;

        public SportsCar(string color, string model, int year, int topSpeed) : base(color, model, year)
        {
            TopSpeed = topSpeed;
        }

        //Method to display sports car details  
        public void SportsCarInfo()
        {
            Console.WriteLine("\t\tSports Car Details:\t\t");   
            Console.WriteLine($"SportsCar: {Model},\nColor: {Color},\nYear: {Year},\nTop Speed:{TopSpeed} km/h");
        }
    }
}
