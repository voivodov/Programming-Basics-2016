using System;


namespace _08.MinuteCalculate
{
    class MinuteCalculate
    {
        static void Main(string[] args)
        {
            int furstRunner = int.Parse(Console.ReadLine());
            int secundRunner = int.Parse(Console.ReadLine());
            int thurtRunner = int.Parse(Console.ReadLine());

            int result = furstRunner + secundRunner + thurtRunner;

            TimeSpan time = TimeSpan.FromSeconds(result);

            Console.WriteLine(time.ToString(@"mm\:ss"));

        }
    }
}
