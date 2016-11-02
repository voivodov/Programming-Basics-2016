using System; 

namespace _13.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();//visokosna ili ne 
            double p = double.Parse(Console.ReadLine()); //praznici v godinata
            double h = double.Parse(Console.ReadLine()); //weekendi koito patuva
            double weekends = (48.0 - h) * 3.0 / 4.0;
            double sofiaPlays = p * 2.0 / 3.0;
            double totalGames = weekends + sofiaPlays + h;

            if (year == "leap") { totalGames = totalGames * 1.15; }

            Console.WriteLine(Math.Truncate(totalGames));
            
        }
    }
}
