using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatR.Classes
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Oparation { get; set; }

        public void GetImputs()
        {
            Console.WriteLine("Type 1st number: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Creating operation (+,-,*,/,%): ");
            Oparation = Console.ReadLine();
            Console.WriteLine("Type 2nd number: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
        }

        public bool IsFirstNumberPositive()
        {
            return FirstNumber >= 0;
        }

        public void CompareImputs()
        {
            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine($"1st number is greater than 2nd number !");
            }
            else if (FirstNumber == SecondNumber)
            {
                Console.WriteLine($"1st number is equal 2nd number !");
            }
            else
                Console.WriteLine($"1st number is less 2nd number !");
        }

        public string Calculate()
        {
            return Oparation switch
            {
                "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
                "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
                _   => "Operaton Not Found!"
            };
        }

        public void PrintEvenNumbers()
        {
            System.Console.WriteLine("Printing even numbers till first imput...");
            int counter = 1;
            while (counter < FirstNumber)
            {
                counter++;
                Console.WriteLine(counter);
                counter++;
            }
        }

        public void PrintMultiplicationTable()
        {
            for (int iterator = 1; iterator <= 10; iterator++)
            {
                for (int innerIterator = 1; innerIterator <= 10; innerIterator++)
                {
                    Console.WriteLine($"{iterator} x {innerIterator} = {iterator * innerIterator}");
                }

                Console.WriteLine("\n");
            }
        }


    }
}