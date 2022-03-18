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
            string[] choices =
            {
                "App01 Distance Converter",
                "App02 BMI Calculator",
                "App03 Student Grades "
            };

            Console.WriteLine(" Please Choose your App");

            int choice = ConsoleHelper.SelectChoice(choices);

            switch (choice)
            {
                case 1: DistanceConverter app01 = new DistanceConverter();
                    app01.Run();
                    break;

                    case 2:
                    new BmiCalculator().Run();
                    break;

                    case 3: StudentGrades app03 = new StudentGrades();
                    app03.Run();
                    break;
            }

            

            BmiCalculator app02 = new BmiCalculator();

            



        }

    }


}
    





