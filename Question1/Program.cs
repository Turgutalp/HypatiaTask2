/*
 *  Bir zar var elinizde. 1000 kere atıyorsunuz. Her sayıdan kaç defa geldiğini ekrana yazdırın.

 */

using System;

namespace Question1
{
    class Program
    {
        static void Main()
        {
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;


            Console.WriteLine("************************************************************************");
            Console.WriteLine("Zar Atiliyor...");
            Console.WriteLine("************************************************************************\n");

            Random rd = new Random();

            try
            {
                int i = 0;
                while (i < 1000)
                {
                    int roll = rd.Next(1, 7);
                    i++;
                    switch (roll)
                    {
                        case 1:
                            count1++;
                            break;
                        case 2:
                            count2++;
                            break;
                        case 3:
                            count3++;
                            break;
                        case 4:
                            count4++;
                            break;
                        case 5:
                            count5++;
                            break;
                        case 6:
                            count6++;
                            break;
                    }
                }


                Console.WriteLine(
                    "1 sayisi: {0} kere, 2 sayisi: {1} kere, 3 sayisi: {2} kere, 4 sayisi: {3} kere, 5 sayisi: {4} kere, 6 sayisi: {5} kere gelmistir.",
                    count1, count2, count3, count4, count5, count6);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               
            }
           
        }
    }
}