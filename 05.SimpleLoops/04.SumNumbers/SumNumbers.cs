using System; 

namespace _04.SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи числа който искаш да сумираш: ");
            int count = int.Parse(Console.ReadLine());
            long sum = 0;
            for (int i = 1; i<=count; i++)
            {
                Console.WriteLine("Въведи число за сумиране: ");
                int num = int.Parse(Console.ReadLine());
                sum += num;
                Console.WriteLine("Сумата на числата до тук е: " + sum);
            }
            Console.WriteLine("Тоталната сумата на числата е: "+sum);
        }
    }
}
