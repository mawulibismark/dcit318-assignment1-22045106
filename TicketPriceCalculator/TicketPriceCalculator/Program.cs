using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 0)
        {
            Console.WriteLine("Invalid age.");
        }
        else if (age >= 65 || age <= 12)
        {
            Console.WriteLine("Ticket Price: GHC 7");
        }
        else
        {
            Console.WriteLine("Ticket Price: GHC 10");
        }
    }
}