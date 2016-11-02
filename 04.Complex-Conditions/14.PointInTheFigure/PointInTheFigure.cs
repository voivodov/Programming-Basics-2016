using System; 

namespace _14.PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int pointX = int.Parse(Console.ReadLine());
            int pointY = int.Parse(Console.ReadLine());

            if ((pointX > h) && (pointX < 2 * h) && (pointY == h))
                Console.WriteLine("inside");  
            else if ((pointX >= h) && (pointX <= 2 * h) && (pointY >= h) && (pointY <= 4 * h))
            {
                if ((pointX > h) && (pointX < 2 * h) && (pointY > h) && (pointY < 4 * h))  
                    Console.WriteLine("inside"); 
                else if ((pointX >= h) && (pointX <= 2 * h) || (pointY >= h) && (pointY <= 4 * h))
                    Console.WriteLine("border");  
            }

            else if ((pointX >= 0) && (pointX <= 3 * h) && (pointY >= 0) && (pointY <= h))
            {
                if ((pointX > 0) && (pointX < 3 * h) && (pointY > 0) && (pointY < h))
                    Console.WriteLine("inside"); 
                else if ((pointX >= 0) && (pointX <= 3 * h) || (pointY >= 0) && (pointY <= h))
                    Console.WriteLine("border"); 
            }

            else
                Console.WriteLine("outside"); 
        }
    }
}
