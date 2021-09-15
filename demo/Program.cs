/*
 * /*
 * Kullanıcıdan kaç adet eleman gireceği bilgisini alın.
 * Ardından sırayla elemanları alıp diziye atın.
 * Veri girişi bitince dizinin elemanlarını 2 kolon olacak şekilde ekrana yazdırın.
Örnek Çıktı :    1    2
                 3    4
                 5    6

 */

using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen Girilecek Rakam Sayisini Giriniz: ");
            int rakam = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rakam, 2];     
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);      

            for (int i = 0; i < row * col; i++)
            {
                matrix[i / col , i % col] = i + 1;
                Console.WriteLine(matrix);
            }
           
           
            
        }
    }
}