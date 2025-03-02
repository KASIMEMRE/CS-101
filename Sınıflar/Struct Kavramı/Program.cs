using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //structlar sınıflara çok benzerler 
            //sınıfların referans tipindeki değişkenler belleğin heap bölgesinde tutuluyor.
            //value tipindeki değişkenler belleğin stack bölgesinde tutuluyor.

            Dikdörtgen dikdörtgen = new Dikdörtgen();
            dikdörtgen.uzunKenar=10;
            dikdörtgen.kısaKenar=7;

            Console.WriteLine("Alan Hesabı :{0}",dikdörtgen.alanHesapla());


            Dikdörtgen1 dikdörtgen1 = new Dikdörtgen1();
            dikdörtgen1.uzunKenar=10;
            dikdörtgen1.kısaKenar=7;

            Console.WriteLine("Alan Hesabı : {0}",dikdörtgen1.alanHesapla());
        }
    }

    class Dikdörtgen{

        public int kısaKenar;
        public int uzunKenar;

        public Dikdörtgen(){
            kısaKenar=7;
            uzunKenar=10;
        }

        public long alanHesapla(){
            return this.kısaKenar*this.uzunKenar;
        }
    }
    struct Dikdörtgen1{
        
        public int kısaKenar;
        public int uzunKenar;

        public Dikdörtgen1(){
            kısaKenar=7;
            uzunKenar=10;
        }

        
        public long alanHesapla(){
            return this.kısaKenar*this.uzunKenar;
        }
    }
}