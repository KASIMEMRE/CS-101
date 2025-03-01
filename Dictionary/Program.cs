using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanıcılar =new Dictionary<int, string>();
            kullanıcılar.Add(0,"cenk");
            kullanıcılar.Add(1,"icardi");
            kullanıcılar.Add(2,"mücahit");
            kullanıcılar.Add(2,"mücahit");
            

            //dizinin elemanlarına erişmek için 

            Console.WriteLine(kullanıcılar[0]);

            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //count ( eleman sayısını verir)

            Console.WriteLine(kullanıcılar.Count);

            //contains(içerideki elaman sorgusunu yapmamızı sağlar)
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("icardi"));

        }
    }
}