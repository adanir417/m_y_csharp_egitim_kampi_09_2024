using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //---------------------------------------
            //---------------------------------------

            // Aynı veri türündeki çok sayıda veriyi bir arada tutmak için kullanılan yapılardır.

            // Çift sayılar dizisi
            // 2.4.6.8

            // Renkler dizisi
            // sarı,lacivert, siyah, kırmızı, turuncu, beyaz

            // Şehirler dizisi
            // adana,ankara,istanbul,bursa

            //Dizilerin tanımlanması
            // DeğişkenTürü [] DiziAdı = new DiziTürü[ElemanSayısı]

            //---------------------------------------
            //---------------------------------------

            //string[] colors = new string[4];
            //// sıfırıncı index 
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);
            //// Output: Beyaz

            //---------------------------------------


            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);
            //// Output: Üsküp

            //Console.WriteLine(cities[5]);
            //// Output: System.IndexOutOfRangeException
            //// Dizi sınırlarının dışına çıkıldığı için hata verdi.


            //---------------------------------------

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[7]);
            //// Output: 748

            //Console.WriteLine(numbers[5]);
            //// Output: 0


            // Eğer dizi tam sayı formatında ise(int türünde ise)
            // atanmamış bir değere ulaşmaya çalıştığımızda sıfır ile karşılaşırız.


            //---------------------------------------

            ////Diziler bu şekilde de tanımlanabilir.
            //string[] cities = {"Prag","Roma","Atina","Ankara","Bursa"};

            ////Console.WriteLine(cities[2]);
            //// Output: Atina

            //string[] citiesTwo = new string[6];
            //citiesTwo[0] = "Balıkesir";
            //citiesTwo[1] = "Prag";
            //citiesTwo[2] = "Roma";
            //citiesTwo[3] = "Atina";
            //citiesTwo[4] = "Ankara";
            //citiesTwo[5] = "Bursa";

            //Console.WriteLine(citiesTwo[0]);
            //// Output: Balıkesir

            //---------------------------------------


            #endregion

            #region Dizideki Tüm Elemanları Listeleme


            //---------------------------------------

            //string[] colors = { "Sarı", "Lacivert", "Siyah", "Beyaz", "Kırmızı", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //---------------------------------------

            // Bu dizi ile sonuç sadece 96 dönüyor.
            // int[] numbers = {4,85,96,74,125,635,488,520,7456,2365,1120 };

            // Bu dizi ile sonuç 96,75,522 dönüyor.
            //int[] numbers = {4,85,96,75,125,635,488,522,7456,2365,1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //---------------------------------------

            //char[] symbols = {'a','b','c','*','/','-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //---------------------------------------

            //Dizideki en büyük elemanı bulan yapı

            //int[] myArray = { 47,85,95,41,25,635,789,86,100 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    { 
            //       maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);
            //// Output: 789


            //---------------------------------------

            ////Dizinin diziAdı.Length dizinin büyüklüğünü verir. Yani kaç eleman barındırdığını verir.
            //// sayma sıfır(0) ile başladığı için son index büyüklüğün bir eksiğidir
            //// yani son index persons[persons.lenght-1] Bu değer burada beş(5).
            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //---------------------------------------

            //Dizilerin küçükten büyüğe sıralanması
            //int[] numbers = { 45,85,52,41,86,10,22,35 };

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //---------------------------------------

            //Dizilerin tersten sıralanması.
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };

            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //---------------------------------------

            // Diziler Array.sort metodu ile küçükten büyüğe sıralandıktan sonra reverse metodu ile de büyükten küçüğe sıralanabilir.

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };

            //Array.Sort(numbers);
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //---------------------------------------

            // BU KISIM DERS İLE ALAKALI DEĞİLDİR.

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };

            ////Array.Sort<int>(numbers, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            ////Delegate methodlar sadece fonksiyon alıyormuş. 
            //Comparison<int> buyuktenKucuge = BuyuktenKucugeKarsilastir;

            //Array.Sort<int>(numbers, buyuktenKucuge);


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //---------------------------------------


            #endregion

            #region Dizi Metotları

            //---------------------------------------

            //// Bu metot bize verilen değerin dizi içerisindeki konumunu verir.
            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);
            //// Output: 3
            //// "merve" değeri 0'dan saymaya başlayarak 3.indexte yer alır diyor.


            //---------------------------------------

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max());
            ////Output: 96
            //Console.WriteLine("Dizinin en küçük elemanı: " + numbers.Min());
            ////Output: 10

            //---------------------------------------


            #endregion

            #region Kullanıcıdan Değer Alma

            //---------------------------------------

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehrini Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //---------------------------------------

            //int[] numbers = { 10, 20, 30, 40, 50 };

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            //---------------------------------------

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("------------");

            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            //---------------------------------------
            //---------------------------------------

            #endregion


            Console.Read();
        }

        public static int BuyuktenKucugeKarsilastir(int i1, int i2)
        {
            return i2.CompareTo(i1);
        }

    }
}
