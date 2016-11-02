using System;

namespace _06.CircleAreaAndPerimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("The Area is: " + (Math.PI * r * r));
            Console.WriteLine("The Perimeter is: " + (Math.PI * 2 * r));
        }
    }
}
