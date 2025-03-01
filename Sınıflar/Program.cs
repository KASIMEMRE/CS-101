using System;

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


        //Erişim Belirleyiciler
        //*Public
        //*Private
        //*İnternal
        //*Protected

        calısan calısan1 = new calısan();
        calısan1.ad="diego";
        calısan1.soyAd="arvalatze";
        calısan1.no=49;
        calısan1.departman="İ.K";

        calısan1.calısanBilgileri();

        Console.WriteLine("************************");

        calısan calısan2 = new calısan();
        calısan2.ad="alex";
        calısan2.soyAd="talisca";
        calısan2.no=41;
        calısan2.departman="Muhasebe";

        calısan2.calısanBilgileri();
        }
    }

    class calısan{

        public string ad;
        public string soyAd;
        public int no;
        public string departman;
        public void calısanBilgileri(){
            Console.WriteLine("çalışan adı:{0}",ad);
            Console.WriteLine("çalışan soyadı:{0}",soyAd);
            Console.WriteLine("çalışan no:{0}",no);
            Console.WriteLine("çalışan departman:{0}",departman);

        }

    }
}
