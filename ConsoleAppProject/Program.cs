using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;


namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Jake Stewart 09/02/2022
    /// </summary>
    public static class Program
    {
        public static BmiCalculator BmiCalculator { get; private set; }

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("        by Jake                                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;


            DistanceConverter converter = new DistanceConverter();

            converter.ConvertDistance();

            BmiCalculator = new BmiCalculator();



        }

    }


}
    





