using System; 

namespace _09.VowelsSum
{
    class VowelsSum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string s = Console.ReadLine() ;
            for (int i = 0; i <= s.Length - 1; i++ )
            {
                if (s[i] == 'a')
                    sum++;
                if (s[i] == 'e')
                    sum+=2;
                if (s[i] == 'i')
                    sum+=3;
                if (s[i] == 'o')
                    sum+=4;
                if (s[i] == 'u')
                    sum+=5;
            }
            Console.WriteLine(sum);
        }
    }
}
