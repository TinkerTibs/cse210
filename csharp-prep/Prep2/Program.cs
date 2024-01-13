using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage?");
        string percentresponse = Console.ReadLine();
        int percent = int.Parse(percentresponse);

        string lettergrade = "";

        if (percent >= 90)
        {
            lettergrade = "A";
        }
        else if (percent >= 80)
        {
            lettergrade = "B";
        }
        else if (percent >= 70)
        {
            lettergrade = "C";
        }
        else if (percent >= 60)
        {
            lettergrade = "D";
        }
        else
        {
            lettergrade = "F";
        }

        Console.WriteLine($"Your grade is: {lettergrade}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Try better next time, you can do it!");
        }

    }
}