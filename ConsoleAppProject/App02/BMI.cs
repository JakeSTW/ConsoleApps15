using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// Jake Stewart
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter your weight(kg): ");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height (m): ");
            double height = Convert.ToDouble(Console.ReadLine());

            double BMI = kg / (height * height);
            Console.WriteLine("Your BMI is : " + Math.Round(BMI, 2));
            Console.ReadKey();

            if (BMI < 16)
                Console.WriteLine("You're serverley underweight");
            else if (BMI <= 18.5)
                Console.WriteLine("You're underweight");
            else if (BMI <= 25)
                Console.WriteLine("You're normal weight");
            else if (BMI <= 30)
                Console.WriteLine("You're overweight");
            else if (BMI <= 35)
                Console.WriteLine("You're moderately overweight");
            else if (BMI >= 40)
                    Console.WriteLine("You're Obese");


        }
    }
}
