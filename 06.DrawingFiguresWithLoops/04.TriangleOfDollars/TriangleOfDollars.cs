using System; 

namespace _04.TriangleOfDollars
{
    class TriangleOfDollars
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for(int i = 1; i <= count; i++)
            {
                Console.WriteLine(new string('$', i));
                 
            }
        }
    }
}
