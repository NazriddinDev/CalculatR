using System;
using CalculatR.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Security security = new Security();
        Calculator calculator = new Calculator();
        security.CheckPassword();
        calculator.GetImputs();

        string message =
            !(calculator.IsFirstNumberPositive()) //|| SecondNumber >= 0
                ? "1st number is not positive"
                : "1st number is not negative";
        Console.WriteLine(message);

        calculator.CompareImputs();
        string result = calculator.Calculate();

        Console.WriteLine(result);
        calculator.PrintEvenNumbers();
        calculator.PrintMultiplicationTable();

    }
}