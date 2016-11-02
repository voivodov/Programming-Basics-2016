using System;

namespace _10.PasswordGuess
{
    class PasswordGuess
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            string trys = Console.ReadLine();
            
            if(pass == trys)
                Console.WriteLine("Welcome");
            else
                Console.WriteLine("Wrong password!");
        }
    }
}
