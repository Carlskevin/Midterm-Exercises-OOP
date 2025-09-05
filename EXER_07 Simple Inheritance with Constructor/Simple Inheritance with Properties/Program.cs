using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inheritance_with_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Carls Kevin Belleza
            //IT306
            //EXER_06: Simple Inheritance with Properties

            //Create Objects for both derived classes   
            RegularStudent regularStudent = new RegularStudent
            {
                Name = "Khert Khen Salon",
                Program = "BSIT",
                Section = "IT306"
                };
          
            IrregularStudent irregularStudent = new IrregularStudent
            {
                Name = "Jane Doe",
                Program = "BSCS",
                UnitsEnrolled =15
            };
            //Display Regular Student Information   
            Console.ForegroundColor = ConsoleColor.Cyan;  
            Console.WriteLine("Regular Student Information");
            regularStudent.BasicInfo();
            regularStudent.SectionInfo();
          
            Console.WriteLine("\nIrregular Student Information"); 
            irregularStudent.BasicInfo();
            irregularStudent.EnrolledSemUnits();

            Console.ReadKey();
        }
    }
}
