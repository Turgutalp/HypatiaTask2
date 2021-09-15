/*
 * Kullanıcı “tamam” ifadesini girene kadar girdiği sayıların toplamını ekrana yazdırın.

 */

using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tamam diyene kadar toplama basliyor....\n +" +
                              "Lutfen Sayi Girisi Yapiniz");

            try
            {
                string input;
                int sum = 0;
                int numb;

        
                do
                {
                    input = Console.ReadLine();
              
                    bool parseSuccess = int.TryParse(input, out numb);

                    if (input != "tamam" && input != "Tamam" && input != "TAMAM" && parseSuccess)
                    {
                        sum += numb;
                    }
                  
                    else
                        Console.WriteLine("This is not a number!");
                
               
                
                
                
                } while (input != "tamam" && input != "Tamam" && input != "TAMAM");

                Console.WriteLine("Girilen Sayilarin Toplami: " + sum);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
        
            }
           
        }
    }
}