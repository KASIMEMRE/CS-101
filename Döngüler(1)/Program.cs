using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Hello World!" + i);
            }

            Console.WriteLine("Kaç kere yazdırmak istersiniz?");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(  i);
                }
            }

            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 1)
                
                     tekToplam += i;
                
                else
                
                    ciftToplam += i;
                
              Console.WriteLine("Tek Toplam: " + tekToplam);
              Console.WriteLine("Çift Toplam: " + ciftToplam);
            }

            for (int i = 0; i <= 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            for (int i = 0; i <= 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}