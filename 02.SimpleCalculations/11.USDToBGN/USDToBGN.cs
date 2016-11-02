using System;

namespace _11.USDToBGN
{
    class USDToBGN
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = 1.79549 * usd;
            Console.WriteLine(Math.Round(bgn, 2));
        }
    }
}
