using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");



        //asking for numbers from user

        List<int> numbers = new List<int>();
        
        int userInput = -2;
        while (userInput != 0)
        {
            Console.Write("Enter a number (or 0 to stop): ");
            
            string userNumbers = Console.ReadLine();
            userInput = int.Parse(userNumbers);
            
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

        }



        // part 1: sum

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");



        // part 2: average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");



        //part 3: max
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");




    }
}