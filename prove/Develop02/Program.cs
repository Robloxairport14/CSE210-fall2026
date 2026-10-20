using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal=new Journal();
        Console.WriteLine("Hello");
        
        int choice;
        do        
        {
            Console.Write(@"
Please Choose:
1. Write
2. Display
3. Save
4. Load
5. Quit
Your Choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                journal.AddEntry();
            }
            else if (choice == 2)
            {
                journal.DisplayEntry();
            }
            else if (choice == 3)
            {
                journal.SaveEntry();
            }
            else if (choice == 4)
            {
                journal.LoadJournal();
            }
            
        }
        while (choice == 1 || choice == 2 || choice == 3 || choice == 4);
        
    }
}