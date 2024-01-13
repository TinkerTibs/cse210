using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Hello Prep5 World!");


        // functions for assignment

        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareUserNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }



        // welcome message 
    static void DisplayWelcomeMessage()

    {
        Console.WriteLine("Welcome to the program!");
    }



        // user name
    static string PromptUserName()

    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }



    // user number
    static int PromptUserNumber()

    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }



    // square the users number
    static int SquareUserNumber(int number)

    {
        int square = number * number;
        return square;
    }



    // display result
    static void DisplayResult(string name, int square)
    
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }


    
}