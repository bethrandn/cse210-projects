using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade score scale is listed as follow: ");
        Console.WriteLine(".A >= 90");
        Console.WriteLine(".B >= 80");
        Console.WriteLine(".C >= 70");
        Console.WriteLine(".D >= 60");
        Console.WriteLine(".F < 60");
        Console.Write("What is your grade percentage?: ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
        string letter;

        string sign = "";

        int lastDigit = x % 10;

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        // Separate if statement


        if (letter != "F")
        {
            if (letter == "A" && x >= 93)
            {
                sign = "";
            }

            else if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit <3)
            {
                sign ="-";
            }
        }
            Console.WriteLine($"Your grade is {letter}{sign}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }

        else
        {
            Console.WriteLine("Don't give up. Keep working hard, and you'll do better next time!");
        }

    }
}