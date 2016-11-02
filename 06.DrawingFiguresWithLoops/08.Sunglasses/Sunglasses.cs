using System; 

namespace _08.Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            if(n >= 3 && n  <= 100)
            {
                Console.Write (new string('*', n * 2));
                Console.Write(new string(' ', n  ));
                Console.WriteLine(new string('*', n * 2));
                for (int i = 0; i < n-2; i++)
                {
                    bool isMiddle = false;
                    Console.Write("*");
                    Console.Write(new string ('/', n * 2 - 2));
                    Console.Write("*");

                    if (n % 2 == 0)
                    {
                        if (i == (n - 2) / 2 - 1)
                        {
                            isMiddle = true;
                            Console.Write(new string('|', n));
                        }

                    }
                    else if (i == (n - 2) / 2)
                    {
                        Console.Write(new string('|', n));
                        isMiddle = true;
                    }
                    if (isMiddle == false)
                    {
                        Console.Write(new string(' ',n));
                    }
                    Console.Write("*");
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write("*");

                    Console.WriteLine();
                }
                Console.Write(new string('*', n * 2));
                Console.Write(new string(' ', n));
                Console.WriteLine(new string('*', n * 2));
            }
            else
                Console.WriteLine("invalid number");
        }
    }
}
