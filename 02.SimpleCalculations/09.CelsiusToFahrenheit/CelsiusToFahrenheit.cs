using System;

namespace _09.CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            double c = double.Parse(Console.ReadLine());
            double f = (c * 9) / 5 + 32;
            Console.WriteLine(Math.Round(f, 2));
        }
    }
}
