using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // part 1 and 2

        // Console.Write("What is the magic number? ");
        // int magicNum = int.Parse(Console.ReadLine());
        



        // part 3

        Random randomNum = new Random();
        int magicNum = randomNum.Next(1, 101);

        int guess = -2;

        
        while (guess != magicNum)
        {
            Console.Write("Guess a number between 1 and 100: ");
            guess = int.Parse(Console.ReadLine());

            if (magicNum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }



    }
}