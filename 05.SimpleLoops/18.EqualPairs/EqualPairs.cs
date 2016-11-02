using System;

namespace _18.EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double lastSum = 0, sum = 0, diff = 0, bigDiff = 0;

            for (int i = 0; i < n; i++)
            {
                double firstNumber = double.Parse(Console.ReadLine());
                double secondNumber = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    lastSum = firstNumber + secondNumber;
                }
                else
                {
                    sum = firstNumber + secondNumber;
                    diff = Math.Abs(sum - lastSum);

                    if (diff > bigDiff)
                    {
                        bigDiff = diff;
                    }
                    lastSum = sum;
                }
            }

            if (bigDiff == 0)
            {
                Console.WriteLine("Yes, value =" + lastSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff =" + bigDiff);
            }
        }
    }
}
