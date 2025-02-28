//erişim_belirteci geri_dönüştipi metot_adı(parametreler)
//{

    //komutlar

//}

class Metotlar
{
    public void EkranaYazdir(string a){
        Console.WriteLine(a);
    }
}


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int sonuc=Topla(12,34);
            Console.WriteLine(sonuc);




            Metotlar ornek = new Metotlar();
        static void Main(string[] args)
        {
            int sonuc=Topla(12,34);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
        }

        static int Topla(int x,int y){
            return x+y;
        }
        }
        }
        }