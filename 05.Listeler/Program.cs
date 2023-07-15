// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//[] => listeleri temsil eder. => array list
// index numarası => 0'dan başlar

string[] names=new string[3];
names[0] = "Ramazan";
names[1] = "Ela";
names[2] = "Enes";

List<string> names1 = new();// örneğe dönüştürme için new kelimesi kullanılır. Instance olaral denir.
names1.Add("Ramazan");
names1.Add("Recep");


foreach (string name in names1)
{
    Console.WriteLine(name);
}