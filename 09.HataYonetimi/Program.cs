﻿Console.WriteLine("Hello, World!");

try
{
    int a = 0;
    int b = 0;
    int sonuc = a / b;
}
catch (Exception exception)
{
    Console.WriteLine($"Hata: {exception.Message}");
}
finally
{
    Console.WriteLine("Kod başarılı");
}

