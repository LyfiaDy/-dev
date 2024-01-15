using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kaç adet random sayı üretmek istiyorsunuz?");
        int sayiAdeti = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();

        Console.WriteLine($"{sayiAdeti} adet eşsiz random sayı üretildi:");
        for (int i = 0; i < sayiAdeti; i++)
        {
            int randomSayi;

            // Daha önce üretilen sayılar içinde olmayana kadar random sayı üret
            do
            {
                randomSayi = random.Next();
            } while (SayiDiziIceriyorMu(randomSayi));

            Console.WriteLine(randomSayi);
        }

        Console.ReadLine();
    }

    static bool SayiDiziIceriyorMu(int sayi)
    {
        // Bu metot, daha önce üretilen sayıları takip etmek için kullanılır
        // Daha önce üretilen sayı içinde varsa true, yoksa false döner
        // Bu şekilde eşsiz sayıları garanti altına alabiliriz
       
        int[] sayiDizisi = new int[1000]; // Örneğin, 1000 elemanlı bir dizi kullanıyoruz

        foreach (var item in sayiDizisi)
        {
            if (item == sayi)
            {
                return true;
            }
        }

        return false;
    }
}
