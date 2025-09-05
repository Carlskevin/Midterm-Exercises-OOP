using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_InheritanceWithConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Carls Kevin Belleza
            //IT306
            //EXER_07: Simple Inheritance with Constructor

            //Create Objects for both derived classes   
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Regular Student Information");
            Console.ResetColor();
            RegularStudent regularStudent = new RegularStudent("Khert Khen Salon", "Bsit", "IT306");
            //Method To Display Regular Student
            regularStudent.SectionInfo();

            Console.ForegroundColor= ConsoleColor.Cyan;    
            Console.WriteLine("\nIrregular Student Information");
            Console.ResetColor();
            IrregularStudent irregularStudent = new IrregularStudent("Sky Loon", "BSIT", 15);
            irregularStudent.EnrolledSemUnits(); //Method To Display Irregular Student  


            Console.ReadKey();
        }
    }
}
