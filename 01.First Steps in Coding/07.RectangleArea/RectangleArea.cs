using System;

namespace _07.RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            var a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            var b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The Area is: " + (a * b));
        }
    }
}
