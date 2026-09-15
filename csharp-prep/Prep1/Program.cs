using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your 1st name?: ");
        string First = Console.ReadLine(); 
        Console.Write("what is your Last name?: ");
        string Last = Console.ReadLine();
        Console.WriteLine($"Your name is {Last}, {First} {Last}");
    }
}