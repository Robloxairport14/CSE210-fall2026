using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("1");
        
        
        Console.Write("Do you want '1' or 'both' verses? :");
        string answer = Console.ReadLine();
        
        if (answer == "1")
        {
            Reference reference1 = new Reference("Proverbs", 3, 5);
            reference1.Display();
        }
        else if (answer == "both")
        {
            scripture = new Scripture("both");
            Reference referenceboth = new Reference("Proverbs", 3, 5, 6);
            referenceboth.Display();
            
        }
        else
        {
            Console.WriteLine("That was not an option I gave you!");
        }
        
        Console.WriteLine("'Enter' or type 'quit'");
        string enter = Console.ReadLine();
        while (enter == "")
            {
            Console.Clear();
            scripture.Random();
            scripture.Display(); 
            enter = Console.ReadLine();
            }
        if (enter== "quit")
            {
                Console.Clear();
                Console.WriteLine("good bye");
            }
    }
}