﻿using System; 

namespace _02.Small_Shop
{
    class Small_Shop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if(town == "sofia")
            {
                if (product == "coffee")
                    Console.WriteLine(quantity * 0.50);
                else if (product == "water")
                    Console.WriteLine(quantity * 0.80);
                else if (product == "beer")
                    Console.WriteLine(quantity * 1.20);
                else if (product == "sweets")
                    Console.WriteLine(quantity * 1.45);
                else if (product == "peanuts")
                    Console.WriteLine(quantity * 1.60);
            }
            else if (town == "plovdiv")
            {
                if (product == "coffee")
                    Console.WriteLine(quantity * 0.40);
                else if (product == "water")
                    Console.WriteLine(quantity * 0.70);
                else if (product == "beer")
                    Console.WriteLine(quantity * 1.15);
                else if (product == "sweets")
                    Console.WriteLine(quantity * 1.30);
                else if (product == "peanuts")
                    Console.WriteLine(quantity * 1.50);
            }
            else if (town == "varna")
            {
                if (product == "coffee")
                    Console.WriteLine(quantity * 0.45);
                else if (product == "water")
                    Console.WriteLine(quantity * 0.70);
                else if (product == "beer")
                    Console.WriteLine(quantity * 1.10);
                else if (product == "sweets")
                    Console.WriteLine(quantity * 1.35);
                else if (product == "peanuts")
                    Console.WriteLine(quantity * 1.55);
            }
        }
    }
}
