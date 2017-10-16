using System;
using FluentCalculator;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Eight.Plus.One.Times.Eight.Plus.Nine.Calculate());
            Console.ReadKey();
        }
    }
}
