using System; 

namespace _05.MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи броя на числата: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи първото число:");
            long maxNumber=long.Parse(Console.ReadLine());
            for (int i = 1; i <= count-1; i++)
            {
                Console.WriteLine("Въведи число: ");
                long newNumber = long.Parse(Console.ReadLine());
                maxNumber = Math.Max(maxNumber, newNumber);
            }
            Console.WriteLine("Най-голямото число, което въведе е: "+ maxNumber);  

        }
    }
}
