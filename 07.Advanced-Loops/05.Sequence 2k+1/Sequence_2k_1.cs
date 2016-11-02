using System; 

namespace _05.Sequence_2k_1
{
    class Sequence_2k_1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1; 
            for (int i = 1; i <= n; i++)
            {
                if (num <=n)
                {
                    Console.WriteLine(num);
                    num = num * 2 + 1;
                }
                
                

            }
        }
    }
}
