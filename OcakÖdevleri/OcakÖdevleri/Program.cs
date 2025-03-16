using System;

class Program
{
    static void Main(string[] args)
    {
        int secim = -1;

        while (secim != 4) 
        {
            Console.WriteLine("Ocak Ayı Ödevleri \n \n 1.Hafta \n 2.Hafta \n 3.Hafta \n 4.Hafta \n 5-Çıkış");
            Console.WriteLine("\n Hafta seçiniz : ");
            secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    /* C# (C-sharp), Microsoft tarafından geliştirilmiş, nesne yönelimli, yüksek seviyeli bir programlama dilidir.
                     * C# dili, özellikle .NET Framework ve .NET Core (şimdi .NET 5 ve sonrası) ile birlikte çalışacak şekilde tasarlanmıştır.
                     * C# dili, çok yönlü, güvenli ve modern yazılımlar geliştirmeyi kolaylaştırmak amacıyla güçlü bir sözdizimine sahip olup,
                     * özellikle büyük ve karmaşık projelerde yaygın olarak kullanılır.*/

                    Console.Write("Lütfen adınızı girin: ");
                    string ad = Console.ReadLine();
                    Console.WriteLine($"Merhaba, {ad}!");
                    break;


                case 2:

                    // ınt Tam sayılar için kullanılır. Bellek Boyutu: 4 byte
                    // double ondalık sayılar için kullanılır. Bellek Boyutu: 8 byte
                    //char tek bir karakteri saklamak için kullanılır.Bellek Boyutu: 2 byte 
                    //float ondalık sayılar için daha düşük hassasiyetle kullanılır. Bellek Boyutu: 4 byte
                    //bool Doğru (true) veya yanlış (false) değerlerini saklar. Bellek Boyutu: 1 byte
                    //byte 0 ile 255 arasında tam sayıları saklar. Bellek Boyutu: 1 byte
                    //short Küçük tam sayıları saklar (-32,768 ile 32,767 arasında). Bellek Boyutu: 2 byte

                    Console.Write("Birinci sayıyı girin: ");
                    int sayi1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("İkinci sayıyı girin: ");
                    int sayi2 = Convert.ToInt32(Console.ReadLine());

                    // Toplamı hesapla
                    int toplam = sayi1 + sayi2;

                    // Sonucu ekrana yazdır
                    Console.WriteLine("İki sayının toplamı: " + toplam);
                    break;



                case 3:

                    /*(if-else), bir programda belirli bir şartın doğruluğuna göre farklı işlemler gerçekleştirilmesini sağlamak için kullanılır.
                     * Bir koşul sağlandığında bir işlem yapılır, sağlanmadığında ise başka bir işlem yapılır.
                     * Bu tür ifadeler, programın akışını kontrol etmek ve kararlar almak için kullanılır.*/


                    // 1. kısım
                    Console.WriteLine("Sayı Giriniz (Tek-Çift):");
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi % 2 != 0)
                    {
                        Console.WriteLine("Sayı tektir");
                    }
                    else
                    {
                        Console.WriteLine("Sayı çifttir");
                    }

                    // 2. kısım
                    Console.WriteLine("Sayı Giriniz (pozitif-negatif-sıfır):");
                    int sayi4 = int.Parse(Console.ReadLine());
                    if (sayi4 == 0)
                    {
                        Console.WriteLine("Sayı 0'dır");
                    }
                    else if (sayi4 > 0)
                    {
                        Console.WriteLine("Sayı pozitif");
                    }
                    else
                    {
                        Console.WriteLine("Sayı negatif");
                    }
                    break;


                case 4:

                    /*for dongusu belirli bir sayıda işlem tekrarlamak için kullanılır. while dongusu  koşul doğru olduğu sürece işlem tekrarlamak için kullanılır.*/

                    Console.WriteLine("1'den 10'a kadar olan sayıları yazdırma");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine("Sayı giriniz (Kullanıcıdan alınan bir sayıya kadar olan sayıların toplamını hesaplayan bir program):");
                    int sayi5 = int.Parse(Console.ReadLine());

                    int toplam2 = 0;

                    // 1'den sayi5'e kadar olan sayıları toplama
                    for (int i = 1; i <= sayi5; i++)
                    {
                        toplam2 += i;
                    }

                    // Sonucu ekrana yazdırma
                    Console.WriteLine("1'den " + sayi5 + " kadar olan sayıların toplamı: " + toplam2);
                    break;
                case 5:
                    Console.WriteLine("Programdan çıkılıyor...");
                    return; // Programı sonlandırır
                default:
                    Console.WriteLine("Geçersiz bir seçenek girdiniz. Lütfen 1-5 arasında bir seçenek girin.");
                    break;
            }
        }
    }
}
