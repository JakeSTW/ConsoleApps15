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
        public void Run(){}
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private const double FEET_IN_METRES = 3.28084;

  
        private object fromUnit;
        private object toUnit;
        private double FromDistance;
        private double ToDistance;
        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        public object MilestoFeet { get; internal set; }

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
                OutputHeading();

                fromUnit = SelectUnit("Please select the from distance unit >");
                toUnit = SelectUnit("Please select the to distance unit >");


                Console.WriteLine($"Converting {fromUnit} to {toUnit} ");

                FromDistance = InputDistance
                    ($"Please enter the number of {fromUnit}>");

                CaculateDistance();

                OutputDistance();
            }

        private void CaculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
           
            else if (fromUnit == FEET && toUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
           
            else if (fromUnit == METRES && toUnit == MILES);
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
           }



            private object SelectUnit(string prompt)
            {
                string choice = DisplayChoices(prompt);

                string unit = ExecuteChoice(choice);
                Console.WriteLine($"You have chosen {unit}");
                return unit;

            }

            private static string ExecuteChoice(string choice)
            {
                if (choice.Equals("1"))
                {
                    return FEET;
                }
                else if (choice == "2")
                {
                    return METRES;
                }
                else if (choice.Equals("3"))
                {
                    return MILES;
                }
        
                return null;
            }

            private static string DisplayChoices(string prompt)
            {
                Console.WriteLine();
                Console.WriteLine($"1. {FEET}");
                Console.WriteLine($"2. {METRES}");
                Console.WriteLine($"3. {MILES}");
                Console.WriteLine();

                Console.Write(prompt);
                string choice = Console.ReadLine();
                return choice;
            }


            private void OutputHeading(string v)
            {
                throw new NotImplementedException();
            }



            private void OutputDistance()
            {
                Console.WriteLine($" {FromDistance} {fromUnit} is " +
                    $"{ToDistance} {toUnit}!");
            }

            /// <summary>
            /// Prompt the user to enter the distance in miles
            /// Input the miles as a double number
            /// </summary>
            private double InputDistance(string prompt)
            {
                Console.Write(prompt);
                string value = Console.ReadLine();
                return Convert.ToDouble(value);
            }


            private static void OutputHeading()
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine();
                Console.WriteLine(" ========================");
                Console.WriteLine("    Distance Converter   ");
                Console.WriteLine("        by Jake Stewart  ");
                Console.WriteLine(" ========================");



            }
        }

    }

