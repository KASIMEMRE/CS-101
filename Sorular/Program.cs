Console.WriteLine("****SORU BİR****");

//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Console.WriteLine("Pozitif Bir Sayı Giriniz: ");
Console.ReadLine();
Console.Write("Kaç sayı gireceksiniz? ");
        int n = int.Parse(Console.ReadLine()); 

        int[] numbers = new int[n]; 

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine()); 
        }

        
        Console.WriteLine("Çift Olanlar");
        foreach (int num in numbers)
        {
            if(num%2==0){
                Console.WriteLine(num);
            }

        }


// Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
// Console.WriteLine("****Soru İki****");

// Console.WriteLine("iki adet sayı giriniz");
// int[] sayılar = new int[n]; 

// for (int i = 0; i < 2; i++)
//         {
//             Console.Write($"Sayı {i + 1}: ");
//             sayılar[i] = int.Parse(Console.ReadLine()); 
//         }
//         int n2 = sayılar[0];
//         int m = sayılar[1];

//         int[] numbers2 = new int[n2];

//         for (int i = 0; i < n2; i++)
//         {
//             Console.Write($"Sayı {i + 1}: ");
//             numbers2[i] = int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine($"{m}'e eşit veya tam bölünenler:");
//         foreach (int num in numbers2)
//         {
//             if (num == m || num % m == 0)
//             {
//                 Console.WriteLine(num);
//             }
//         }



//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
Console.WriteLine("****SORU ÜÇ****");

Console.WriteLine("bana pozitif bir sayı gir");
int a = int.Parse(Console.ReadLine());

Console.WriteLine(a+" "+ "bu kadar kelime gir");
string[] girdi = new string[a];

for (int i = 0; i < a; i++)
         {
            Console.Write($"kelime {i + 1}: ");
          girdi[i] = Console.ReadLine(); 
        }

Console.WriteLine(string.Join(" ", girdi.Reverse()));







//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.


Console.WriteLine("Bir cümle yazınız: ");
string cümle = Console.ReadLine();

int kelime = cümle.Split(' ').Length;
int harf = cümle.Replace(" ", "").Length;

Console.WriteLine($"Toplam kelime sayısı: {kelime}");
Console.WriteLine($"Toplam harf sayısı: {harf}");



