using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kapsülleme oop nin temel kavramlarındandır 
            //kapsülleme bir nesnenin bazı özelliklerini işlevlerini metotlarını diğer classlardan koruma işlemi yapıyor erişim belirleyiciler ile yaparız

            ogrenci Ogrenci = new ogrenci();
            Ogrenci.Isim = "ayşe";
            Ogrenci.Soyisim = "Tosun";
            Ogrenci.No = 999;
            Ogrenci.Sınıf = 9;
            Ogrenci.sınıfAtlad();
            Ogrenci.ogrenciBilgileriGetir();
        }
    }

    class ogrenci{
        private string isim;//kontrol nokta ile ismin üzerine (and use property) seçeneği ile private olanı dışarıdan ulaşabilriz kendi otomatik oluşturur.
        private string soyisim;
        private int no;
        private int sınıf;

        public string Isim { get => isim; set => isim = value; }// bir tane public bir sınıf oluştuduktan sonra yine aynı şekil kontrol nokta ile use property yap ve dışarıdan erişim yapabiliriz
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int No { get => no; set => no = value; }
        public int Sınıf { get => sınıf; set => sınıf = value; }


        public ogrenci(string ısim, string soyisim, int no, int sınıf)
        {
            Isim = ısim;
            Soyisim = soyisim;
            No = no;
            Sınıf = sınıf;
        }

        public ogrenci(){}

        public void ogrenciBilgileriGetir(){

            Console.WriteLine("******************");
            Console.WriteLine("Öğrenci Adı :  {0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı :  {0}",this.Soyisim);
            Console.WriteLine("Öğrenci No :  {0}",this.No);
            Console.WriteLine("Öğrenci Sınıfı :  {0}",this.Sınıf);
        }

        public void sınıfAtlad(){
            this.Sınıf=this.Sınıf+1;

        }
        public void sınıfDüşür(){
            this.Sınıf=this.Sınıf-1;
            
        }
    }
}