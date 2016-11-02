using System; 

namespace _06.MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            long minNumber = long.Parse(Console.ReadLine());
            for (int i = 1; i <= count-1; i++)
            {
                long newNumber = long.Parse(Console.ReadLine());
                minNumber = Math.Min(minNumber, newNumber);
            }
            Console.WriteLine(minNumber);
        }
    }
}
