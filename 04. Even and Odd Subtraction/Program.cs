namespace _04._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();

            int even = 0;
            int odd = 0;
            int difference = 0;
            foreach (int number in arrayNumbers)
            {
                if (number % 2 == 0)
                {
                    even += number;
                }
                else
                {
                    odd += number;
                }
            }
            difference = even - odd;
            Console.WriteLine(difference);
        }
    }
}
