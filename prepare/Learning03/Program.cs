using System;

class Program
{
    static void Main(string[] args)
    {
        // Paso 1
        Fraction fraction = new();
        Fraction fraction1 = new(5);
        Fraction fraction2 = new(3, 4);
        Fraction fraction3 = new(1, 3);
        // fraction.Print();
        // fraction1.Print();
        // fraction2.Print();
        
        // Paso 2
        // fraction.SetTopNumber(4);
        // fraction1.SetTopNumber(2);
        // fraction2.SetTopNumber(3);
        // fraction2.SetBottomNumber(2);
        // Console.WriteLine(fraction.ReturnTopNumber());
        // Console.WriteLine(fraction1.ReturnTopNumber());
        // Console.WriteLine(fraction2.ReturnTopNumber());
        // Console.WriteLine(fraction2.ReturnBottomNumber());

        // Paso 3 TODO JUNTO
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
        // fraction.SetTopNumber(1);
        // Console.WriteLine(fraction.ReturnTopNumber());

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        // fraction1.SetTopNumber(5);
        // Console.WriteLine(fraction1.ReturnTopNumber());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        // fraction2.SetTopNumber(3);
        // fraction2.SetBottomNumber(4);
        // Console.WriteLine(fraction2.ReturnTopNumber());
        // Console.WriteLine(fraction2.ReturnBottomNumber());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        // To whom see the comments: I tried using the getters and setters, It worked too
        // but the way now it's working without the code in hte comments is more
        // easy to understand

    }
}