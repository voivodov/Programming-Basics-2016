using System;

namespace _04.ConcatenateData
{
    class ConcatenateData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter yout town: ");
            string town = Console.ReadLine();
            Console.WriteLine("You are " + firstName + " " + lastName + ", a " + age + "-years old person from " + town + ".");
        }
    }
}
