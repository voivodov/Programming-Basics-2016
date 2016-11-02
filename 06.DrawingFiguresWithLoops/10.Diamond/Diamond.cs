using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1 )
            {
                Console.WriteLine("*");
                return;
            }
            if (n == 2)
            {
                Console.WriteLine("**");
                return;
            }

            int dashes = (n % 2 == 0) ? (n / 2 - 1) : (n / 2);
            int stars = (n % 2 == 0) ? 2 : 1;
            int lines = (n % 2 == 0) ? n/2-1 : n/2;
            int inLineDashes = (n % 2 == 0) ? 2 : 1;

            string furstLine = new string('-', dashes) + new string('*', stars) + new string('-', dashes);
            Console.WriteLine(furstLine);

            for (int i = 0; i < lines ; i++)
            {
                if(dashes>0)
                    dashes--;
                Console.Write(new string('-', dashes));
                Console.Write(new string('*', 1));
                Console.Write (new string('-', inLineDashes));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('-', dashes));
                inLineDashes += 2; 
            }
            inLineDashes -= 2;
            for (int i = 0; i < lines-1; i++)
            {
                inLineDashes -= 2;
                Console.Write(new string('-', i+1));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', inLineDashes));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', i + 1));
                Console.WriteLine();
            }

            Console.WriteLine(furstLine);
        }
    }
}
