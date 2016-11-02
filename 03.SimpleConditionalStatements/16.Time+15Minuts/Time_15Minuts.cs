using System;

namespace _16.Time_15Minuts
{
    class Time_15Minuts
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            DateTime time = new DateTime();
            time = time.AddHours(hours);
            time = time.AddMinutes(minutes + 15);
            Console.WriteLine(time.ToString("H:mm"));
        }
    }
}
