System.Console.Write("Birinchi raqamni kiriting => ");
int birinchiRaqam= Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ikkinchi raqamni kiriting => ");
int ikkinchiRaqam= Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ikki sonning yig'indisi {birinchiRaqam+ikkinchiRaqam}");
Console.WriteLine($"Ikki sonning ayirmasi {birinchiRaqam-ikkinchiRaqam}");
Console.WriteLine($"Ikki sonning ko'paytmasi {birinchiRaqam*ikkinchiRaqam}");
Console.WriteLine($"Ikki sonning qoldiqsiz bo'linmasi {birinchiRaqam/ikkinchiRaqam}");
Console.WriteLine($"Ikki sonning qoldiqli bo'linmasi {birinchiRaqam%ikkinchiRaqam}");