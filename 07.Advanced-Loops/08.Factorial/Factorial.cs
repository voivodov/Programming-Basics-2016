﻿using System; 

namespace _08.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int factorial =1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i; 
            }
            Console.WriteLine(factorial);
        }
    }
}
