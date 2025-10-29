using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign
        if (letter != "F" && letter != "A")
        {
            int lastDigit = percentage % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A")
        {
            int lastDigit = percentage % 10;
            if (lastDigit >= 7)
            {
                sign = ""; // No A+
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Display the grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Check if the student passed or failed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you've passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, you've failed the course. Better luck next time!");
        }
    }
}


