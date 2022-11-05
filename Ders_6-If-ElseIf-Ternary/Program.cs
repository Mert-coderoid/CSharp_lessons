// ************************* Ders 6 *************************
// if else ternary operator
/* 
    try
    {
        int time = DateTime.Now.Hour;
        if (time <= 10)
            Console.WriteLine("Günaydın");
        else if (time >= 11 && time <= 17)
            Console.WriteLine("İyi günler");
        else
            Console.WriteLine("İyi akşamlar");

        string sonuc = time <= 10 ? "Günaydın" : time >= 11 && time <= 17 ? "İyi günler" : "İyi akşamlar";
        Console.WriteLine(sonuc);

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("İşlem Tamamlandı");
        Console.ReadLine();
    }
*/

// ************************* Ders 7 *************************
// switch case yapısı

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Geçersiz ay");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("İşlem Tamamlandı");
            Console.ReadLine();
        }
    }
}