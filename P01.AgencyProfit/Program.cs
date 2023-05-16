using System;

namespace P01.AgencyProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string airline = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());    
            int kidTickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            double serviseTax = double.Parse(Console.ReadLine());

           
            double kidTicketsPrice = ticketPrice - (ticketPrice * 0.7);
            kidTicketsPrice += serviseTax;
            ticketPrice += serviseTax;
            double totalPrice = (tickets * ticketPrice) + (kidTickets * kidTicketsPrice);

            Console.WriteLine($"The profit of your agency from {airline} tickets is {totalPrice * 0.2:f2} lv.");
        }
    }
}
