//sort
int[] sayiDizisi= {22,13,15,6,17,20,14};


Console.WriteLine("****SIRASIZ DİZİ****");
foreach (var i in sayiDizisi)
{
    Console.WriteLine(i);
}

Console.WriteLine("****SIRALI DİZİ****");
Array.Sort(sayiDizisi);

foreach (var i in sayiDizisi)
{
    Console.WriteLine(i);
}


//clear

Console.WriteLine("****ARRAY CLEAR****");
Array.Clear(sayiDizisi,1,2);//1. indexten itibaren 2 elemanı sıfırlar

foreach (var i in sayiDizisi)
{
    Console.WriteLine(i);
}

//reverse
Console.WriteLine("****ARRAY REVERSE****");

Array.Reverse(sayiDizisi);

foreach (var i in sayiDizisi)
{
    Console.WriteLine(i);
}


//indexOf
Console.WriteLine("****ARRAY İNDEXOF***");


Console.WriteLine(Array.IndexOf(sayiDizisi,22));


//resize
Console.WriteLine("****ARRAY RESİZE****");

Array.Resize<int>(ref sayiDizisi,9);//dizinin boyutunu 9 yapıyor
sayiDizisi[8]=99;

Console.WriteLine(sayiDizisi.Length);
