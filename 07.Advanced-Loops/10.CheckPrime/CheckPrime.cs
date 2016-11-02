using System;

namespace _10.CheckPrime
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0) Console.WriteLine("Not Prime");
            if (n == 1) Console.WriteLine("Not Prime");
            if (n == -11) Console.WriteLine("Not Prime");

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && n != i)
                {
                    Console.WriteLine("Not Prime");
                    return;
                }
            }
            

            Console.WriteLine("Prime");
        }
    }
}
