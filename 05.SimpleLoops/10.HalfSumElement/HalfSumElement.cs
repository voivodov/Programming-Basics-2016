using System; 

namespace _10.HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            long  sum = 0, max = 0;
            for (int i = 1; i <= count; i++)
            {
                long number = long.Parse(Console.ReadLine()); 
                sum += number;
                max = Math.Max(max, number);
            }
            sum -= max;
            if ( sum  == max)
                Console.WriteLine("Yes, sum = " + max);
            else
                Console.WriteLine("No diff = " + Math.Abs(sum - max));
        }
    }
}
