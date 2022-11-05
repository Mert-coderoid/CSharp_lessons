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

            // - "Parse" ifadesi değişken dönüşümü yapmak için kullanılır.

            string number28 = "10";
            int number29 = int.Parse(number28);
            Console.WriteLine(number29 + 5);

            string number30 = "10.25";
            double number31 = double.Parse(number30);

            // - "TryParse" ifadesi değişken dönüşümü yapmak için kullanılır.

            string number32 = "10";
            int number33;
            bool result = int.TryParse(number32, out number33);
            Console.WriteLine(number33 + 5);

            string number34 = "10.25";
            double number35;
            bool result2 = double.TryParse(number34, out number35);

            // - "ToString" ifadesi değişken dönüşümü yapmak için kullanılır.

            int number36 = 10;
            string number37 = number36.ToString();
            Console.WriteLine(number37 + 5);

            double number38 = 10.25;
            string number39 = number38.ToString();

            // - "GetType" ifadesi değişkenin tipini öğrenmek için kullanılır.

            int number40 = 10;
            Console.WriteLine(number40.GetType());

            double number41 = 10.25;
            Console.WriteLine(number41.GetType());

            string character9 = "A";
            Console.WriteLine(character9.GetType());

            // - "GetTypeCode" ifadesi değişkenin tipini öğrenmek için kullanılır.

            int number42 = 10;
            Console.WriteLine(number42.GetTypeCode());

            double number43 = 10.25;
            Console.WriteLine(number43.GetTypeCode());

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


// ##################### DERS 3 #####################
            int x = 10;
            int y = 20;
            int z = 30;

            // - "++" ifadesi değişkenin değerini 1 arttırmak için kullanılır.

            x++;
            Console.WriteLine(x); // output: 11

            // - "--" ifadesi değişkenin değerini 1 azaltmak için kullanılır.

            y--;
            Console.WriteLine(y); // output: 19

            // - "+=" ifadesi değişkenin değerini belirtilen sayı kadar arttırmak için kullanılır.

            z += 5;
            Console.WriteLine(z); // output: 35

            // - "-=" ifadesi değişkenin değerini belirtilen sayı kadar azaltmak için kullanılır.

            z -= 5;
            Console.WriteLine(z); // output: 30

            // - "*=" ifadesi değişkenin değerini belirtilen sayı ile çarpmak için kullanılır.

            z *= 5;
            Console.WriteLine(z); // output: 150

            // - "/=" ifadesi değişkenin değerini belirtilen sayıya bölerek atamak için kullanılır.

            z /= 5;
            Console.WriteLine(z); // output: 30

            // - "%=" ifadesi değişkenin değerini belirtilen sayıya bölerek kalanı atamak için kullanılır.

            z %= 5;
            Console.WriteLine(z); // output: 0

            // - "==" ifadesi değişkenin değerinin eşit olup olmadığını kontrol etmek için kullanılır.

            int a = 10;
            int b = 20;
            Console.WriteLine(a == b); // output: False

            // - "!=" ifadesi değişkenin değerinin eşit olmadığını kontrol etmek için kullanılır.

            Console.WriteLine(a != b); // output: True

            // - ">" ifadesi değişkenin değerinin belirtilen sayıdan büyük olup olmadığını kontrol etmek için kullanılır.

            Console.WriteLine(a > b); // output: False

            // - "<" ifadesi değişkenin değerinin belirtilen sayıdan küçük olup olmadığını kontrol etmek için kullanılır.

            Console.WriteLine(a < b); // output: True

            // - ">=" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya eşit olup olmadığını kontrol etmek için kullanılır.

            Console.WriteLine(a >= b); // output: False

            // - "<=" ifadesi değişkenin değerinin belirtilen sayıdan küçük veya eşit olup olmadığını kontrol etmek için kullanılır.

            Console.WriteLine(a <= b); // output: True

            // - "&&" ifadesi değişkenin değerinin belirtilen sayıdan büyük ve küçük olup olmadığını kontrol etmek için kullanılır.

            Console.WriteLine(a > 5 && a < 15); // output: True

            // - "||" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya küçük olup olmadığını kontrol etmek için kullanılır.

            Console.WriteLine(a > 5 || a < 15); // output: True

            // - "!" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya küçük olup olmadığını kontrol etmek için kullanılır.

            Console.WriteLine(!(a > 5 || a < 15)); // output: False

            // - "if" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya küçük olup olmadığını kontrol etmek için kullanılır.

            if (a > 5)
            {
                Console.WriteLine("a is greater than 5");
            }
            else if (a < 5)
            {
                Console.WriteLine("a is less than 5");
            }
            else
            {
                Console.WriteLine("a is equal to 5");
            }

            // - "switch" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya küçük olup olmadığını kontrol etmek için kullanılır.

            switch (a)
            {
                case 1:
                    Console.WriteLine("a is equal to 1");
                    break;
                case 2:
                    Console.WriteLine("a is equal to 2");
                    break;
                case 3:
                    Console.WriteLine("a is equal to 3");
                    break;
                default:
                    Console.WriteLine("a is not equal to 1, 2 or 3");
                    break;
            }

            // - "while" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya küçük olup olmadığını kontrol etmek için kullanılır.

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // - "do while" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya küçük olup olmadığını kontrol etmek için kullanılır.

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 10);

            // - "for" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya küçük olup olmadığını kontrol etmek için kullanılır.

            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine(k);
            }

            // - "foreach" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya küçük olup olmadığını kontrol etmek için kullanılır.

            string[] names = { "John", "Jane", "Mary" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // - "break" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya küçük olup olmadığını kontrol etmek için kullanılır.

            for (int k = 0; k < 10; k++)
            {
                if (k == 5)
                {
                    break;
                }
                Console.WriteLine(k);
            }

            // - "continue" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya küçük olup olmadığını kontrol etmek için kullanılır.

            for (int k = 0; k < 10; k++)
            {
                if (k == 5)
                {
                    continue;
                }
                Console.WriteLine(k);
            }


            // - "goto" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya küçük olup olmadığını kontrol etmek için kullanılır.

            for (int k = 0; k < 10; k++)
            {
                if (k == 5)
                {
                    goto end;
                }
                Console.WriteLine(k);
            }
            end:
            Console.WriteLine("end");


            // - "try catch" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya küçük olup olmadığını kontrol etmek için kullanılır.

            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[10]);
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished");
            }

            // - "throw" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya küçük olup olmadığını kontrol etmek için kullanılır.

            int age = 15;
            if (age < 18)
            {
                throw new Exception("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }

            // - "return" ifadesi değişkenin değerinin belirtilen sayıdan büyük veya küçük olup olmadığını kontrol etmek için kullanılır.

            int sum(int x, int y)
            {
                return x + y;
            }
            Console.WriteLine(sum(5, 3));    
        }
    }
}