using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This application will prompt the user to input a distance
    /// measured in one unit(fromUnit) and it will caculate
    /// and output the equivalent distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Jake version 0.6
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private const double FEET_IN_METRES = 3.28084;

        private double FromDistance;
        private double ToDistance;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// This method will output a heading, ask dfor the
        /// input for miles, calculate and output the same
        /// distance in feet.
        /// </summary>
        public void ConvertDistance()
        {
            fromUnit = SelectUnit("Please select the from distance unit >")
            ToUnit = SelectUnit("Please select the to distance unit >")
            
            OutputHeading($"Converting {fromUnit} to {toUnit} ");
            
            FromDistance = InputDistance
                ($"Please enter the number of {fromUnit}>");

            //CalculateFeet();

            OutputDistance(fromDistance, fromUnit, toDistance, toUnit);
        }


        private void CalculateMiles()
        {
            throw new NotImplementedException();

            private void CalculateMetres()
            {
                throw new NotImplementedException();
            }



            private void OutputDistance()
            {
                Console.WriteLine($" {fromDistance} {fromUnit} is " +
                    $"{toDistance} {toUnit}!");
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
}
