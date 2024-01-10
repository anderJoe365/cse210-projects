using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);

        int number = 0;

        while (number != magic)
        {

            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            number = int.Parse(guess);

            if (number > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (number < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (number == magic)
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}