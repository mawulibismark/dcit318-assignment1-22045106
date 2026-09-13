using System;

class GradeCalculator
{
    static void Main()
    {
        Console.Write("Enter your numerical grade (0-100): ");
        double grade = Convert.ToDouble(Console.ReadLine());

        if (grade >= 90 && grade <= 100)
        {
            Console.WriteLine("Grade: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Grade: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Grade: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Grade: D");
        }
        else if (grade >= 0)
        {
            Console.WriteLine("Grade: F");
        }
        else
        {
            Console.WriteLine("Invalid grade. Please enter a value between 0 and 100.");
        }
    }
}