using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //atama ve işlemli atama
            Console.WriteLine("*****Atama ve İşlemli Atama*****");
            int x = 3;
            int y = 3;
            y = y + 2;
            y += 2;
            int z = y * 2;
            Console.WriteLine(z);




            //Mantıksal Operatörler
            //||, &&, !
            Console.WriteLine("*****Mantıksal Operatörler*****");
             bool isSuccess = true;
             bool isCompleted = false;
             if (isSuccess && isCompleted)
                 Console.WriteLine("Perfect!");
                 else
                Console.WriteLine("Try Again!");

             if (isSuccess || isCompleted)
                 Console.WriteLine("Great!");
                 else
                Console.WriteLine("Try Again!");



                //İlişkisel Operatörler
                // <, >, <=, >=, ==, !=
                Console.WriteLine("*****İlişkisel Operatörler*****");
                int a = 3;
                int b = 4;
                bool sonuc = a < b;
                Console.WriteLine(sonuc);
                sonuc = a > b;
                Console.WriteLine(sonuc);
                sonuc = a <= b;
                Console.WriteLine(sonuc);
                sonuc = a >= b;
                Console.WriteLine(sonuc);
                sonuc = a == b;
                Console.WriteLine(sonuc);
                sonuc = a != b;
                Console.WriteLine(sonuc);

                //Aritmetik Operatörler
                // /, *, +, -
                Console.WriteLine("*****Aritmetik Operatörler*****");
                int sayi1 = 10;
                int sayi2 = 5;
                int sonuc1 = sayi1 / sayi2;
                Console.WriteLine(sonuc1);
                sonuc1 = sayi1 * sayi2;
                Console.WriteLine(sonuc1);
                sonuc1 = sayi1 + sayi2;
                Console.WriteLine(sonuc1);
                sonuc1 = sayi1++;
                Console.WriteLine(sonuc1);
                sonuc1 = sayi1--;
                Console.WriteLine(sonuc1);
                sonuc1 = sayi1 % sayi2;
                Console.WriteLine(sonuc1);


        }
    }
}
