using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? :");
        // string magic = Console.ReadLine();
        Random r = new Random();
        int m = r.Next(1, 101);
        // int m = int.Parse(magic);
        int g=0;
        while (m != g)
        {
            Console.Write("What is your guess? :");
            string guess = Console.ReadLine();
            g = int.Parse(guess);


            if (m == g)
            {
                Console.WriteLine("It works");
            }
            else if (m > g)
            {
                Console.WriteLine("Higher");
            }
            else if (m < g)
            {
                Console.WriteLine("Lower");
            }        
            
        } 
    }
}