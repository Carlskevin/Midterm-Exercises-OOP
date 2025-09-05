using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inheritance_with_Properties
{
    internal class Student
    {
        //Properties for the student class
        public string Name { get; set; }
        public string Program { get; set; }

        //Method to display book information 
        public void BasicInfo()
        {
            Console.WriteLine($"Name:{Name}, \nProgram: {Program}");

        }
    }
    class RegularStudent : Student //Derived Class
    {
        //Additional property for the Regular Student
        public string Section { get; set; }

        //Method to display irregular student 
        public void SectionInfo()
        {
            Console.WriteLine($"Section: {Section}");
        }
    }
    class IrregularStudent : Student //Another Derived Class
    {
        //Additional property for the irregular student
        public int UnitsEnrolled { get; set; }

        //Method to display IrregularStudent
        public void EnrolledSemUnits()
        {
            Console.WriteLine($"Enrolled:{UnitsEnrolled}");
        }
    }
}
