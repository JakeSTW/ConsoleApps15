using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public void Run()
        {
            Students = new string[] { "Jake", "Charlie", "Taylor" };
            Marks = new int[Students.Length];

            ConsoleHelper.OutputHeading("App03 Student Marks");
           
            InputMarks();
            ConvertToGrades();
            OutputGrades();
        }

        private void InputMarks()
        {
           Console.WriteLine("Please enter a mark for each student");
            int index = 0;
            foreach(string name in Students)
            {
               int mark = (int)ConsoleHelper.InputNumber($"{name} Enter Marks >", 0, 100);
                Marks[index] = mark;    
            }
        }

        private void OutputGrades()
        {
            for(int i = 0; i < Marks.Length; i++)
            {
                Console.WriteLine($"{Students[i]} mark = {Marks[i]}");
            }
        }

        private void ConvertToGrades()
        {
            throw new NotImplementedException();
        }
    }
}

      

