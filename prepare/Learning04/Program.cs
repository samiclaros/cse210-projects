using System;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Assignment prove = new("Samuel Bennet", "Multiplication");
        Console.WriteLine(prove.GetSumary());

        MathAssignment math = new("Samuel Bennet", "Multiplication", "7.3", "8-19");
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetWritingInformation());
    }
}