 public class Bitkiler:Canlılar{
    public void fotosentez(){
        Console.WriteLine("bitkiler fotosentez yapabilirler");
    }
    
    public class TohumluBitkiler:Bitkiler{
        public void Tohum(){
            Console.WriteLine("Tohumla çoğalırlar");
        }
    }

    public class TohumsuzBitkiler:Bitkiler{
        public void Tohumsuz(){
            Console.WriteLine("Tohumsuzlardır");
        }
    }

}