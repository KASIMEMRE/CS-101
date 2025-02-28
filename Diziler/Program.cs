//aynı tipteki değişkenleri bellekte arka arkaya saklamak istediğimizde bellekte dizileri kullanırız.
string[] renkler = new string[5];
string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};


int[] dizi;
dizi = new int[5];


//Dizilere değer atama ve erişim
renkler[0] = "Mavi";

Console.WriteLine(hayvanlar[1]);

dizi[3] = 10;
Console.WriteLine(dizi[2]);


//Döngüler ve Diziler
//For
Console.WriteLine("Dizinin eleman sayısını giriniz: ");
int n = int.Parse(Console.ReadLine());

int[] dizi1 ;
dizi1 = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Dizinin " + i + ". elemanını giriniz: ");
    dizi1[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(dizi1);



