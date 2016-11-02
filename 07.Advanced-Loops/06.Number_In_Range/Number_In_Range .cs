using System; 

namespace _06.Number_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Еnter a number in the range [1...100]:");
            int num = int.Parse(Console.ReadLine());
            if (num <  1 || num >  100)
            {
                do
                {
                    Console.WriteLine("Invalid number!");
                     num = int.Parse(Console.ReadLine());
                } while (num <  1 || num >  100);
            }
            if ((num >= 1 && num <= 100))
            {
                Console.WriteLine("The number is:" + num);
            } 
            




        }
    }
}
