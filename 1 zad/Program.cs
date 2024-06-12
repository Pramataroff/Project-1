namespace _1_zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            Array.Reverse(nums);
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"The count of the not-zero numbers is {count}");
            Console.WriteLine(string.Join(", ",nums));

        }
    }
}
