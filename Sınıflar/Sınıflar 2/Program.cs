using System;
using System.ComponentModel;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args){
//         
//             class SinifAdi {
//     [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
//     [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
//     {
//         Metot Gövdesi
//     }
// }

            //kurucu metotların erişim belirleyicileri mutlaka public olmak zorundadır
            //kurucu fonksiyonların geri dönüş tipini yazmıyoruz.


        //Erişim Belirleyiciler
        //*Public
        //*Private
        //*İnternal
        //*Protected

        calısan calısan1 = new calısan("ANIL","Alvaratze",55,"İ.K");
        calısan1.calısanBilgileri();

        Console.WriteLine("************************");

        calısan calısan2 = new calısan();
        calısan2.ad="alex";
        calısan2.soyAd="talisca";
        calısan2.no=41;
        calısan2.departman="Muhasebe";

        calısan2.calısanBilgileri();

        
        Console.WriteLine("************************");
        calısan calısan3 = new calısan("Tosun","Cenk");
        calısan3.calısanBilgileri();
        }
    }

    class calısan{

        public string ad;
        public string soyAd;
        public int no;
        public string departman;


        public calısan(string Ad ,string SoyAd,int No, string Departman){
            this.ad=Ad;
            this.soyAd=SoyAd;
            this.no=No;
            this.departman=Departman;
        }

        public calısan(string AD,string SOYAD){
            this.ad=AD;
            this.soyAd=SOYAD;
        }

        public calısan(){}

        public void calısanBilgileri(){
            Console.WriteLine("çalışan adı:{0}",ad);
            Console.WriteLine("çalışan soyadı:{0}",soyAd);
            Console.WriteLine("çalışan no:{0}",no);
            Console.WriteLine("çalışan departman:{0}",departman);

        }

    }
}