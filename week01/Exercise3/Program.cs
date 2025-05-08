using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //Console.Write("What is the magic number? ");
        //int magicnumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 11);

        int guess = -1;

        while (guess != magicnumber)
        {

            Console.Write("what is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicnumber)
            {
                Console.WriteLine("Higher");
            }

            else if(guess > magicnumber)
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