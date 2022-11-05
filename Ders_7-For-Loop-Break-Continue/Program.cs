using System;

// ********************************** Ders 7 **********************************
// for loop break continue
namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {

            // try
            // {
            //     for (int i = 0; i < 10; i++)
            //     {
            //         if (i == 4)
            //         {
            //             break;
            //         }
            //         Console.WriteLine("i: " + i);
            //     }
            //     Console.WriteLine("**********");
            //     // continue
            //     for (int i = 0; i < 10; i++)
            //     {
            //         if (i == 4)
            //         {
            //             continue;
            //         }
            //         Console.WriteLine("i: " + i);
            //     }

            //     /*
            //         Console.WriteLine("**********");

            //         Console.WriteLine("bir sayı giriniz");
            //         int sayi = Convert.ToInt32(Console.ReadLine());
            //         for (int i = 0; i < sayi; i++)
            //         {
            //             if (i % 2 == 1)
            //             {
            //                 Console.WriteLine(i);
            //             }
            //         } 
            //     */

            //     Console.WriteLine("**********");

            //     Console.WriteLine("bir sayı giriniz");
            //     int sayi2 = Convert.ToInt32(Console.ReadLine());
            //     int tekToplam = 0;
            //     int ciftToplam = 0;
            //     for (int i = 0; i < sayi2; i++)
            //     {
            //         if (i % 2 == 1)
            //         {
            //             tekToplam += i;
            //         }
            //         else
            //         {
            //             ciftToplam += i;
            //         }
            //     }

            //     Console.WriteLine("tek sayıların toplamı: " + tekToplam);
            //     Console.WriteLine("çift sayıların toplamı: " + ciftToplam);

            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }
            // finally
            // {
            //     Console.WriteLine("Finally block");
            //     Console.ReadLine();
            // }


            // ********************************** Ders 7 **********************************
            // donguler while foreach

            try
            {
                // get input
                /*                 
                    Console.WriteLine("bir sayı giriniz");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    int counter = 1;
                    int sum = 0;


                    while (counter <= sayi)
                    {
                        sum += counter;
                        counter++;
                    }

                    Console.WriteLine("1'den " + sayi + "'e kadar olan sayıların ortalaması: " + (sum / sayi)); 
                */

                /*
                    char character = 'a';
                    while (character <= 'z')
                    {
                        Console.Write(character);
                        character++;
                    }
                    Console.WriteLine(" ");
                */

                // foreach
                string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
                foreach (var i in cars)
                {
                    Console.WriteLine(i);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block");
                Console.ReadLine();
            }
        }
    }
}


