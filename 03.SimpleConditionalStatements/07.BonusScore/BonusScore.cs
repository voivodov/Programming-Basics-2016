using System;

namespace _07.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter test mark: ");
            int score = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (score <= 100)
            {
                bonus = 5.0;
            }

            else if (score > 100 && score < 1000)
            {
                bonus = score * (20/100.0);
            }

            else if (score >= 1000)
            {
                bonus = score * (10/100.0);
            }
            if ((score % 2) == 0)
            {
                bonus++;
            }
            else if ((score % 10) == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine((score + bonus));
        }
    }
}