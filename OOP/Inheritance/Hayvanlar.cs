public class Hayvanlar:Canlılar{
    public void adaptasyon(){
        Console.WriteLine("hayvanlar adaptasyon kurabillir");
    }
    public void hareket(){
        Console.WriteLine("hayvanlar sürekli konumunu değiştirebilir");
    }
    public class Sürüngenler:Hayvanlar{
            public void sürüngen(){
                Console.WriteLine("sürünürler");
            }
        }

    public class Kuşlar:Hayvanlar{
        public void kuş(){
            Console.WriteLine("uçarlar");
        }
    }
}