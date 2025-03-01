using System;
using System.Collections;


    internal class Program
    {
        static void Main(string[] args)
        {
            // Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            int[] numbers = new int[20];
            Console.WriteLine("Lütfen 20 adet pozitif sayı giriniz:");

            for (int i = 0; i < 20; i++)
            {
                while (true)
                {
                    Console.Write($"Sayı {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
                    {
                        numbers[i] = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir pozitif sayı giriniz.");
                    }
                }
            }

            Array.Sort(numbers);

            int[] smallestThree = numbers.Take(3).ToArray();
            int[] largestThree = numbers.Reverse().Take(3).ToArray();

            double smallestThreeAverage = smallestThree.Average();
            double largestThreeAverage = largestThree.Average();
            double totalAverage = smallestThreeAverage + largestThreeAverage;

            Console.WriteLine($"En küçük 3 sayının ortalaması: {smallestThreeAverage}");
            Console.WriteLine($"En büyük 3 sayının ortalaması: {largestThreeAverage}");
            Console.WriteLine($"Ortalama toplamları: {totalAverage}");


        }
    }
