using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter the first side: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second side: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third side: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Invalid sides. All sides must be greater than 0.");
        }
        else if (side1 + side2 <= side3 ||
                 side1 + side3 <= side2 ||
                 side2 + side3 <= side1)
        {
            Console.WriteLine("The sides do not form a valid triangle.");
        }
        else if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("Triangle Type: Equilateral");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("Triangle Type: Isosceles");
        }
        else
        {
            Console.WriteLine("Triangle Type: Scalene");
        }
    }
}