using System;

namespace _04.EvenPowersOf2
{
    class EvenPowersOf2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 0; i <=  n; i++)
            {
                
                if (i % 2 == 0)
                {
                    Console.WriteLine(sum);
                    sum =sum* 2 * 2;
                }
                
                
            }
        }
    }
}
