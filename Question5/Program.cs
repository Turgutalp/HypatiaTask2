/*
 * Kullanıcıdan kaç adet eleman gireceği bilgisini alın.
 * Ardından sırayla elemanları alıp diziye atın.
 * Veri girişi bitince dizinin elemanlarını 2 kolon olacak şekilde ekrana yazdırın.
Örnek Çıktı :    1    2
                 3    4
                 5    6

 */

using System;



namespace Question5
{
    class Program
    {

        static void Main()
        {

            try
            {
                int size;
                Console.WriteLine("Size:");
                // size = Convert.ToInt32(Console.ReadLine());
            
                while(!int.TryParse(Console.ReadLine(), out size))
                {
                    Console.WriteLine("Yalnizca Rakam Girisi Yapabilirsiniz...");
               
                }
            
            
                Console.WriteLine("####################################\n");

                int[] array = new int[size];

                for (int i = 0; i < size; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
            
            
                for (int i = 0; i < size; i++)
                {
                    Console.Write("\n");
                    for (int j = 0; j < 2; j++)
                        Console.Write("{0}\t", array[i]);
                }

                Console.Write("\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }


            
        }


       

    }
}


        
          
    
