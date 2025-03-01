using System;
using System.Collections;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)
            
            
            ArrayList primeNumbers = new ArrayList();
            ArrayList nonPrimeNumbers = new ArrayList();

            Console.WriteLine("Lütfen 20 adet pozitif sayı giriniz:");

            for (int i = 0; i < 20; i++)
            {
                int number;
                while (true)
                {
                    Console.Write($"Sayı {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir pozitif sayı giriniz.");
                    }
                }

                if (IsPrime(number))
                {
                    primeNumbers.Add(number);
                }
                else
                {
                    nonPrimeNumbers.Add(number);
                }
            }

            Console.WriteLine("Asal Sayılar:");
            foreach (int prime in primeNumbers)
            {
                Console.WriteLine(prime);
            }

            Console.WriteLine("Asal Olmayan Sayılar:");
            foreach (int nonPrime in nonPrimeNumbers)
            {
                Console.WriteLine(nonPrime);
            }

            static bool IsPrime(int number)
            {
                if (number <= 1) return false;
                if (number == 2) return true;
                if (number % 2 == 0) return false;

                for (int i = 3; i <= Math.Sqrt(number); i += 2)
                {
                    if (number % i == 0) return false;
                }

                return true;
            }

       
        

       
        }

        
    }
}