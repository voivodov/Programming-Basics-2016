using System;

namespace _01.ExcellentResult
{
    class ExcellentResult
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mark of test: ");
            double num = double.Parse(Console.ReadLine());
            if (num >= 5.50 && num < 6.01)
                Console.WriteLine("Excellent!");
            else
                Console.WriteLine("Not Exellent!");
        }
    }
}
