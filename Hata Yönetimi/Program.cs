using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToByte(Console.ReadLine());
            }
            catch (Exception err)
            {
                Console.WriteLine("Hata oluştu:"+" " + err.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
                
            }


            try
            {
                Random random = new Random();
                int sayilar = random.Next(1, 5);
                Console.WriteLine("1 - 5 arası sayı giriniz: ");
                int index = Convert.ToByte(Console.ReadLine());
                if (index == sayilar){
                    Console.WriteLine("Sayı eşit");
                }else{
                    Console.WriteLine("giriş yaptığınız sayı ile random sayı eşit değil");
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Hata oluştu:" + " " + err.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
          
          

          try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToByte(Console.ReadLine());
            }
            catch (ArgumentException err)
            {
                Console.WriteLine("Hata oluştu:" + " " + err.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
            

            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToByte(Console.ReadLine());
            }
            catch (FormatException err)
            {
                Console.WriteLine("Hata oluştu:" + " " + err.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }



            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToByte(Console.ReadLine());
            }
            catch (OverflowException err)
            {
                Console.WriteLine("Hata oluştu:" + " " + err.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }



            
        
        }
    }
}