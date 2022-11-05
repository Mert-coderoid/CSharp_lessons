using System;

namespace MyNamespace
{
    class Program
    {
        // ***************** Ders 5 *****************
        // Try Catch and Logical Errors

        static void Main(string[] args)
        {
            /*             
                // Hataya neden olan kodlar try içine yazılır.

                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz sayı: " + sayi); 

            */

            /*             
                try
                {
                    Console.WriteLine("Bir sayı giriniz: ");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Girdiğiniz sayı: " + sayi);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message.ToString());
                }
                finally
                {
                    Console.WriteLine("Çıkmak için bir tuşa basınız.");
                    Console.ReadKey();
                }

            */


            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz\n" + "Hata: " + ex.Message.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Geçersiz karakter girdiniz\n" + "Hata: " + ex.Message.ToString());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok büyük veya çok küçük bir değer girdiniz\n" + "Hata: " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("Çıkmak için bir tuşa basınız.");
                Console.ReadKey();
            }

        }
    }
}



/* Agagdaki durumlardan hangisinde derleme zaman hatas abinmaz?
O Degigken tipine uyumsuz bir deger atamaya calighgimizda
O Degiskenler arasinda uyurnsuz bir operator kullandigimizda
O Komutu; ile sonlandimadigimizda
O int degigkeni decimal degiskene atamaya galighgimizda

Cevap: 1 */
