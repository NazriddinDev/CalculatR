﻿using System;

Console.Write("Birinchi raqamni kiriting => ");
int birinchiRaqam= Convert.ToInt32(Console.ReadLine());
Console.Write("Ikkinchi raqamni kiriting => ");
int ikkinchiRaqam= Convert.ToInt32(Console.ReadLine());

if(birinchiRaqam>ikkinchiRaqam)
{
    Console.WriteLine("Birinchi son ikkinchisidan katta...");
}
else if(birinchiRaqam==ikkinchiRaqam)
{
    Console.WriteLine("Ikkala son o'zaro teng...");
}
else
{
    Console.WriteLine("Birinchi son ikkinchisidan kichik...");
}

Console.WriteLine($"Ikki sonning yig'indisi {birinchiRaqam+ikkinchiRaqam}");
Console.WriteLine($"Ikki sonning ayirmasi {birinchiRaqam-ikkinchiRaqam}");
Console.WriteLine($"Ikki sonning ko'paytmasi {birinchiRaqam*ikkinchiRaqam}");
Console.WriteLine($"Ikki sonning qoldiqsiz bo'linmasi {birinchiRaqam/ikkinchiRaqam}");
Console.WriteLine($"Ikki sonning qoldiqli bo'linmasi {birinchiRaqam%ikkinchiRaqam}");

// Console.WriteLine($"Birinchi raqam ikkinchi raqamdan katta {birinchiRaqam > ikkinchiRaqam}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqamdan katta yoki teng {birinchiRaqam >= ikkinchiRaqam}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqamdan kichik {birinchiRaqam > ikkinchiRaqam}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqamdan kichik yoki teng {birinchiRaqam <= ikkinchiRaqam}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqam teng {birinchiRaqam == ikkinchiRaqam}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqam teng emas {birinchiRaqam != ikkinchiRaqam}");