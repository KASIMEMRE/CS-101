using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T=> obje türündedir

            List<int> sayiListesi = new List<int>();
            
            sayiListesi.Add(25);
            sayiListesi.Add(41);
            sayiListesi.Add(42);
            sayiListesi.Add(55);

            //count (eleman sayısnı veriri liste içindeki)

            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine("*******************");
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            //remove(listeden eleman siler)

            sayiListesi.Remove(25);
            Console.WriteLine("25 çıkarıldıktan sonra:");
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            //contains(liste içerisinde arama)
            if(sayiListesi.Contains(41))
                Console.WriteLine("KOCAELİ");
            
            //binaryserach (indexe erişmek için kullanılır)
            Console.WriteLine(sayiListesi.BinarySearch(41));


            //diziyi liste çevirmek için
            string[] hayvanlar = {"at","eşek","maymun","aygır"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //clear (listeyi komple temizler)



            List<kullanıcılar> kullanıcıListesi = new List<kullanıcılar>();
            kullanıcılar kullanıcı1 = new kullanıcılar();
            kullanıcı1.İsim="ayşe";
            kullanıcı1.soyİsim="alkantara";
            kullanıcı1.Yas=28;



            kullanıcılar kullanıcı2 = new kullanıcılar();
            kullanıcı1.İsim="cemil";
            kullanıcı1.soyİsim="arvalatze";
            kullanıcı1.Yas=45;


            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<kullanıcılar> yeniListe= new List<kullanıcılar>();
            yeniListe.Add(new kullanıcılar(){
                İsim="cenk",
                soyİsim="bond",
                Yas=27
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine(kullanıcı.İsim[0]);
            }
        }
    }
    public class kullanıcılar{
        string isim;
        string soyisim;
        int yas;

        public string İsim {get=>isim; set=>isim =value;}
        public string soyİsim {get=>soyisim; set=>soyisim =value;}
        public int Yas {get=>yas; set=>yas =value;}

    }
}