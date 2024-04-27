using myLibrary;
using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Calculator calc = new Calculator();
            Calculator calc1 = new Calculator();
            Calculator calc2 = new Calculator();
            Calculator calc3 = new Calculator();
            Calculator calc4 = new Calculator();

            calc.Add(42);

            Console.WriteLine(calc.Sum);

            Console.WriteLine(Calculator.UsageCount);
        }
    }
}
