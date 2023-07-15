// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<int> number = new();
number.Add(1);
number.Add(2);
number.Add(3);
number.Add(4);
number.Add(5);
number.Add(6);

foreach (int numbers in number)
{
    Console.WriteLine(numbers);
}

//for, foreach

for (int i = 0; i < number.Count(); i++ )
{
    if (i == 4)
    {
        break;// Bu döngüyü sonlandırır
    }
    if (i == 2) { continue; }//Döngüde kalan kısmı atlar

Console.WriteLine(" numara : " + number[i]);
}

//while(number.Count()>0)
//{
//    Console.WriteLine("çalışıyor");
//}