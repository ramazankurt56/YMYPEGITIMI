namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            Console.WriteLine("Hello, World!");
            int toplam = Metot(x,y);
            Console.WriteLine("Sonuc :" + toplam);
            Metot();

        }
         static void Metot()
        {
            int sonuc =5+8;
            Console.WriteLine("Sonuc: "+sonuc);
        }
        static int Metot(int a, int b)
        {
            int sonuc = a + b;
            return sonuc;
        }
        static int Metot(int a, int b, int c)
        {
            int sonuc = a + b + c;
            return sonuc;
        }
    }
}