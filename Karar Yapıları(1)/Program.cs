using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int datetime = DateTime.Now.Hour;

            if (datetime >= 6 && datetime < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (datetime >= 12 && datetime < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (datetime >= 18 && datetime < 24)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }

            string sonuc = datetime >= 6 && datetime < 12 ? "Good Morning" : datetime >= 12 && datetime < 18 ? "Good Afternoon" : datetime >= 18 && datetime < 24 ? "Good Evening" : "Good Night";
            Console.WriteLine(sonuc);
        }
    }
}