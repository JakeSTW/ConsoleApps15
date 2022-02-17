using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Jake version 0.1
    /// </author>
    public class DistanceConverter 
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        private double miles;
        private double feet;
        private string number;
        private double metres;

        /// <summary>
        /// This method will output a heading, ask dfor the
        /// input for miles, calculate and output the same
        /// distance in feet.
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");
            miles = InputDistance("Please enter the number of miles >");
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");
            feet = InputDistance("Please enter the number of feet >");
            CalculateMiles();
            OutputMiles();
        }

        private void CalculateMiles()
        {
            throw new NotImplementedException();
        }

        public void MilestoMetres()
        {
            OutputHeading("Converting Miles to Metres");
            metres = InputDistance("Please enter the number of metres >");
            CalculateMetres();
            OutputMetres();
        }

        private void CalculateMetres()
        {
            throw new NotImplementedException();
        }

       

        private void OutputFeet()
        {
            Console.WriteLine("The number of feet = " + feet);
        }

        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private void InputDistance(string prompt)
        {
            Console.Write(prompt); 
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private void CaculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }
        private void CaculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }
        private void OutputMiles()
        {
            Console.WriteLine(feet + "feet is" + miles + "miles!");
        }
        private void OutputMetres()
        {
            Console.WriteLine(miles + "miles is" + miles + "metres!");
        }
        private static void OutputHeading(string prompt)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(" ========================");
            Console.WriteLine("    Distance Converter   ");
            Console.WriteLine("        by Jake Stewart         ");
            Console.WriteLine(" ========================");

            Console.WriteLine(prompt);
            Console.WriteLine();

        }
    }

}
