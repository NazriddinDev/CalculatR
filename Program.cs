﻿using System;

Console.Write("Birinchi raqamni kiriting => ");
int birinchiRaqam= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Operatsiya turini kiriting => +,-,*,/,%");
string operatsiya = Console.ReadLine();
Console.Write("Ikkinchi raqamni kiriting => ");
int ikkinchiRaqam= Convert.ToInt32(Console.ReadLine());

//ternary operator
string result =
    birinchiRaqam >= ikkinchiRaqam
        ? "Birinchi son ikkinchisidan katta..."
        : "Birinchi son ikkinchisidan kichik...";
        Console.WriteLine(result);

//switch expressions
string natija = operatsiya switch
{
    "+" => $"Ikki sonning yig'indisi {birinchiRaqam+ikkinchiRaqam}",
    "-" => $"Ikki sonning ayirmasi {birinchiRaqam-ikkinchiRaqam}",
    "*" => $"Ikki sonning ko'paytmasi {birinchiRaqam*ikkinchiRaqam}",
    "/" => $"Ikki sonning qoldiqsiz bo'linmasi {birinchiRaqam/ikkinchiRaqam}",
    "%" => $"Ikki sonning qoldiqli bo'linmasi {birinchiRaqam%ikkinchiRaqam}",
    _ => "Operatsiya turi topilmadi...",
};

Console.WriteLine(natija);

//loops - aylanma. while
int counter = 1;
    while(counter < birinchiRaqam)
    {
        if(counter % 2 == 0)    
        {
            Console.WriteLine(counter);
        }    
        counter++;
    };          

//loops - aylanma. do while
    string password;
do
{
    password = Console.ReadLine();
}while(password!="pa$$word");

// //switch care operation
// switch(operatsiya)
// {
//     case "+":
//         Console.WriteLine($"Ikki sonning yig'indisi {birinchiRaqam+ikkinchiRaqam}");
//         break;
//     case "-":
//         Console.WriteLine($"Ikki sonning ayirmasi {birinchiRaqam-ikkinchiRaqam}");
//         break;
//     case "*":
//         Console.WriteLine($"Ikki sonning ko'paytmasi {birinchiRaqam*ikkinchiRaqam}");
//         break;
//     case "/":
//         Console.WriteLine($"Ikki sonning qoldiqsiz bo'linmasi {birinchiRaqam/ikkinchiRaqam}");
//         break;
//     case "%":
//         Console.WriteLine($"Ikki sonning qoldiqli bo'linmasi {birinchiRaqam%ikkinchiRaqam}");
//         break;
//         default:
//             Console.WriteLine("Operatsiya turi topilmadi...");
//             break;
// }

// if(birinchiRaqam>ikkinchiRaqam)
// {
//     Console.WriteLine("Birinchi son ikkinchisidan katta...");
// }
// else if(birinchiRaqam==ikkinchiRaqam)    
// {
//     Console.WriteLine("Ikkala son o'zaro teng...");
// }
// else
// {
//     Console.WriteLine("Birinchi son ikkinchisidan kichik...");
// }

// Console.WriteLine($"Ikki sonning yig'indisi {birinchiRaqam+ikkinchiRaqam}");
// Console.WriteLine($"Ikki sonning ayirmasi {birinchiRaqam-ikkinchiRaqam}");
// Console.WriteLine($"Ikki sonning ko'paytmasi {birinchiRaqam*ikkinchiRaqam}");
// Console.WriteLine($"Ikki sonning qoldiqsiz bo'linmasi {birinchiRaqam/ikkinchiRaqam}");
// Console.WriteLine($"Ikki sonning qoldiqli bo'linmasi {birinchiRaqam%ikkinchiRaqam}");

// Console.WriteLine($"Birinchi raqam ikkinchi raqamdan katta {birinchiRaqam > ikkinchiRaqam}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqamdan katta yoki teng {birinchiRaqam >= ikkinchiRaqam}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqamdan kichik {birinchiRaqam > ikkinchiRaqam}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqamdan kichik yoki teng {birinchiRaqam <= ikkinchiRaqam}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqam teng {birinchiRaqam == ikkinchiRaqam}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqam teng emas {birinchiRaqam != ikkinchiRaqam}");