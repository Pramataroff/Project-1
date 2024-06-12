using System;
using System.Diagnostics.CodeAnalysis;

namespace _2_zad
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Students student = new Students();
            List<Students> students = new List<Students>();
            Console.Write("Enter how many students: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Students current = new Students();
                current.number = i+14;
                Console.Write($"Enter name of student number [{i + 14}] : ");
                current.name = Console.ReadLine();
                Console.Write($"enter grade of student number [{i + 14}] : ");
                current.Grade = double.Parse(Console.ReadLine());
                students.Add(current);
                sum += current.Grade;
            }
            Students.Average = sum/n;
            for (int i = 0;i < students.Count;i++)
            {
                students[i].PrintStudents();

            }
            Console.WriteLine($"The average grade is {Students.Average:f2}");
        }
    }
}
