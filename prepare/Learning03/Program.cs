using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        string s1 = f1.GetFractionString();
        double s1_1 = f1.GetDecimalValue();
        Console.WriteLine($"{s1}");
        Console.WriteLine($"{s1_1}");

        Fraction f2 = new Fraction(5);
        string s2 = f2.GetFractionString();
        double s2_2 = f2.GetDecimalValue();
        Console.WriteLine($"{s2}");
        Console.WriteLine($"{s2_2}");

        Fraction f3 = new Fraction(3,4);
        string s3 = f3.GetFractionString();
        double s3_3 = f3.GetDecimalValue();
        Console.WriteLine($"{s3}");
        Console.WriteLine($"{s3_3}");

        Fraction f4 = new Fraction(1,3);
        string s4 = f4.GetFractionString();
        double s4_4 = f4.GetDecimalValue();
        Console.WriteLine($"{s4}");
        Console.WriteLine($"{s4_4}");

        Random random = new Random();
        Fraction f5 = new Fraction();
        for (int i = 0; i < 20; i++)
        {
            int topValue = random.Next(1, 11);
            int bottomValue = random.Next(1, 11);
            f5.SetTop(topValue);
            f5.SetBottom(bottomValue);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {f5.GetFractionString()}");
            Console.WriteLine($" Number: {f5.GetDecimalValue()}");
        }
    }
}