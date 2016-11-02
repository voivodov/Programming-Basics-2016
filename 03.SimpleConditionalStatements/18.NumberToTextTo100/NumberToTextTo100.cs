using System;

namespace _18.NumberToTextTo100
{
    class From0To100
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 0 to 100");
            int enterNum = int.Parse(Console.ReadLine());            
            int ones = enterNum % 10;
            int tenthes = (enterNum / 10) % 10;
            Console.Write("You enter: ");
            if (enterNum >= 0 && enterNum <= 100)
            {
                if (enterNum >= 0 && enterNum <= 20)
                {
                    if (enterNum == 0)
                        Console.Write("zero");
                    else if (enterNum == 1)
                        Console.Write("one");
                    else if (enterNum == 2)
                        Console.Write("two");
                    else if (enterNum == 3) ;
                        Console.Write("three");
                    else if (enterNum == 4)
                        Console.Write("four");
                    else if (enterNum == 5)
                        Console.Write("five");
                    else if (enterNum == 6)
                        Console.Write("six");
                    else if (enterNum == 7)
                        Console.Write("seven");
                    else if (enterNum == 8)
                        Console.Write("eight");
                    else if (enterNum == 9)
                        Console.Write("nine");
                    else if (enterNum == 10)
                        Console.Write("ten");
                    else if (enterNum == 11)
                        Console.Write("eleven");
                    else if (enterNum == 12)
                        Console.Write("twelve");
                    else if (enterNum == 13)
                        Console.Write("thirteen");
                    else if (enterNum == 14)
                        Console.Write("fourteen");
                    else if (enterNum == 15)
                        Console.Write("fifteen");
                    else if (enterNum == 16)
                        Console.Write("sixteen");
                    else if (enterNum == 17)
                        Console.Write("seventeen");
                    else if (enterNum == 18)
                        Console.Write("eighteen");
                    else if (enterNum == 19)
                        Console.Write("nineteen");
                   }

              if (enterNum >=  20 && enterNum <= 100)
                 { 
                    if (tenthes == 2 && enterNum != 20)
                        Console.Write("twenty ");
                    if (tenthes == 3 && enterNum != 30)
                        Console.Write("thirty ");
                    if (tenthes == 4 && enterNum != 40)
                        Console.Write("fourty ");
                    if (tenthes == 5 && enterNum != 50)
                        Console.Write("fifty ");
                    if (tenthes == 6 && enterNum != 60)
                        Console.Write("sixty ");
                    if (tenthes == 7 && enterNum != 70)
                        Console.Write("seventy ");
                    if (tenthes == 8 && enterNum != 80)
                        Console.Write("eighty ");
                    if (tenthes == 9 && enterNum != 90)
                        Console.Write("ninety ");
                    if (ones == 1)
                        Console.Write("one");
                    if (ones == 2)
                        Console.Write("two");
                    if (ones == 3)
                        Console.Write("three");
                    if (ones == 4)
                        Console.Write("four");
                    if (ones == 5)
                        Console.Write("five");
                    if (ones == 6)
                        Console.Write("six");
                    if (ones == 7)
                        Console.Write("seven");
                    if (ones == 8)
                        Console.Write("eight");
                    if (ones == 9)
                        Console.Write("nine");
                    else if (enterNum == 20)
                        Console.Write("twenty");
                    else if (enterNum == 30)
                        Console.Write("thirty");
                    else if (enterNum == 40)
                        Console.Write("fourty");
                    else if (enterNum == 50)
                        Console.Write("fifty");
                    else if (enterNum == 60)
                        Console.Write("sixty");
                    else if (enterNum == 70)
                        Console.Write("seventy");
                    else if (enterNum == 80)
                        Console.Write("eighty");
                    else if (enterNum == 90)
                        Console.Write("ninety");
                    else if (enterNum == 100)
                        Console.Write("one hundred");
                }            
            }
          else 
            Console.WriteLine("invalid number");
            
        }
    }
}
