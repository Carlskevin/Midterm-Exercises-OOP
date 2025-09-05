using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_InheritanceWithConstructor
{
    internal class Studentcs //Base Class   
    {
        //Properties for the student class
        public string name; 
        public string program;

        public Studentcs(string studentName, string Studentprogram) //Constructor
        {
           name = studentName;  
           program = Studentprogram;
        }

        //Method to display book information 
        public void BasicInfo()
        {
            Console.WriteLine($"Name:{name}, \nProgram: {program}");
        }
    }
    class RegularStudent : Studentcs //Derived Class
    {
        //Additional property for the Regular Student
        public string section;

        public RegularStudent(string studentName, string Studentprogram, string studentSection) : base(studentName, Studentprogram) //Constructor
        {
            section = studentSection;
        }

        //Method to display irregular student 
        public void SectionInfo()
        {
            BasicInfo(); //Calling the base class method
            Console.WriteLine($"Section Enrolled: {section}");
        }
    }
    class IrregularStudent : Studentcs //Another Derived Class
    {
        //Additional property for the irregular student
        public int unitsEnrolled; 
        public IrregularStudent(string studentName, string Studentprogram, int studentUnitsEnrolled) : base(studentName, Studentprogram) //Constructor
        {
            unitsEnrolled = studentUnitsEnrolled;
        }

        //Method to display IrregularStudent
        public void EnrolledSemUnits()
        {
            BasicInfo(); //Calling the base class method
            Console.WriteLine($"Units Enrolled:{unitsEnrolled}");
        }
    }
}
