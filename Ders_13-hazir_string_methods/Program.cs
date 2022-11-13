/* using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string phrase = "Ben bir malım gelin beni alın";
                Console.WriteLine(phrase.Length);
                Console.WriteLine(phrase.ToUpper());
                Console.WriteLine(phrase.ToLower()); 

                Console.WriteLine(String.Concat(phrase, " ", "Biraz daha mal oldum"));

                Console.WriteLine(phrase.CompareTo("Ben bir malım gelin beni alın"));

                Console.WriteLine(String.Compare("Ben bir malım gelin beni alın", "ben bir malım gelin beni alın", false));

                Console.WriteLine(phrase.Contains("malım"));
                Console.WriteLine(phrase.EndsWith("alın"));
                Console.WriteLine(phrase.StartsWith("Ben"));
                
                Console.WriteLine(phrase.IndexOf("malım"));

                Console.WriteLine(phrase.Insert(0, "Biraz daha mal oldum"));

                Console.WriteLine(phrase.LastIndexOf("malım"));

                Console.WriteLine(phrase + (" Biraz daha mal oldum").PadLeft(30));
                Console.WriteLine(phrase.PadRight(60,'0') + (" Biraz daha mal oldum"));

                Console.WriteLine(phrase.Remove(0, 3));

                Console.WriteLine(phrase.Replace("malım", "malıyım"));

                Console.WriteLine(phrase.Substring(0, 3));

                Console.WriteLine(phrase.Split(' ')[0]);
                Console.WriteLine(phrase.Split(' ')[1]);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
                
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
} */
/* 
using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(DateTime.Now);    // 2021-03-01 22:00:00
                Console.WriteLine(DateTime.Now.ToLongDateString());   // 1 Mart 2021 Cuma
                Console.WriteLine(DateTime.Now.ToShortDateString());  // 01.03.2021
                Console.WriteLine(DateTime.Now.ToLongTimeString());   // 22:00:00
                Console.WriteLine(DateTime.Now.ToShortTimeString());  // 22:00
                Console.WriteLine(DateTime.Now.AddDays(2));   // 2021-03-03 22:00:00
                Console.WriteLine(DateTime.Now.AddHours(3));  // 2021-03-02 01:00:00
                Console.WriteLine(DateTime.Now.AddSeconds(30));   // 2021-03-01 22:00:30
                Console.WriteLine(DateTime.Now.Month);    // 3
                Console.WriteLine(DateTime.Now.Day);  // 1
                Console.WriteLine(DateTime.Now.Year); // 2021
                Console.WriteLine(DateTime.Now.DayOfWeek);  // Friday
                Console.WriteLine(DateTime.Now.DayOfYear);  // 60
                Console.WriteLine(DateTime.Now.Hour);   // 22
                Console.WriteLine(DateTime.Now.Minute); // 0
                Console.WriteLine(DateTime.Now.Second); // 0
                Console.WriteLine(DateTime.Now.Millisecond);  // 0
                Console.WriteLine(DateTime.Now.Ticks);    // 637522400000000000
                Console.WriteLine(DateTime.Now.Date); // 1.03.2021 00:00:00
                Console.WriteLine(DateTime.Now.TimeOfDay);   // 22:00:00.0000000
                Console.WriteLine(DateTime.Now.Kind);    // Local
                Console.WriteLine(DateTime.Now.IsDaylightSavingTime());  // False
                Console.WriteLine(DateTime.Now.ToUniversalTime());   // 2021-03-01 19:00:00
                Console.WriteLine(DateTime.Now.ToLocalTime());   // 2021-03-01 22:00:00
    
                Console.WriteLine(DateTime.Now.ToString());  // 1.03.2021 22:00:00
                Console.WriteLine(DateTime.Now.ToString("dd"));   // 01
                Console.WriteLine(DateTime.Now.ToString("ddd"));  // Fri
                Console.WriteLine(DateTime.Now.ToString("dddd")); // Friday
                Console.WriteLine(DateTime.Now.ToString("MM"));   // 03
                Console.WriteLine(DateTime.Now.ToString("MMM"));  // Mar
                Console.WriteLine(DateTime.Now.ToString("MMMM")); // Mart
                Console.WriteLine(DateTime.Now.ToString("yy"));   // 21
                Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2021

                // Math library
                Console.WriteLine(Math.Abs(-25));   // 25
                Console.WriteLine(Math.Sin(90));    // 0.8939966636005579
                Console.WriteLine(Math.Cos(90));    // -0.4480736161291701
                Console.WriteLine(Math.Tan(90));    // -1.995200412208242
                Console.WriteLine(Math.Ceiling(22.3));  // 23
                Console.WriteLine(Math.Floor(22.3));    // 22
                Console.WriteLine(Math.Round(22.3));    // 22
                Console.WriteLine(Math.Max(2, 6));  // 6
                Console.WriteLine(Math.Min(2, 6));  // 2
                Console.WriteLine(Math.Pow(3, 4));  // 81
                Console.WriteLine(Math.Sqrt(9));    // 3
                Console.WriteLine(Math.Log(2)); // 0.6931471805599453
                Console.WriteLine(Math.Log10(2));   // 0.3010299956639812
                Console.WriteLine(Math.Exp(3)); // 20.085536923187668

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
                
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
}
 */
/* 
using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Collections
                // System.Collections.Generic
                // List<T> class    // T = Type -> object type

                List<int> numbers = new List<int>();

                numbers.Add(1);
                numbers.Add(2);
                numbers.Add(3);
                numbers.Add(4);
                numbers.Add(5);
                numbers.Add(5);
                numbers.Add(65);
                numbers.Add(852);

                List<string> names = new List<string>();

                names.Add("Ali");
                names.Add("Veli");
                names.Add("Ayşe");
                names.Add("Fatma");
                names.Add("Ali");

                Console.WriteLine(numbers.Count);   // 8
                Console.WriteLine(names.Count); // 5

                Console.WriteLine();

                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();

                foreach (var item in names)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();
                numbers.ForEach(number => Console.WriteLine(number));
                Console.WriteLine();
                names.ForEach(name => Console.WriteLine(name));
                Console.WriteLine();

                numbers.Remove(5);
                numbers.RemoveAt(0);
                names.Remove("Ali");
                names.RemoveAt(0);

                numbers.ForEach(number => Console.WriteLine(number));
                Console.WriteLine();
                names.ForEach(name => Console.WriteLine(name));
                Console.WriteLine();

                if (numbers.Contains(65))
                {
                    Console.WriteLine("65 is in the list");
                }

                Console.WriteLine(numbers.BinarySearch(65));  // 5
                Console.WriteLine(numbers.BinarySearch(8521)); // 6

                string[] array = names.ToArray();
                List<string> list = array.ToList();

                Console.WriteLine();

                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }

                names.Clear();

                Console.WriteLine("0");

                foreach (var item in names)
                {
                    Console.WriteLine(item);
                }

                List<Users> users = new List<Users>();

                Users user1 = new Users();
                user1.Name = "Ali";
                user1.Surname = "Veli";
                user1.Age = 1;

                Users user2 = new Users();
                user2.Name = "Ayşe";
                user2.Surname = "Fatma";
                user2.Age = 2;

                users.Add(user1);
                users.Add(user2);

                List<Users> users2 = new List<Users>();
                users2.Add(new Users { Name = "Ali", Surname = "Veli", Age = 1 });
                users2.Add(new Users { Name = "Ayşe", Surname = "Fatma", Age = 2 });

                users.ForEach(user => Console.WriteLine(user.Name + " " + user.Surname + " " + user.Age));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
                System.Threading.Thread.Sleep(3000);
            }
        }
    }

    public class Users
    {
        private string _name;
        private string _surname;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

    }
} */
/* 
using System;
using System.Collections;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList list = new ArrayList();
                list.Add(1);
                list.Add("Ali");
                list.Add(3.14);
                list.Add(true);
                list.Add('A');

                // foreach (var item in list)
                // {
                //     Console.WriteLine(item);
                // }

                Console.WriteLine();

                // AddRange
                string[] array = { "Ali", "Veli", "Ayşe", "Fatma" };
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                list.AddRange(array);
                list.AddRange(numbers);  

                // listenin son elemanını yazdır
                Console.WriteLine(list[list.Count - 1]);

                // foreach (var item in list)
                // {
                //     Console.WriteLine(item);
                // }

                // Sort
                // when use sort method, all elements must be same type if not, it will throw an exception

                // BinarySearch
                Console.WriteLine(numbers.BinarySearch(5));  // 4
                Console.WriteLine(numbers.BinarySearch(15)); // -11

                // Reverse
                list.Reverse();
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
}
 */

using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
}

/* 
// Bir sınıfın diğer sınıflar tarafından türetilmesi engellenmek isteniyorsa, aşağıdaki anahtar kelimelerden hangisi kullanılmalıdır?

cevap: sealed

// Bir sınıfında hem normal uurucusu hem de statik kurucusu aynı anda bulunamaz." Ifadenin doğruluğunu teyit ediniz.

cevap: yanlış

// Aşağıdaki kavramlardan hangisini aynı isimde fakat farklı dönüş tipleri yada parametreler ile method tanımladığımızda kullanırız?

cevap: method overloading

// Temel sınıfın üyelerinden birinin sadece türetildiği sınıflardan erişilmesi isteniyorsa aşağıdaki erişim belirteçlerinden hangisi kullanılmalıdır?

cevap: protected

// Aşağıdaki tip dönüşümlerinden hangisini explicit dahi olsa gerçekleştiremeyiz?

byte -> int
string -> byte
decimal -> float
long -> int

cevap: string -> byte

// Statik sınıflarla ilgili aşağıdakilerden hangisi yanlıştır?

cevap: Statik sınıfların nesneleri oluşturulamaz. */