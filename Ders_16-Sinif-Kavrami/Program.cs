/* using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Worker worker = new Worker("Ali", "Veli", 123, "IT");
                // worker.Ad = "Ali";
                // worker.Soyad = "Veli";
                // worker.No = 123;
                // worker.Departman = "IT";
                worker.WorkerInfo();
                
                Console.WriteLine();
                
                Worker worker2 = new Worker("Ayşe", "Fatma", 456, "HR");
                // worker2.Ad = "Ayşe";
                // worker2.Soyad = "Fatma";
                // worker2.No = 456;
                // worker2.Departman = "İnsan Kaynakları";
                worker2.WorkerInfo();
    
                Console.WriteLine();

                Worker worker3 = new Worker("Ahmet", "Mehmet");
                worker3.WorkerInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
                Thread.Sleep(5000);
            } 
        }
    }

    class Worker
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Worker(string ad, string soyad, int no, string departman)
        {
            Console.WriteLine("Worker class constructor executed");

            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Worker(string ad, string soyad)
        {
            Console.WriteLine("Worker class constructor executed");
            
            this.Ad = ad;
            this.Soyad = soyad;
        }
        
        public void WorkerInfo()
        {
            Console.WriteLine("Ad: {0}", Ad);
            Console.WriteLine("Soyad: {0}", Soyad);
            if (No != 0)
            {
                Console.WriteLine("No: {0}", No);
            }
            if (Departman != null)
            {
                Console.WriteLine("Departman: {0}", Departman);
            }
            
        }
    }
}
*/
/* 
using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Student student = new Student("Ali", "Veli", 123, 3);
                student.Name = "MAli";
                student.Surname = "MVeli";
                student.StudentNo = 123;
                student.Class = 3;

                student.StudentInfo();
                Console.WriteLine();

                Student student2 = new Student("Ayşe", "Fatma", 456, 5);
                student2.Name = "Mayşe";
                student2.Surname = "Matma";
                student2.StudentNo = 789;
                student2.Class = 4;

                student2.StudentInfo();
                Console.WriteLine();

                Student student3 = new Student("Ahmet", "Mehmet", 789, 2);
                student3.Name = "MAhmet";
                student3.Surname = "MMehmet";
                student3.StudentNo = 789;
                student3.Class = 1;

                student3.DecreaseClass();
                student3.DecreaseClass();
                student3.StudentInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
                Thread.Sleep(5000);
            }
        }
    }

    class Student
    {
        private string _name;
        private string _surname;
        private int _studentNo;
        private int _class;

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public int StudentNo { get => _studentNo; set => _studentNo = value; }
        public int Class
        {
            get => _class;
            set
            {
                if (value < 1)
                {
                    throw new Exception("Class value cannot be less than 1");
                }
                else
                {
                    _class = value;
                }
            }
        }

        public Student(string name, string surname, int studentNo, int @class)
        {
            this.Name = name;
            this.Surname = surname;
            this.StudentNo = studentNo;
            this.Class = @class;
        }

        public Student() { }

        public void StudentInfo()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Surname: {0}", Surname);
            Console.WriteLine("Student No: {0}", StudentNo);
            Console.WriteLine("Class: {0}", Class);
        }

        public void IncreaseClass()
        {
            this.Class++;
        }

        public void DecreaseClass()
        {
            this.Class--;
        }

    }
}

 */
/* 
using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Calisan calisan = new Calisan("Ali", "Veli", "IK");  
                Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
                Calisan calisan2 = new Calisan("Deniz", "Kurt", "IT");
                Calisan calisan3 = new Calisan("Ayşe", "Fatma", "HR");

                Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
                Thread.Sleep(5000);
            }
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

        private string ad;
        private string soyad;
        private string departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string ad, string soyad, string departman)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.departman = departman;
            calisanSayisi++;
        }
    }
} */
/* 
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.UzunKenar = 5;
            dikdortgen.KisaKenar = 3;
            Console.WriteLine("Dikdörtgenin alanı: {0}", dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();
            dikdortgen_Struct.UzunKenar = 5;
            dikdortgen_Struct.KisaKenar = 3;
            Console.WriteLine("Dikdörtgenin alanı: {0}", dikdortgen_Struct.AlanHesapla());

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed");
            Thread.Sleep(5000);
        }

    }


    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }
    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }
} */

/* using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // enum kullanımı
                Console.WriteLine(Gunler.Pazartesi);
                Console.WriteLine((int)Gunler.Pazartesi);
                Console.WriteLine((int)Gunler.Salı);
                Console.WriteLine((int)Gunler.Çarşamba);
                Console.WriteLine((int)Gunler.Perşembe);
                Console.WriteLine((int)Gunler.Cuma);

                int sicaklik = 50;

                if(sicaklik <= (int)HavaDurumu.Soguk)
                {
                    Console.WriteLine("Hava çok soğuk");
                }
                else if(sicaklik <= (int)HavaDurumu.Normal)
                {
                    Console.WriteLine("Hava normal");
                }
                else if(sicaklik <= (int)HavaDurumu.Sicak)
                {
                    Console.WriteLine("Hava sıcak");
                }
                else
                {
                    Console.WriteLine("Hava çok sıcak");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
                Thread.Sleep(5000);
            }

        }
    }

    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe = 10,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 25,
        Sicak = 40
    }

}
 */

/* Soru - 1/15
Bir sınıf kapsamında tanımlanmış değişkenlere ne ad verilir?

1 - Field
2 - Variable
3 - Property
4 - Sabit

cevap: 1

Soru - 2/15
Bir sınıfın nesnesi ilk oluşturulduğunda yapılması gerekenler varsa aşağıdakilerden hangisi kullanılır?

1 - Overload Metot
2 - Static Metot
3 - Extension Metot
4 - Constructor Metot

cevap: 4

Soru - 3/15
Tanımlanan sınıftan örneği oluşturulan bazı nesnelerin farklı durumlarda başlatılması gerektiğinde aşağıdakilerden hangisi kullanılır?

1 - Overload Metot
2 - Static Metot
3 - Extension Metot
4 - Constructor Metot

cevap: 1

Soru - 4/15
"new anahtar sözcüğünü kullanarak bir nesne yaratıldığında, nesneyi oluşturmak için gerekli bellek …………… üzerinden alınır." Boş bırakılan yere aşağıdakilerden hangisi getirilmelidir?

1 - Heap
2 - Stack
3 - Garbage Collector
4 - Memory

cevap: 1

Soru - 5/15
"Öğenin yığından öbeğe otomatik kopyalanmasına …………… adı verilir." Boş bırakılan yere aşağıdakilerden hangisi getirilmelidir?

1 - Boxing
2 - Unboxing
3 - Garbage Collector
4 - Memory

cevap: 1

Soru - 6/15
Statik bir sınıf içerisine aşağıdaki komutlardan hangisini yazarsak compile time da hata verir?

O private int x;
O public const double sayi = 5
O public static EkranaYazdir()
O public static y = 5;

cevap: 1

"Statik metotları kullanmak için mutlaka sınıfın bir örneğini oluşturmak gerekir." Ifadenin doğruluğunu teyit ediniz?

cevap: yanlış

Statik sınıflarla ilgili aşağıdakilerden hangisi yanlıştır?

O Static siniflar yanlizca iyeler barindirabilir.
O Nesneleri yaratilmadan uyelerine erisilebilir.
O Dedgiskenleri sinif tarafindan paylasilir.
© Kurucu metotlari yoktur.

cevap: 4

Temel sınıfın bir üyesine, sadece bu sınıftan türemiş bir sınıfın erişebilmesi istiyorsak erişim belirteci olarak aşağıdakilerden hangisini kullanmamız gerekir?

O public
O private
O protected
O internal

cevap: 3

Yapılarla ilgili aşağıdakilerden hangisi yanlıştır?

O Diger struct'lardan kalrtim alamazlar.
O Interface'lerden kalitim alamazlar.
© Siniflardan kalitim alamazlar.

O new() anahtar sézcigi ile nesneleri yaratilabilir.

cevap: 3

Yapılarla ilgili aşağıdakilerden hangisi doğrudur?

O Yapilar icin varsayilan yapici metod (default constructor) yazamayiz.
O Yapilar sadece baska yapilar icerisinde kullanilabilir.
O Yapilar siniflari kapsar. Siniflarla yapabildigimiz herseyi yapilarla da yapabiliriz.

 Siniflar gibi referans tipindediler.

Bir sınıfında hem normal kurucusu hem de statik kurucusu aynı anda bulunamaz." Ifadenin doğruluğunu teyit ediniz.

cevap: doğru

"Statik kurucu metotlar ..... çalışır." Cümle içerisinde boş bırakılan yere aşağıdakilerden hangisi getirilebilir?

O Program ilk galistiginda
O Sinifin nesnesi her yaratildiginda
O Sinifin ilk nesnesi olusturuldugunda sadece 1 kez
Normal kurucu her çalıştığında

cevap: 3

Program içerisinde farklı değerler alabilen ifadelere ne ad verilir?


1 - Değişken
2 - Sabit
3 - Değer
4 - Değer Atama

cevap: 1

Sadece yazılabilir bir property tanımlamak istersek aşağıdakilerden hangisine ihtiyacımız vardır?


1 - get
2 - set
3 - get ve set
4 - get ve set olmadan

 */

using System;
using System.IO;
using System.Timers;

namespace CSharp
{
    public class Program
    {
        private static System.Timers.Timer aTimer;

        static void Main(string[] args)
        {
            // inheritance
            try
            {
                TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
                tohumluBitkiler.UyaranlaraTepki();
                // tohumluBitkiler.TohumlaCogalma();
                Console.WriteLine("**************");
                TohumsuzBitkiler tohumsuzBitkiler = new TohumsuzBitkiler();
                tohumsuzBitkiler.UyaranlaraTepki();
                // tohumsuzBitkiler.SporlaCogalma();
                Console.WriteLine("**************");
                Kediler kediler = new Kediler();
                kediler.UyaranlaraTepki();
                // kediler.Miyavlama();
                Console.WriteLine("**************");
                Kopekler kopekler = new Kopekler();
                kopekler.UyaranlaraTepki();
                // kopekler.Havlama();
                Console.WriteLine("**************");
                Insanlar insanlar = new Insanlar();
                insanlar.UyaranlaraTepki();
                // insanlar.Dusunme();
                Console.WriteLine("**************");
                ShutDown(1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                SetTimer();

                Console.WriteLine("\nPress the Enter key to exit the application...\n");
                Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
                Console.ReadLine();
                aTimer.Stop();
                aTimer.Dispose();

                Console.WriteLine("Terminating the application...");
            }

        }

        public static void ShutDown(int second)
        {
            // if aTimer is equal second then shutdown the program
            aTimer = new System.Timers.Timer(second * 1000);
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }

    public class Canlılar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım yapar.");
        }
        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }

    public class Hayvanlar : Canlılar
    {
        public Hayvanlar()
        {
            base.Solunum();
            base.Beslenme();
            base.Bosaltim();

        }
        protected void Hareket()
        {
            Console.WriteLine("Hayvanlar hareket eder.");
        }
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon yapar.");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar uyaranlara tepki verir.");
        }
    }

    public class Bitkiler : Canlılar
    {
        public Bitkiler()
        {
            base.Solunum();
            base.Beslenme();
            base.Bosaltim();

        }
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir.");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Solunum();
            base.Beslenme();
            base.Bosaltim();
            base.Fotosentez();
            base.UyaranlaraTepki();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }

    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Solunum();
            base.Beslenme();
            base.Bosaltim();
            base.Fotosentez();
            base.UyaranlaraTepki();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }

    public class Insanlar : Hayvanlar
    {
        public Insanlar()
        {
            base.Solunum();
            base.Beslenme();
            base.Bosaltim();
            base.Hareket();
            base.Adaptasyon();
            base.UyaranlaraTepki();
        }
        public void Dusunme()
        {
            Console.WriteLine("İnsanlar düşünür.");
        }

        public void Konusma()
        {
            Console.WriteLine("İnsanlar konuşur.");
        }
    }

    public class Kopekler : Hayvanlar
    {
        public Kopekler()
        {
            base.Solunum();
            base.Beslenme();
            base.Bosaltim();
            base.Hareket();
            base.Adaptasyon();
            base.UyaranlaraTepki();
        }
        public void Havlama()
        {
            Console.WriteLine("Köpekler havlar.");
        }
    }

    public class Kediler : Hayvanlar
    {
        public Kediler()
        {
            base.Hareket();
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.UyaranlaraTepki();
        }
        public void Miyavlama()
        {
            Console.WriteLine("Kediler miyavlar.");
        }
    }

}