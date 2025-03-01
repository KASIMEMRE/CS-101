using System;
using System.Collections;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            ArrayList liste = new ArrayList();

            //eleman atama
            liste.Add("ayşe");
            liste.Add("cemil");
            liste.Add(true);
            liste.Add(24);


            Console.WriteLine(liste[1]);//cemil

            foreach (var i in liste)
            {
                Console.WriteLine(i);
            }

            //AddRange

            string[] renkler = {"mavi","mor","pembe","yeşil"};
            List<int> sayılar = new List<int>(){21,34,543,12,3215,476,5};
            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //sort (küçükten büyüğe sıralama)

            liste.Sort();

            foreach (var item1 in liste)
            {
                Console.WriteLine(item1);
            }

            //binarysearch (sıralama yapıp bu metotu kullanırız)
            liste.BinarySearch(9);

            //reverse(listeyi terse çevirir)

            //clear(listeyi komple temizler)
            

        }
    }
}