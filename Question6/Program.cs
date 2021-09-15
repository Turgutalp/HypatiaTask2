/*
 * Kullanıcının oynayacağı bir adet sayısal loto kolonu için değerleri alın.
 * Daha sonra çekiliş yapıp şanslı sayıları belirleyin.
 * Ardından kullanıcıya kaç sayıyı bildiği bilgisini verin.

 */

using System;


namespace Question6
{
    class Program
    {
        static void Main()
        {
            try
            {
                Random rnd = new Random();

              
                const int size = 6;
                int[] array = new int[size];
                int[] array2 = new int[size];


                Console.WriteLine("Hypatia Loto Cekilisine Hosgeldiniz\n" +
                                  "Sizi Zengin Etmek Bizim Gorevimiz...");

                Console.WriteLine("Lutfen sansli sayilarinizdan 6 tanesini giriniz...");


                for (int j = 0; j < array.Length; j++)
                {
                    int input;
                    while (!Int32.TryParse(Console.ReadLine(), out input))
                    {
                        Console.WriteLine("Lutfen Sadece Sayi Girisi Yapiniz ");
                    }

                    if (input > 49 || input == 0 )
                    {
                        Console.WriteLine("Lutfen 1-49 arasinda bir sayi giriniz....");
                    }


                    array[j] = input;
                }

                for (int r = 0; r < array.Length; r++)
                {
                    for (int c = r + 1; c < array.Length; c++)
                    {
                        if (array[r] == array[c])
                        {
                            Console.WriteLine("Sayi Tekrari: {0} = {1} Lutfen Tekrar Deneyin....", array[r],array[c]);
                            Environment.Exit(0);
                        }
                    }
                }

                Console.WriteLine("Cekilis Yapiliyor.....");

                /*
                 * 
                   // Burada generate edilen random sayilarin ayni olmasi ihtimalini cozmek istedim
                   // ya shuffle array yapicaktim ya da linq kullanacaktim henuz islemedigimiz icin yapamadim
                   //aklima da daha basit bir cozum gelmedi
                   // 6 elemani karsilastirip en az 1 ayni olmasi durumunda yeniden random uretmek pek mantikli gelmedi cunku yine ihtimal dogacakti 
                   // ufacik bir ihtimal bile olsa sonsuz dongu durumu olabilirdi
                   
                 */

                for (int i = 0; i < 6; i++)
                {
                    int luckyNumber = rnd.Next(1, 50);
                    array2[i] = luckyNumber;
                    Console.WriteLine(array2[i]);
                }

                Console.WriteLine("Sonuclar:\n");


                int count = 0;
                for (int b = 0; b < array.Length; b++)
                {
                    for (int k = 0; k < array2.Length; k++)
                    {
                        if (array[b] == array2[k])
                        {
                            count++;
                            Console.WriteLine("Eslesen Sayilar: {0}\n", array[b]);

                            Console.WriteLine("Tebrikler: " + count + " Sayi Bildiniz");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}