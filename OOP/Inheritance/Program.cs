using System;
using static Bitkiler;
using static Hayvanlar;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inheritance(KALITIM) bir üst sınfın alt sınfa miras vermesi anlamına geliyor.
            //                  -CANLILAR
            //                      |
            //  -BİTKİLAER                      -HAYVANLAR
            //      |                               |
            //-TOHUMLU -TOHUMSUZ            -SÜRÜNGEN -UÇAN

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.bosaltım();
            tohumluBitki.Tohum();
            tohumluBitki.Tohum();
            Console.WriteLine("**************************");
            
            TohumsuzBitkiler tohumsuzBitki = new TohumsuzBitkiler();
            tohumsuzBitki.bosaltım();
            tohumsuzBitki.fotosentez();
            tohumsuzBitki.Tohumsuz();

            Console.WriteLine("**************************");


            Kuşlar kuş = new Kuşlar();
            kuş.hareket();
            kuş.adaptasyon();
            kuş.kuş();
            Console.WriteLine("**************************");

            Sürüngenler sürüngen = new Sürüngenler();
            sürüngen.beslenme();
            sürüngen.sürüngen();
        }
    }
}