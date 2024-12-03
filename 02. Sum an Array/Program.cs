namespace _02._Sum_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            foreach (int number in arrayNumbers)
            {
                sum += number;
            }
            Console.WriteLine(sum);

        }
    }
}
