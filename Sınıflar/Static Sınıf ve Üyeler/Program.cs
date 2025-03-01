using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayısı);

            Calisan calisan1 = new Calisan("ayşe","yılmaz","ik");
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayısı);
            Calisan calisan2 = new Calisan("ayşe","yılmaz","ik");
            Calisan calisan3 = new Calisan("ayşe","yılmaz","ik");
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayısı);


            Console.WriteLine("Toplama sonucu: {0}",işlemler.Topla(100, 20));
            Console.WriteLine("Çıkarma sonucu: {0}",işlemler.Çıkar(100, 20));


            
        }
    }

    class Calisan{

        private static int calisanSayısı;

        public static int CalisanSayısı 
        { 
            get => calisanSayısı; 
            set => calisanSayısı = value; 
            
        }
        private string Isim;
        private string Soyİsim;
        private string Departman;

        static Calisan(){
            calisanSayısı=0;

        }

        public Calisan(string isim, string soyİsim, string departman){
            this.Isim=isim;
            this.Soyİsim=soyİsim;
            this.Departman=departman;
            calisanSayısı++;
        }

    }

    static class işlemler{
        public static long Topla(int sayı1,int sayı2){
            return sayı1+sayı2;
        }
         public static long Çıkar(int sayı1,int sayı2){
            return sayı1-sayı2;
        }
    }
}