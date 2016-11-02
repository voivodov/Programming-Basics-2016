using System; 

namespace _02.NumbersEndingIn7
{
    class NumbersEndingIn7
    {
        static void Main(string[] args)
        {
            for( int i =1; i <= 10000; i++ )
                if( i % 10 == 8 )
                    Console.WriteLine(i);
        }
    }
}
