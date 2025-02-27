using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //inplicit conversion (bilinçsiz dönüşüm)
          Console.WriteLine("*************Implicit Conversion*************");
            int a = 5;
            double b = a;
            Console.WriteLine(b);

            byte c = 5;
            int d = c;
            
            Console.WriteLine(d);

            //byte -> short -> int -> long -> float -> double
            //string -> char
            string e ="5";
            char f = e[0];
            Console.WriteLine(f);
            

          //explicit conversion (bilinçli dönüşüm) 
          Console.WriteLine("*************Explicit Conversion*************");
           
            int x = 5;
            byte y = (byte)x;
            Console.WriteLine(y);

            float z = 5.25f;
            int t = (int)z;
            Console.WriteLine(t);

            string g = "5";
            int h = Convert.ToInt32(g);
            Console.WriteLine(h);

            string i = "5.25";
            float j = float.Parse(i);
            Console.WriteLine(j);



            //ToString() methodu
            Console.WriteLine("*************ToString() Method*************");
            int k = 5;
            string l = k.ToString();
            Console.WriteLine(l);

            string xx = 12.5f.ToString();
            Console.WriteLine(xx);

            int xxx = 5;
            string yy = xxx.ToString();
            Console.WriteLine(yy);


            //System.Convert
            Console.WriteLine("*************System.Convert*************");
            string s1= "10", s2 = "20";
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam" +toplam);

            
            //Parse
            Console.WriteLine("*************Parse*************");
            Parsemethod();

        }
        public static void Parsemethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double rakam2;
            rakam1 = int.Parse(metin1);
            rakam2 = double.Parse(metin2);
            Console.WriteLine("rakam1: " + rakam1);
            Console.WriteLine("rakam2: " + rakam2);
        }
    }
}