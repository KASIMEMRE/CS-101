using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            Console.WriteLine("Bir cümle yazınız");
            string cümle = Console.ReadLine();

            foreach (var item in cümle)
            {
                
                char[] sesliHarfler = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
                List<char> bulunanSesliHarfler = new List<char>();

                if (sesliHarfler.Contains(item))
                {
                    bulunanSesliHarfler.Add(item);
                }

                bulunanSesliHarfler.Sort();

                foreach (var harf in bulunanSesliHarfler)
                {
                    Console.Write(harf + " ");
                }
                    
                
            }
        }
    }
}
