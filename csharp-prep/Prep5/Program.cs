using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
        Console.WriteLine("Welcome to the program!");
        return;
        }
        string PromptUserName()
        {
        Console.Write("Please enter your name: ");
        string Name = Console.ReadLine();
        return Name;
        }
        int PromptUserNumber()
        {
        Console.Write("Please enter your favorite number: ");
        string liist = Console.ReadLine();
        int n = int.Parse(liist);
        return n;
        }
        int PromptUserBirthYear(string Name)
        {
        Console.Write("Please enter the year you were born: ");
        string born = Console.ReadLine();
        int b = int.Parse(born);
        int old = 2026- b;
        // Console.WriteLine($"{Name}, you will turn {old} this year.");
        return old;
        }
        int SquareNumber(int n , string Name)
        {
            int Squ = n*n;
            Console.WriteLine($"{Name}, the quare of your number is {Squ}.");
            return Squ;
        }
        void DisplayResult()
        {
            DisplayWelcome();
            string Name = PromptUserName();
            int n= PromptUserNumber();
            int BY=PromptUserBirthYear(Name);
            int Squ= SquareNumber(n, Name);
            Console.WriteLine($"{Name},you will turn {BY} this year.");
        }

        DisplayResult();
    }
}


// Console.WriteLine("Welcome to the program!");
//         Console.Write("Please enter your name: ");
//         string Name = Console.ReadLine();
//         Console.Write("Please enter your favorite number: ");
//         string liist = Console.ReadLine();
//         int n = int.Parse(liist);
//         Console.Write("Please enter the year you were born: ");
//         string born = Console.ReadLine();
//         int b = int.Parse(born);