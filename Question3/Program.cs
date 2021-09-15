/*
 * Kullanıcının girdiği metnin içerisindeki rakamların sayısını gösteren uygulamayı yazın.
Örnek : hypatia1234 için çıktı 4’tür.


 */

using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input;
                int length, digit, index;
                digit = index = 0;


                Console.WriteLine("Lutfen bir metin giriniz: \n");
                
                input = Console.ReadLine();
                length = input.Length;

                while (index < length)
                {
                    if (input[index] >= '0' && input[index] <= '9')
                    {
                        digit++;
                    }

                    index++;
                }

                Console.WriteLine("Girmis oldugunuz metindeki rakam sayisi: {0} ", digit);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}