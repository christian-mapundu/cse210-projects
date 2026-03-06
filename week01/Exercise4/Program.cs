using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        while (!(numbers.Contains(0)))
        // the loop will continue until the user enters 0
            {
                Console.Write("Enter a number of Your choice: ");
                int userNumbers = int.Parse(Console.ReadLine());
                numbers.Add(userNumbers);
            }
    //int sum = numbers.Sum();
        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
            {
                sum = sum + numbers[i];
            }
        Console.WriteLine();
        Console.WriteLine("The sum is " + sum);
        Console.WriteLine("The average is: " + sum / numbers.Count);
        int largest = numbers.Max();
        Console.WriteLine("The largest number is: " +  largest);
        numbers.Sort();
        Console.WriteLine();
    }
}