using System; 

namespace _03.SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                 Console.Write ("*");
                for(int k = 1; k < count; k++)
                {
                    Console.Write(" ");
                    Console.Write(new string('*',k));
                    
                }
                Console.WriteLine();
            }
                
        }
    }
}
