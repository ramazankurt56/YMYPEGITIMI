
Console.WriteLine("Lütfen isminizi giriniz");
string name = Console.ReadLine();
Console.WriteLine("Sayı tahmin oyununa hoşgeldiniz." + name);

Random rasgele = new();
int sayi = rasgele.Next(1, 10);
int tahmin = 0;
int deneme = 0;

while (sayi != tahmin)
{
    Console.WriteLine("Lütfen 1-10 arasında bir sayı tahmin edin");

    string tahminEdilenSayi = Console.ReadLine();
    Console.WriteLine("Tahminim: " + tahminEdilenSayi);

    if (int.TryParse(tahminEdilenSayi, out tahmin) == false)
    {
        Console.WriteLine("Sadece rakam girebilirsiniz");
        continue;
    }
    else if (tahmin > 10)
    {
        Console.WriteLine("Lütfen 1-10 arası rakam giriniz");
        continue;
    }
    if (sayi == tahmin)
    {
        Console.WriteLine($"Sayıyı doğru tahmin ettiniz {deneme}. denemede bildiniz");
        tahmin = sayi;
        continue;
    }

    Console.WriteLine("Sayıyı yanlış tahmin ettiniz tekrar nedeyiniz");

    deneme++;

}



