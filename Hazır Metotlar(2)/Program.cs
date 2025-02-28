using System;

class Program
{
    static void Main()
    {
        // DateTime örnekleri
        DateTime now = DateTime.Now;
        Console.WriteLine("Şu anki tarih ve saat: " + now);

        DateTime tomorrow = now.AddDays(1);
        Console.WriteLine("Yarınki tarih: " + tomorrow.ToShortDateString());

        DateTime specificDate = new DateTime(2023, 10, 1);
        Console.WriteLine("Belirli bir tarih: " + specificDate.ToLongDateString());

        // Math metotları örnekleri
        double number = -5.5;
        double absoluteValue = Math.Abs(number);
        Console.WriteLine("Mutlak değer: " + absoluteValue);

        double squareRoot = Math.Sqrt(16);
        Console.WriteLine("Karekök: " + squareRoot);

        double power = Math.Pow(2, 3);
        Console.WriteLine("2'nin 3. kuvveti: " + power);

        double pi = Math.PI;
        Console.WriteLine("Pi sayısı: " + pi);
        double ceiling = Math.Ceiling(4.2);
        Console.WriteLine("4.2'nin yukarı yuvarlanmış hali: " + ceiling);

        double floor = Math.Floor(4.8);
        Console.WriteLine("4.8'in aşağı yuvarlanmış hali: " + floor);

        double round = Math.Round(4.5);
        Console.WriteLine("4.5'in yuvarlanmış hali: " + round);

        double max = Math.Max(10, 20);
        Console.WriteLine("10 ve 20'den büyük olan: " + max);

        double min = Math.Min(10, 20);
        Console.WriteLine("10 ve 20'den küçük olan: " + min);

        double log = Math.Log(10);
        Console.WriteLine("10'un doğal logaritması: " + log);

        double exp = Math.Exp(2);
        Console.WriteLine("e'nin 2. kuvveti: " + exp);
        // Random örnekleri
        Random random = new Random();
        int randomInt = random.Next(1, 100);
        Console.WriteLine("1 ile 100 arasında rastgele bir sayı: " + randomInt);

        double randomDouble = random.NextDouble();
        Console.WriteLine("0 ile 1 arasında rastgele bir ondalık sayı: " + randomDouble);

        // TimeSpan örnekleri
        TimeSpan duration = new TimeSpan(1, 30, 0);
        Console.WriteLine("1 saat 30 dakikalık süre: " + duration);

        TimeSpan timeBetween = specificDate - now;
        Console.WriteLine("Belirli tarih ile şu an arasındaki süre: " + timeBetween.Days + " gün");

        // Guid örnekleri
        Guid newGuid = Guid.NewGuid();
        Console.WriteLine("Yeni bir GUID: " + newGuid);
    }
}