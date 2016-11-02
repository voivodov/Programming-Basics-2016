using System;

namespace _10.RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 57.29578d;
            Console.WriteLine(Math.Round(degrees, 0));
        }
    }
}
