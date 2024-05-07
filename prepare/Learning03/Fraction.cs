using System.Diagnostics.Contracts;
using System.Globalization;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    
    // public void Print()
    // {
    //     Console.WriteLine($"{_top}/{_bottom}");
    // }

    // public int ReturnTopNumber()
    // {
    //     return _top;
    // }

    // public int ReturnBottomNumber()
    // {
    //     return _bottom;
    // }

    // public void SetTopNumber(int topNumber)
    // {
    //     _top = topNumber;
    // }

    // public void SetBottomNumber(int bottomNumber)
    // {
    //     _bottom = bottomNumber;
    // }

    public string GetFractionString()
    {
        // Esta parte hizo el profe
        string text = $"{_top}/{_bottom}";
        return text;
        //
        // return _top + "/" + _bottom; ----> Esto hice yo, esta mal xd
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / _bottom; 
        return decimalValue;
    }

}