﻿using System;


namespace _12.Number100To200If_Else
{
    class Number100To200
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if(num < 100)
                Console.WriteLine("Less than 100");
            else if (100<=num && num<=200)
                Console.WriteLine("Between 100 and 200");
            else if(num > 200)
                Console.WriteLine("Greater than 200");
        }
    }
}
