namespace _03._Reverse_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];

            for (int number = 1; number <= count; number++) 
            { 
                int value = int.Parse(Console.ReadLine());
                numbers[number - 1] = value;
            }

            for (int number = count - 1; number >= 0; number--)
            {
                Console.Write(numbers[number] + " ");
            }
        }
    }
}
