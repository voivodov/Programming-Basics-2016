using System;
using System.Globalization;

namespace _13._1000DaysAfterBirth
{
    class DaysAfterBirth
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            date = date.AddDays(999);
            Console.WriteLine(date.ToString("dd-MM-yyyy"));

        }
    }
}
