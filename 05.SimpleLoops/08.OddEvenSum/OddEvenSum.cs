using System;

namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            long evenSum = 0, oddSum = 0;

            for (int i = 1; i <= count; i++)
            {
                long numberToSum = long.Parse(Console.ReadLine());

                if (i % 2 == 0)
                { 
                    evenSum += numberToSum;
                }
                else
                {
                    oddSum += numberToSum;}
            }
            if ((Math.Abs(evenSum - oddSum)) == 0)
                Console.WriteLine("Yes, sum = " + evenSum);
            else
                Console.WriteLine("No diff = " + Math.Abs(evenSum - oddSum));
        }
    }
}
