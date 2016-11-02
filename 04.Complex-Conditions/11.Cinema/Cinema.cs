using System; 

namespace _11.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            double r = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            switch (type)
            {
                case "premiere": Console.WriteLine(Math.Round((r*c*12.00),2) + " leva"); break;
                case "normal": Console.WriteLine(Math.Round((r * c * 7.50), 2) + " leva"); break;
                case "discount": Console.WriteLine(Math.Round((r * c * 5.00), 2) + " leva"); break;
                default: Console.WriteLine("error"); break;
            }
        }
    }
}
