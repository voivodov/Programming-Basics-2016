using System; 

namespace _17.OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double oddSum = 0.0, oddMin = 1000000000.0, oddMax = -1000000000.0, 
                evenSum = 0.0, evenMin = 1000000000.0, evenMax = -1000000000.0;

            for(int i = 1; i<= count; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if( i % 2 == 0) 
                {
                    evenSum += number;
                    evenMin = Math.Min(number, evenMin);
                    evenMax = Math.Max(number, evenMax);
                }
                else
                {
                    oddSum += number;
                    oddMin = Math.Min(number, oddMin);
                    oddMax = Math.Max(number, oddMax);
                }
            }

            Console.WriteLine("OddSum = " + oddSum);
            if (oddMin ==  1000000000.0)
                Console.WriteLine("oddMin = No");
            else
                Console.WriteLine("OddMin = " + oddMin);

            if(oddMax == - 1000000000.0)
                Console.WriteLine("oddMax = No");
            else
                Console.WriteLine("oddMax = "+ oddMax);

            Console.WriteLine("EvenSum = " + evenSum);
            if((evenMin ==  1000000000.0))
                Console.WriteLine("EvenMin = No");
            else
                Console.WriteLine("EvenMin = " + evenMin);

            if(evenMax == - 1000000000.0)
                Console.WriteLine("EvenMax = No");
            else
                Console.WriteLine("EvenMax = " + evenMax);
        }
    }
}
