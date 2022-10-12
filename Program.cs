string password = "";

do
{
    System.Console.WriteLine("Enter password: ");
    password=Console.ReadLine();
}while(password != "p@ssword");

System.Console.WriteLine("Type 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Creating operation (+,-,*,/,%): ");
string operation = Console.ReadLine();
System.Console.WriteLine("Type 2nd number: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

string message = 
    !(firstNumber >= 0) //|| SecondNumber >= 0
        ? "1st number is not positive"
        : "1st number is not negative";

System.Console.WriteLine(message);

if(firstNumber>SecondNumber)
{
    System.Console.WriteLine($"1st number is greater than 2nd number !");
}
else if(firstNumber == SecondNumber)
{
    System.Console.WriteLine($"1st number is equal 2nd number !");
}
else
System.Console.WriteLine($"1st number is less 2nd number !");

string result = operation switch
{
"+" => $"{firstNumber} + {SecondNumber} = {firstNumber + SecondNumber}",
"-" => $"{firstNumber} - {SecondNumber} = {firstNumber - SecondNumber}",
"*" => $"{firstNumber} * {SecondNumber} = {firstNumber * SecondNumber}",
"/" => $"{firstNumber} / {SecondNumber} = {firstNumber / SecondNumber}"
};

System.Console.WriteLine(result);

// switch(operation)
// {
//     case "+":
//         System.Console.WriteLine($"{firstNumber}+{SecondNumber}={firstNumber+SecondNumber}");
//         break;
//     case "-":
//         System.Console.WriteLine($"{firstNumber}-{SecondNumber}={firstNumber-SecondNumber}");
//         break;
//     case "*":
//         System.Console.WriteLine($"{firstNumber}*{SecondNumber}={firstNumber*SecondNumber}");
//         break;
//     case "/":
//         System.Console.WriteLine($"{firstNumber}/{SecondNumber}={firstNumber/SecondNumber}");
//         break;
//     case "%":
//         System.Console.WriteLine($"{firstNumber}%{SecondNumber}={firstNumber%SecondNumber}");
//         break;
//     default:
//         System.Console.WriteLine("Operation Not Found!");
//         break;
// }


if(firstNumber>0)
{
    int counter = 1;
    while(counter < firstNumber)
    {
        counter++;
        System.Console.WriteLine(counter);
        counter++;
    }
}

for(int iterator = 1; iterator <=10; iterator++)
{
    for(int innerIterator = 1; innerIterator <= 10; innerIterator++)
    {
        System.Console.WriteLine($"{iterator} x {innerIterator} = {iterator * innerIterator}");
    }

    System.Console.WriteLine("\n");
}