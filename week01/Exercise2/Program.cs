using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int grade))
        {
            string letter;
            string sign = ""; // default: no sign

            // Determine letter grade
            if (grade >= 90)
                letter = "A";
            else if (grade >= 80)
                letter = "B";
            else if (grade >= 70)
                letter = "C";
            else if (grade >= 60)
                letter = "D";
            else
                letter = "F";

        
            if (letter != "F") 
            {
                int lastDigit = grade % 10;

                if (lastDigit >= 7)
                    sign = "+";
                else if (lastDigit < 3)
                    sign = "-";

                if (letter == "A" && sign == "+")
                    sign = ""; 
            }
            
            Console.WriteLine($"You have got a {letter}{sign}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}