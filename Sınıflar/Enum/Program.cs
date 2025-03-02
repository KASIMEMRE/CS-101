using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sıralı değerlerle kullanılabilir kodun okulabilirliğini artıran bir yapıdır


            Console.WriteLine(Günler.cuma);
            Console.WriteLine((int)Günler.cumartesi);

            int sıcaklık=25;
            if(sıcaklık<=(int)HavaDurumu.normal){
                Console.WriteLine("Mangal Yapılabilir1");
            }else if(sıcaklık>=(int)HavaDurumu.sıcak){
                Console.WriteLine("Mangal Yapılabilir2");
            }else{
                Console.WriteLine("Mangal Yapılabilir3");
            }
                
            
        }
    }
    enum Günler{
        pazartesi=1,
        salı,
        çarşamba,
        perşembe,
        cuma=29,
        cumartesi,
        pazar
    }

    enum HavaDurumu{
        soğuk=5,
        normal=15,
        sıcak=30
    }
}