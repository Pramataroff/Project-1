namespace _3_zad
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Students student = new Students();
            List<Students> students = new List<Students>();
            Console.Write("Enter how many students: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Students current = new Students();
                current.number = i + 14;
                Console.Write($"Enter name of student number [{i + 14}] : ");
                current.name = Console.ReadLine();
                Console.Write($"enter grade of student number [{i + 14}] : ");
                current.Grade = double.Parse(Console.ReadLine());
                students.Add(current);
            }

            Console.Write("Do you want to change any student's grade: Y/N: ");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 'Y')
            {
                Console.Write("Which number's grade you wanna change: ");
                int studentnumber = int.Parse(Console.ReadLine());
                double oldgrade = students[studentnumber - 14].Grade;
                Console.Write("Enter the student's new grade: ");
                students[studentnumber - 14].Grade = double.Parse(Console.ReadLine());
                double newgrade = students[studentnumber - 14].Grade;
                Console.WriteLine("The old grade is: "+oldgrade);
                Console.WriteLine("The new grade is: "+newgrade);

            }
            else if (answer == 'N')
            {

            }
            else
            {
                Console.WriteLine("!!!Invalid char!!!");
            }
            
        }
    }
}
