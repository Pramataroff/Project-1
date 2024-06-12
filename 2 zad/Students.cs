using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zad
{
    public class Students
    {
        public string name;
        private double grade;
        public int number;
        private static double average;
        public static double Average { get { return average; } set { average = value; } }
        public double Grade { get { return grade; } set { grade = value; } }
        public void PrintStudents()
        {
            if (this.Grade >= Average - 0.5 & this.Grade <= Average + 0.5)
            {
                Console.WriteLine($"Student :{this.name} / number: {this.number } / Grade: {this.Grade:f2}");
            }
        }
    }
}
