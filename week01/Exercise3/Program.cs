using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter magic number Between 1 and 11");        
        Random randomGenerator = new Random();
        int number = randomGenerator .Next(1, 11);
        int guessMagic = 0;
        while (guessMagic != number)
        {
            Console.Write("Enter your guess: ");
            guessMagic = Convert.ToInt32(Console.ReadLine());

            if (guessMagic > number)
                {
                    Console.WriteLine("Lower");
                }
            else if(guessMagic < number)
                {
                    Console.WriteLine("higher");
                }
            else
                {
                    Console.WriteLine("Congratulations");
                }
        }
        Console.WriteLine($"The Guess {number} is correct");
    }
}