using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace exer8
{
    internal class Cars
    {
        private string brand;
        private string color;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Cars(string brand, string color)
        {
            this.brand = brand;
            this.color = color;
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Brand: {brand}, Color: {color}");
        }
    }

    // Derived Class 1
    class SportsCar : Cars
    {
        private int year;
        private int topSpeed;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int TopSpeed
        {
            get { return topSpeed; }
            set { topSpeed = value; }
        }

        public SportsCar(string brand, string color, int year, int topSpeed)
            : base(brand, color)
        {
            this.year = year;
            this.topSpeed = topSpeed;
        }

        public void ShowSportsCarInfo()
        {
            Console.WriteLine("\n--- Sports Car Details ---");
            ShowCarInfo();
            Console.WriteLine($"Year: {year}, Top Speed: {topSpeed} km/h");
        }
    }

    // Derived Class 2
    class PickupCar : Cars
    {
        private int year;
        private double loadCapacity; // in tons

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double LoadCapacity
        {
            get { return loadCapacity; }
            set { loadCapacity = value; }
        }

        public PickupCar(string brand, string color, int year, double loadCapacity)
            : base(brand, color)
        {
            this.year = year;
            this.loadCapacity = loadCapacity;
        }

        public void ShowPickupCarInfo()
        {
            Console.WriteLine("\n--- Pickup Car Details ---");
            ShowCarInfo();
            Console.WriteLine($"Year: {year}, Load Capacity: {loadCapacity} tons");
        }
    }
}
