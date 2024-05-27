﻿using System;

//loops - aylanma. do while
string password;
Console.WriteLine("Parolni kiriting...");
do
{
    password = Console.ReadLine();
}while(password!="pa$$word");

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

//Array
int[] sonlar = new int[10];
System.Console.WriteLine("10 ta son kiriting ...");
sonlar[0] = 2;
sonlar[1] = 2;
sonlar[2] = 3;
sonlar[3] = 4;
sonlar[4] = 5;
sonlar[5] = 6;
sonlar[6] = 7;
sonlar[7] = 8;
sonlar[8] = 0;
sonlar[9] = 19;

//for
for(int i = 0; i < sonlar.Length; i++)
{
    Console.WriteLine(sonlar[i]);
}

//foreach
foreach(int son in sonlar)
{
    Console.WriteLine(son);
}