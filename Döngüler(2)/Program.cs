using System;
using System.Runtime;
//while

Console.WriteLine("Lütfen bir sayı giriniz: ");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;
while (sayac <= sayi)
{
    toplam += sayac;
    sayac++;
}
Console.WriteLine("Toplam: " + toplam);

char character = 'a';
while (character <= 'z')
{
    Console.WriteLine(character);
    character++;
}

Console.WriteLine("*******FOREACH********");

string [] arabalar = {"BMW", "Mercedes", "Audi", "Toyota"};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}
