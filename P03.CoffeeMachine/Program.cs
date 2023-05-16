using System;

namespace P03.CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string shugar = Console.ReadLine();
            int drinkCount = int.Parse(Console.ReadLine());
            //"Espresso", "Cappuccino" или "Tea"
            //"Without", "Normal" или "Extra"
            // double priceEspresso = 0;
            // double priceCappuccino = 0;
            // double priceTea = 0;
            double drinkPrice = 0;
            if (drink == "Espresso")
            {
                if (shugar == "Without")
                { 
                  drinkPrice   = 0.90;
                }
                else if (shugar == "Normal")
                {
                    drinkPrice = 1;
                }
                else if (shugar == "Extra")
                {
                    drinkPrice = 1.20;
                }
            }
            else if (drink == "Cappuccino")
            {
                if (shugar == "Without")
                {
                    drinkPrice = 1;
                }
                else if (shugar == "Normal")
                {
                    drinkPrice = 1.20;
                }
                else if (shugar == "Extra")
                {
                    drinkPrice = 1.60;
                }
            }
            else if (drink == "Tea")
            {
                if (shugar == "Without")
                {
                    drinkPrice = 0.50;
                }
                else if (shugar == "Normal")
                {
                    drinkPrice = 0.60;
                }
                else if (shugar == "Extra")
                {
                    drinkPrice = 0.70;
                }
            }

                double totalPrice = drinkPrice * drinkCount;

            if (shugar == "Without")
            {
                totalPrice -= totalPrice * 0.35;
            }

            


            if (drink == "Espresso" && drinkCount >= 5)
            {
                   totalPrice -= totalPrice * 0.25;
            }

            if (totalPrice > 15)
            {
                totalPrice -= totalPrice * 0.20;
            }


            Console.WriteLine($"You bought {drinkCount} cups of {drink} for {totalPrice:f2} lv.");

        }   
    }
}
