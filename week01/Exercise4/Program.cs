using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("WHAT IS THE NUMBER GAME");


        int number = 0;

        Console.Write("Enter a list of numbers, type 0 when finished. ");
        number = int.Parse(Console.ReadLine());
        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Choose another number? ");
            number = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        foreach (int item in numbers)
        {
            sum += item;
        }
        Console.WriteLine($"The sum is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largest = numbers[0];
        foreach (int item in numbers)
        {
            if (item > largest)
            {
                largest = item;
            }
        }
        Console.WriteLine($"The Largest number is: {largest}");

        int smallestPositive = int.MaxValue;
        foreach (int item in numbers)
        {
            if (item > 0 && item < smallestPositive)
            {
                smallestPositive = item;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }   

    }
}