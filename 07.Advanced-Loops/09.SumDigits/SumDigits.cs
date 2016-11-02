using System; 

namespace _09.SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = n;
            int sum = 0;
            while(number != 0)
            {
                int current = number % 10;
                sum += current;
                number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
