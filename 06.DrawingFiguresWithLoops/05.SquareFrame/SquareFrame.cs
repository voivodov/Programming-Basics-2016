using System; 

namespace _05.SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Console.Write("+");
            for (int i = 0; i < count - 2; i++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();

            for (int u = 0; u < count - 2; u++)
            {
                Console.Write("|");
                for (int m = 0; m < count - 2; m++)
                {
                    Console.Write(" -");
                }
                Console.Write(" |");
                Console.WriteLine();
            }

            Console.Write("+");
            for (int k = 0; k < count - 2; k++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();
        }
    }
}
