using System;

namespace _06.TriangleOfStars
{
    class TriangleOfStars
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i <= k; i++)            
                Console.WriteLine(new string('*', i));
        }
    }
}
