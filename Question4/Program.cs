/*
 * Kullanıcının girdiği metnin ilk harfi küçük, daha sonra sırasıyla
 * bir büyük bir küçük olacak şekilde ekrana yazdırın.
 * Metnin İngilizce karakterle girildiği varsayılacak.
Örnek: İSTANBUL girerse çıktı iStAnBuL şeklinde olacak.

 */

using System;
using System.Linq;


namespace Question4
{
    class Program
    {
        static void Main()
        {

            try
            {
                Console.WriteLine("Lutfen Bir Metin Giriniz...\n");
                Console.WriteLine("########################################################3");
                string str = Console.ReadLine();
            
                
                if (string.IsNullOrEmpty(str) )
                {
                    Console.WriteLine("Metin Alani Bos Gecilemez....");

                }else if (!str.All(Char.IsLetter))
                {
                    Console.WriteLine("Sadece Metin Girisine Izin Verilir...");
                 

                }
                else
                {
                    var length = str.Length;
                    char[] arr = str.ToCharArray(0, length);
            
            
                    for(int i=0; i < length; i++)
                    {
                        var ch = arr[i];
                        if (i %2 ==0) 
                            Console.Write(Char.ToLower(ch));
                        else
                            Console.Write(Char.ToUpper(ch));
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