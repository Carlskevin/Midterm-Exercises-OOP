using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_with_inout
{
    internal class Cars //Base class
    {

              //Properties of the base class
        public string Color;
        public string Model;
        public int Year;

        public Cars(string color, string model, int year) //Constructor of the base class
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
    class SportsCar : Cars//Derived class  
    {
        public string color;
        public int topspeed;

        public SportsCar(string color, string model, int Year, int TopSpeed) : base(color, model, Year)
        {
            color = Color;
            TopSpeed = topspeed;
        }
        public void SportsCarInfo()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine); 
            Console.WriteLine("\t\tSports Car Details:\t\t");
            CarInfo();
            Console.WriteLine($"SportsCar: {Model},\nColor: {Color},\nYear: {Year},\nTop Speed:{topspeed} km/h");
        }
}
    class PickupCar : Cars
    {
        public string model;
        public int year;

        public PickupCar(string color, string Model, int Year, int topSpeed) : base(color, Model, Year)
        {
            model = Model;
            year =  Year;
        }
        public void PickupInfo()
        {
            Console.Clear(); 
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("\t\tPick Up Car Details:\t\t");
            CarInfo();
            Console.WriteLine($"PickupCar: {Model}, \n Color: {Color}, \n Year: {Year}");
}

