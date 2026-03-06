using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Your Score Number: ");
        String score = Console.ReadLine();
        int scoreNum;
        bool isValid = int.TryParse(score, out scoreNum);
        
        if (isValid)
            {
                string symbol = "";
                if (scoreNum >= 90)
                    {
                        symbol = "A";
                    }
                else if(scoreNum >= 80)
                    {
                        symbol = "B";
                    }
                else if(scoreNum >= 70)
                    {
                        symbol = "C";
                    }
                else if(scoreNum >= 60)
                    {
                        symbol = "D";
                    }
                else
                    {
                        symbol = "F";
                    }
                Console.WriteLine($"your grade is {symbol}");
                if (scoreNum >= 70)
                    {
                        Console.WriteLine("Congratulations!!! You Passed!");
                    }
                else
                    {
                        Console.WriteLine($"Your grade {symbol} is below average. You failed this class. Try again next semester.");
                    }
            }
        else
            {
                Console.WriteLine("The is information you entered is invalid. Add the score you had");
            }
    }
}