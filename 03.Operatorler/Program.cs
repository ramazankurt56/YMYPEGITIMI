// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Operatörler
//= :Eşittir operatörü=> Değer ataması yapar
//== kontrol operatörü => a ve b değerini konrtol eder.

int a = 0;
int b = 1;
bool c = (a == b);
// / * - +
Console.WriteLine(c);
int r = ((5 * 2) + 2) - 3;
//+=
//-=
int z = 1;
z += 5; //===> z=z+5;
//++
//--
int x = 1;
x++;
x--;

// + operatörü string değerlerde birleştirme işlemi yapar

string name = "Ramazan" + "  " + "Kurt";
Console.WriteLine(name);
string name2 = $"{name} 25 yaşında";
Console.WriteLine(name2);

// % => mod operatörü sayının verilen sayıya tam bölünüp bölünmediğinden bahsediyor

// @ operatörü \\ işaretini kullanabilmemiz için @ operatörünü kullanırız.