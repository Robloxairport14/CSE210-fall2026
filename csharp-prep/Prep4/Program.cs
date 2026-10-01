using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int g=1;
        int n=0;
        List<int> num;
        num = new List<int>();
        while(g!=0)
        {
            Console.Write("Enter number:");
            string liist = Console.ReadLine();
            n = int.Parse(liist);
            num.Add(n);
            if (n == 0)
            {
                g=0;
            }
        }
        // foreach (int n in ns)
        // {
        //     Console.WriteLine(n);
        // }
        Console.WriteLine($"The Sum is:{num.Sum()}");
        Console.WriteLine($"The Average is:{num.Average()}");
        Console.WriteLine($"The Large Number is:{num.Max()}");
        Console.WriteLine($"The small Number is:{num.Min()}");
        Console.WriteLine($"The sorted list is:");
        num.Sort();
        for (int i = 0; i < num.Count; i++)
        {
            Console.WriteLine(num[i]);
        }



    }
}


// num+num+num