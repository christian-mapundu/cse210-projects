using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName()
    {
        Console.Write("Enter Your Username: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter Your Favorite Number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber;
    }
    static int SquareNumber(int number)
    {
        int squareNum = number * number;
        return squareNum;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}