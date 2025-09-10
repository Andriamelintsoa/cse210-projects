using System;

class Program
{
    static void Main(string[] args)
    {
        // Asking the user for their name 
        Console.Write("What is your first_name ? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name ? ");
        string last_name = Console.ReadLine();

       Console.WriteLine($"Your first name is {first_name},{first_name} {last_name}");
    }
}