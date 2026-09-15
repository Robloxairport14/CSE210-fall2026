using System;
using System.Net;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage grade did you get?: ");
        string alphaThroughFail = Console.ReadLine();
        int x = int.Parse(alphaThroughFail);
        string punctuation = "?";
        int ones = x % 10;       
        int tens = (x / 10) % 10;
        string grade = "F";
        if (x >= 90 && x <= 100)
        {
            grade = "A";
        }
        else if (x >= 80)
        {
            grade = "B";
        }
        else if (x >= 70)
        {
            grade = "C";
        }
        else if (x >= 60)
        {
            grade = "D";
        }
        if (x >= 101)
        {
            Console.WriteLine("That's impossible, try again!");
            return;            
        }
        if (ones >= 0 && ones <= 4)
        {
            if (tens <= 5)
            {
            punctuation = ".";
            }
            else{
            punctuation = "-.";
            }
        }
        else if (ones >= 5 && ones <= 7)
        {
            punctuation = ".";
        }
        else if (ones >= 8 && ones <= 9)
        {
            if (tens >= 9 || tens <= 5)
            {
            punctuation = ".";
            }
            else{
            punctuation = "+.";
            }
        }

        Console.WriteLine($"Your letter grade is {grade}{punctuation}");
    }
}