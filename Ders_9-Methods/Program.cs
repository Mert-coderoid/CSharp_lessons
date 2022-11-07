// using System;

// namespace MyNamespace
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // erisim belirteci - geri dönüş tipi - metot adı - parametreler
//             // access modifier - return type - method name - parameters

//             /*
//                 void - geri dönüş tipi olmadığı için metot içerisinde return anahtar kelimesi kullanılmaz
//                 void - there is no return type so we can't use return keyword in the method
//             */
//             /*
//                 static - metotun sınıfın içerisinde tanımlanması gerektiğini belirtir
//                 static - it means that the method must be defined inside the class
//             */
//             Methods sample = new Methods();

//             try
//             {
//                 int number1 = 10;
//                 int number2 = 20;

//                 int result = Add(number1, number2);
//                 Console.WriteLine();
//                 sample.log(Convert.ToString(result));
//                 sample.log(Convert.ToString(number1+number2));
//             }
//             catch (Exception ex)
//             {
//                 sample.log(ex.Message);
//             }
//             finally
//             {
//                 sample.log("Finally block");
//                 Console.ReadLine();
//             }
//         }

// /*         static int Add(int number1, int number2)
//         {
//             return number1 + number2;
//         } */
//     }
// /*
//     class Methods
//     {
//         public void log(string message)
//         {
//             Console.WriteLine(message);
//         }

//         public int IncreaseAndAdd(int value1, int value2)
//         {
//             value1 += 1;
//             value2 += 1;
//             return value1 + value2;
//         }
//     } */
// }


// ********************* Ders 10 *********************
/* 
using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {

            Methods methods = new Methods();
            try
            {
                string number = "1234";
                bool result = int.TryParse(number, out int outNumber);

                if (result)
                {
                    Console.WriteLine("Converted");
                    Console.WriteLine(outNumber);
                }
                else
                {
                    Console.WriteLine("Not converted");
                }

                methods.Add(1, 2, out int outResult);
                methods.log(Convert.ToString(outResult));

                // overloading
                int number1 = 2;
                methods.log(number1);

                // Method signature
                // method name + parameter count + parameter type
                methods.log("Hello", "World");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // shut program in 3 seconds
                System.Threading.Thread.Sleep(3000);
            }
        }
    }

    class Methods
    {
        public void log(string message)
        {
            Console.WriteLine(message);
        }

        public void log(int message)
        {
            Console.WriteLine(message);
        }

        public void log(string message1, string message2)
        {
            Console.WriteLine(message1);
            Console.WriteLine(message2);
        }

        public int IncreaseAndAdd(int value1, int value2)
        {
            value1 += 1;
            value2 += 1;
            return value1 + value2;
        }

        public void Add(int number1, int number2, out int result)
        {
            result = number1 + number2;
        }
    }
}
*/

// ********************* Ders 11 *********************

using System;

namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new();
            try
            {
                // Recursive method - Özyinelemeli metot

                Console.WriteLine(methods.Factorial(5));
                Console.WriteLine(methods.Expo(4, 3));

                // Extension method
                string expression = "Ben bir malım gelin beni alın";
                bool result = expression.CheckSpaces();
                Console.WriteLine(result);
                if (result)
                {
                    expression = expression.RemoveSpaces();
                    Console.WriteLine(expression);
                }

                Console.WriteLine(expression.MakeUpperCase());
                Console.WriteLine(expression.MakeLowerCase());

                int[] array = { 9, 3, 6, 2, 1 };
                array.SortArray();
                array.PrintArray();

                int number = 4;
                Console.WriteLine(number.IsEvenNumber());
                Console.WriteLine(number.IsOddNumber());

                string str = "Ben bir malım gelin beni alın";
                string GetFirstCharacter = str.GetFirstCharacter();
                Console.WriteLine(GetFirstCharacter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                System.Threading.Thread.Sleep(3000);
            }
        }
    }

    public class Methods
    {
        public int Factorial(int number)
        {
            if (number < 0)
                throw new Exception("Number must be greater than 0");
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
        }

        public int Expo(int number, int power)
        {
            if (power < 2)
                return number;
            return number * Expo(number, power - 1);
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveSpaces(this string param)
        {
            string[] array = param.Split(" ");
            return string.Join("", array);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void PrintArray(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static bool IsOddNumber(this int param)
        {
            return param % 2 == 1;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
