using System;

namespace _15.AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figures = Console.ReadLine();

            if (figures == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a*a),3));

            }
            if (figures == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a*b),3));

            }
            if (figures == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((Math.PI*r*r),3));

            }
            if (figures == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a*h/2),3));
            }
        }
    }
}
