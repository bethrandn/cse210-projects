using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction first = new Fraction();

        Console.WriteLine(first.GetFractionString());   
        Console.WriteLine(first.GetDecimalValue());     

        
        Fraction second = new Fraction(5);
        Console.WriteLine(second.GetFractionString());  
        Console.WriteLine(second.GetDecimalValue());    

        
        Fraction third = new Fraction(3, 4);
        Console.WriteLine(third.GetFractionString());   
        Console.WriteLine(third.GetDecimalValue());

        Fraction four = new Fraction();
        four.SetTop(1);
        four.SetBottom(3);   

        Console.WriteLine(four.GetTop()); 
        Console.WriteLine(four.GetBottom());

        Console.WriteLine(four.GetFractionString());
        Console.WriteLine(four.GetDecimalValue()); 

    }
}
