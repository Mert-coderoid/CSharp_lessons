using System;

// ********************* Ders 4 *************************
    // Implicit Conversion (Bilinçsiz Dönüşüm)
namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Sena";
            char f = 'K';
            object g = e + f + d;
            Console.WriteLine("g: " + g);   // output: SenaK35


            // Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("***Explicit Conversion***");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);  // output: 4
            
            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);   // output: 100

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);   // output: 10


            // ToString Method
            Console.WriteLine("***ToString Method***");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);  // output: 6

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);  // output: 12.5

            // System.Convert
            Console.WriteLine("***System.Convert***");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + Toplam);  // output: 30

            // Parse Method
            Console.WriteLine("***Parse Method***");
            ParseMethod();


            // long to int
            Console.WriteLine("***long to int***");
            long sayi = 2147483648;
            int intSayi = (int)sayi;
            Console.WriteLine("intSayi: " + intSayi);  // output: -2147483648


            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double ondalikliSayi;

            rakam1 = Int32.Parse(metin1);
            ondalikliSayi = Double.Parse(metin2); 
            Console.WriteLine("rakam1: " + rakam1);  // output: 10
            Console.WriteLine("ondalikliSayi: " + ondalikliSayi);  // output: 10.25
        }
    }
}