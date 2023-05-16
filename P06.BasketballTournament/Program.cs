using System;
using System.Collections.Generic;

namespace P06.BasketballTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tournamentName;

            int countWin = 0;
            int countLose = 0;

            while ((tournamentName = Console.ReadLine()) != "End of tournaments")
            {
                int matchesCount = int.Parse(Console.ReadLine());
                for (int i = 1; i <= matchesCount; i++)
                {
                    int teamDesi = int.Parse(Console.ReadLine());
                    int awayTeam = int.Parse(Console.ReadLine());

                    int pointDeference = Math.Abs(teamDesi - awayTeam);

                    if (teamDesi > awayTeam)
                    {
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: win with {pointDeference} points.");
                        countWin++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: lost with {pointDeference} points.");
                        countLose++;
                    }
                    
                }                
                
            }
            double totalGames = countLose + countWin;
                if (tournamentName == "End of tournaments")
                {
                    Console.WriteLine($"{countWin / totalGames * 100:f2}% matches win");
                    Console.WriteLine($"{ countLose / totalGames * 100 :f2}% matches lost");
                    
                }
            
           
        }
    }
}
