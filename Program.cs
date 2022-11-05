using System;

namespace console_programing_csharp
{
    // - "Program" class'ı içerisinde Main methodu tanımlanır.
    class Program
    {
        /* 
            - "Main" fonksiyonu ana programın başlangıç noktasıdır.
            - "public" ifadesi fonksiyonun erişim belirleyicisidir. Bu ifade fonksiyonun dışarıdan erişilebilir olduğunu belirtir.
            - "static" ifadesi fonksiyonun sınıfın örneği olmadan çağrılabilmesini sağlar.
            - "void" ifadesi fonksiyonun döndürdüğü değer tipini belirtir. void ifadesi fonksiyonun döndürdüğü değer tipinin olmadığını belirtir.
            - "Main" fonksiyonunun parametreleri yoktur.
            - "args" ifadesi fonksiyonun parametrelerini belirtir. args ifadesi fonksiyonun parametrelerinin olmadığını belirtir.
        */
        public static void Main(string[] args)
        {   
            // ##################### DERS 1 #####################
            // - "Console.WriteLine" ifadesi ekrana yazı yazdırmak için kullanılır.
            // - "Console.ReadLine" ifadesi kullanıcıdan veri almak için kullanılır.
            /* 
                Console.WriteLine("Hello World!");
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your surname: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Hello " + name + " " + surname);
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();

            */

            // ##################### DERS 2 #####################

            // - "byte" ifadesi 8 bitlik yani 1 byte'lık bir tamsayı tipidir. 0 ile 255 arasında değer alır.
            // - "sbyte" ifadesi 8 bitlik yani 1 byte'lık bir tamsayı tipidir. -128 ile 127 arasında değer alır.

            byte number1 = 255;
            sbyte number2 = 127;

            // - "short" ifadesi 16 bitlik yani 2 byte'lık bir tamsayı tipidir. -32768 ile 32767 arasında değer alır.
            // - "ushort" ifadesi 16 bitlik yani 2 byte'lık bir tamsayı tipidir. 0 ile 65535 arasında değer alır.

            short number3 = 32767;
            ushort number4 = 65535;

            // - "int16" ifadesi 16 bitlik yani 2 byte'lık bir tamsayı tipidir. -32768 ile 32767 arasında değer alır. 
            // - "uint16" ifadesi 16 bitlik yani 2 byte'lık bir tamsayı tipidir. 0 ile 65535 arasında değer alır.

            Int16 number5 = 32767;
            UInt16 number6 = 65535;

            // - "int" ifadesi 32 bitlik yani 4 byte'lık bir tamsayı tipidir. -2147483648 ile 2147483647 arasında değer alır.
            // - "uint" ifadesi 32 bitlik yani 4 byte'lık bir tamsayı tipidir. 0 ile 4294967295 arasında değer alır.

            int number7 = 2147483647;
            uint number8 = 4294967295;

            // - "int32" ifadesi 32 bitlik yani 4 byte'lık bir tamsayı tipidir. -2147483648 ile 2147483647 arasında değer alır.
            // - "uint32" ifadesi 32 bitlik yani 4 byte'lık bir tamsayı tipidir. 0 ile 4294967295 arasında değer alır.

            Int32 number9 = 2147483647;
            UInt32 number10 = 4294967295;

            // - "int64" ifadesi 64 bitlik yani 8 byte'lık bir tamsayı tipidir. -9223372036854775808 ile 9223372036854775807 arasında değer alır.
            // - "uint64" ifadesi 64 bitlik yani 8 byte'lık bir tamsayı tipidir. 0 ile 18446744073709551615 arasında değer alır.

            Int64 number11 = 9223372036854775807;
            UInt64 number12 = 18446744073709551615;

            // - "long" ifadesi 64 bitlik yani 8 byte'lık bir tamsayı tipidir. -9223372036854775808 ile 9223372036854775807 arasında değer alır.
            // - "ulong" ifadesi 64 bitlik yani 8 byte'lık bir tamsayı tipidir. 0 ile 18446744073709551615 arasında değer alır.

            long number13 = 9223372036854775807;
            ulong number14 = 18446744073709551615;

            // - "float" ifadesi 32 bitlik yani 4 byte'lık bir ondalıklı sayı tipidir. 1.5 x 10^-45 ile 3.4 x 10^38 arasında değer alır.
            // - "double" ifadesi 64 bitlik yani 8 byte'lık bir ondalıklı sayı tipidir. 5.0 x 10^-324 ile 1.7 x 10^308 arasında değer alır.
            // - "decimal" ifadesi 128 bitlik yani 16 byte'lık bir ondalıklı sayı tipidir. 1.0 x 10^-28 ile 7.9 x 10^28 arasında değer alır.

            float number15 = 3.14f;
            double number16 = 3.14;
            decimal number17 = 3.14m;

            // - "char" ifadesi 16 bitlik yani 2 byte'lık bir karakter tipidir. 0 ile 65535 arasında değer alır.
            // - "string" ifadesi karakter dizisi tipidir. -> maliyeti yüksektir.

            char character1 = 'A';
            string character2 = "Hello World!";

            // - "bool" ifadesi 1 bitlik yani 1 byte'lık bir mantıksal tipidir. True ve False değerlerini alır. 

            bool condition = true;

            // - "object" ifadesi her türden veriyi tutan bir tipidir. -> maliyeti yüksektir.
                // aslında her veri tipi object tipinde bir veri tipidir.

            object number18 = 10;
            object character3 = 'A';
            object number19 = 3.14;
            object character4 = "Hello World!";
            object condition2 = true;

            // - "var" ifadesi değişkenin tipini otomatik olarak belirlemek için kullanılır. -> maliyeti yüksektir.

            var number20 = 10;
            var character5 = 'A';
            var number21 = 3.14;
            var character6 = "Hello World!";
            var condition3 = true;

            // - "dynamic" ifadesi değişkenin tipini otomatik olarak belirlemek için kullanılır. -> maliyeti yüksektir.

            dynamic number22 = 10;
            dynamic character7 = 'A';
            dynamic number23 = 3.14;
            dynamic character8 = "Hello World!";
            dynamic condition4 = true;

            // - DateTime ifadesi tarih ve saat bilgisini tutan bir tipidir.

            DateTime date = DateTime.Now;

            // - TimeSpan ifadesi iki tarih arasındaki zaman farkını tutan bir tipidir.

            TimeSpan time = DateTime.Now - date;

            // Değişken Dönüşümleri,

            // - "Convert" ifadesi değişken dönüşümü yapmak için kullanılır.

            string number24 = "10";
            int number25 = Convert.ToInt32(number24);
            Console.WriteLine(number25 + 5);

            string number26 = "10.25";
            double number27 = Convert.ToDouble(number26);
            Console.WriteLine(number27 + 3);

            string datetime  = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime); // output: 01.01.2021

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2); // output: 01/01/2021

            string datetime3 = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine(datetime3); // output: 01-01-2021

            string datetime4 = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            Console.WriteLine(datetime4); // output: 01.01.2021 00:00:00

            string datetime5 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            Console.WriteLine(datetime5); // output: 01/01/2021 00:00:00

            string datetime6 = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            Console.WriteLine(datetime6); // output: 01-01-2021 00:00:00

            

            

            



            // - "int" ifadesi integer türünden bir değişken tanımlamak için kullanılır.
            int deger;
            // Convert sınıfı ile string ifadeyi integer türüne çeviriyoruz.
                // ToInt32() fonksiyonu ile string ifadeyi integer türüne çeviriyoruz.
                /* Convert sınıfndaki diğer fonksiyonlar:
                    - ToBoolean()
                    - ToByte()
                    - ToChar()
                    - ToDateTime()
                    - ToDecimal()
                    - ToDouble()
                    - ToInt16()
                    - ToInt64()
                    - ToSByte()
                    - ToSingle()
                    - ToString()
                    - ToUInt16()
                    - ToUInt32()
                    - ToUInt64() 
                */
            Console.WriteLine("Enter a number: ");
            deger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number you entered is: " + (deger + 5) );
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}