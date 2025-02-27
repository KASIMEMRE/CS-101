//.net kurabilmek için terminale git ve dosya içerisine "dotnet new console" yaz.
//dotnet run yazarak çalıştırabilirsin.
//dotnet run --project "dosya adı" yazarak çalıştırabilirsin.
//dotnet run --project "dosya adı" --framework "netcoreapp3.1" yazarak çalıştırabilirsin.

using System;
// Console.WriteLine("Hello, World!");

// Console.WriteLine("isminiz yazınız:");
// string isim = Console.ReadLine();
// Console.WriteLine("Merhaba " + isim);





//DEĞİŞKENLER VE VERİ TİPLERİ


//Değişkenler bizim için çok önemli
//veri tutucularımızdır,her birinin bellekte bir adresi vardır.
//veri tipleri: int, string, double, float, char, bool bunların ne olduğunu ne işe yaradığını ve nasıl kullanılacağını bilmemiz gerekiyor

class Değişkenler
{
	static void Main(string[] args)
	{
		int a = 5;
        string b = "Merhaba";
        double c = 5.5;
        float d = 5.5f;
        char e = 'A';
        bool f = true;
        byte g = 255; // 1byte yer kaplar
        short h = 32767; // 2byte yer kaplar
        int i = 2147483647; // 4byte yer kaplar
        long j = 9223372036854775807; // 8byte yer kaplar
        


        DateTime tarih = DateTime.Now;
        


        object obj = "Merhaba";


        string str = string.Empty;
        str = "Merhaba";

        string name = "Mehmet";
        string surname = "Kara";
        string fullName = name + " " + surname;
        



        int number1 = 5;
        int number2 = 10;
        int result = number1 + number2;


        int number3 = 5;
        int number4 = 10;

        bool doğruMU  = number3 < number4;



        //DEĞİŞKE DÖNÜŞÜMLERİ

        string str20 = "20";
        int int20 = 25;

        string yeniDeger = str20 + int20.ToString(); //int değeri string değere dönüştürdük
        

        int int21 = int20 + Convert.ToInt32(str20); //string değeri int değere dönüştürdük
       
       int int22 = int20 + int.Parse(str20); //string değeri int değere dönüştürdük


       //DATETİME İLE İLGİLİ İŞLEMLER
       DateTime dt = DateTime.Now.AddDays(2);
       DateTime dt2 = DateTime.Now.AddHours(3);
         string dt3 = DateTime.Now.ToString("dd.MM.yyyy");
            string dt4 = DateTime.Now.ToString("dd/MM/yyyy");
            string dt5 = DateTime.Now.ToString("dd-MM-yyyy");
            string dt6 = DateTime.Now.ToString("HH:mm");
            string dt7 = DateTime.Now.ToString("hh:mm");
            string dt8 = DateTime.Now.ToString("HH:mm:ss");

       
	}
}