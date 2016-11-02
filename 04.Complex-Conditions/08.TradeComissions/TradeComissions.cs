using System; 

namespace _08.TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            if(town=="sofia")
            {
                if (sales >=0 && sales <=500)
                {
                    Console.WriteLine(Math.Round((sales*0.05),2));
                }
                else if (sales >= 500 && sales <= 1000)
                {
                    Console.WriteLine(Math.Round((sales * 0.07), 2));
                }
                else if (sales >= 1000 && sales <= 10000)
                {
                    Console.WriteLine(Math.Round((sales * 0.08), 2));
                }
                else if (sales >= 10000)
                {
                    Console.WriteLine(Math.Round((sales * 0.12), 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine(Math.Round((sales * 0.045), 2));
                }
                else if (sales >= 500 && sales <= 1000)
                {
                    Console.WriteLine(Math.Round((sales * 0.075), 2));
                }
                else if (sales >= 1000 && sales <= 10000)
                {
                    Console.WriteLine(Math.Round((sales * 0.10), 2));
                }
                else if (sales >= 10000)
                {
                    Console.WriteLine(Math.Round((sales * 0.13), 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine(Math.Round((sales * 0.055), 2));
                }
                else if (sales >= 500 && sales <= 1000)
                {
                    Console.WriteLine(Math.Round((sales * 0.08), 2));
                }
                else if (sales >= 1000 && sales <= 10000)
                {
                    Console.WriteLine(Math.Round((sales * 0.12), 2));
                }
                else if (sales >= 10000)
                {
                    Console.WriteLine(Math.Round((sales * 0.145), 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
