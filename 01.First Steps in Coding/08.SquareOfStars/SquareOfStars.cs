using System;

namespace _08.SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (2 <= n & n <= 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i == 1 || i == n || j == 1 || j == n)                       
                            Console.Write("*");                        
                        else                        
                            Console.Write(" ");                        
                    }
                    Console.WriteLine();
                }
            }
            else            
                Console.WriteLine("Enter value number !!!");            
        }
    }
}
