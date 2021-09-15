/*
 * Kullanıcıdan istenecek belirsiz miktardaki sayı içerisinden en büyük ve en küçük olanları tespit edip
 * ekrana sonucu yazan programı geliştirin. Kullanıcıdan toplamda kaç adet sayı alınacağı kullanıcıya bağlı
 * olacak, kullanıcı “end” yazdığında sayı alma işlemi durdurulacak ve sonuçlar ekrana yazdırılacak.
 * Kullanıcının yazdığı değerlerin sayı olup olmadığının kontrolü yapılmalıdır.
 * Kullanıcı uygun formatta sayı girmezse uyarı döndürülecek ve girilen değer geçersiz sayılacaktır.
 * Program hesaplama ve tespit işlemlerini yaptıktan sonra başa dönecek ve tekrar sayı girişi bekleyecektir.
 * Programı sonlandırmak, kullanıcının “exit” yazmasına bağlı olacaktır.

 */

using System;


namespace Question7
{
    class Program
    {
        static void Main()
        {
            try
            {
                bool flag;
                int min = int.MaxValue;
                int max = int.MinValue;

                Console.WriteLine("Lutfen Sayi Girisi Yapiniz... || Hesaplama icin end yazabilirsiniz\n+" +
                                  "Cikis icin exit yazabilirsiniz...\n");

                do
                {
                    flag = false;
                    string input = Console.ReadLine();

                    if (input.Trim() != "end" && input.Trim() != "End" && input.Trim() != "END")
                    {
                        if (input.Trim() == "exit" && input.Trim() == "Exit" && input.Trim() == "EXIT")
                        {
                            Environment.Exit(0);
                        }

                        bool parseSuccess = int.TryParse(input, out var numb);
                        if (!parseSuccess)
                        {
                            Console.WriteLine("Lutfen Sadece Sayi Girisi Yapiniz..");
                        }
                        else
                        {
                            if (min > numb)
                                min = numb;
                            if (max < numb)
                                max = numb;
                        }
                    }
                    else
                    {
                        flag = true;
                    }
                } while (!flag);

                Console.WriteLine("En Kucuk Deger: {0} || En Buyuk Deger: {1} ", min, max);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}