using System;

namespace P02.CatWalking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutsForWalk = int.Parse(Console.ReadLine());
            int walksPerDay = int.Parse(Console.ReadLine());
            int caloriesForDay = int.Parse(Console.ReadLine());

            double totalMinutes = minutsForWalk * walksPerDay;
            double caloriesBurn = totalMinutes * 5;
            double halfCalories = caloriesForDay * 0.50;

            if (caloriesBurn >= halfCalories)
            {
                    Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurn}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurn}.");
            } 
            
        }
    }
}
