using System;

namespace P04.MovieStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string actorName ;
            double actorBudget = 0;

            while ((actorName = Console.ReadLine())  != "ACTION")
            {
                actorBudget = budget * 0.20;
                if (actorName.Length <= 15)
                {
                    actorBudget = double.Parse(Console.ReadLine());
                }

                budget -= actorBudget;

                if (budget <= 0)
                {                    
                    break;
                }                
            }
            if (budget < 0)
            {
                Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");

            }
            else
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
            
        }
    }
}
