using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler

            //For(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            // Döngülerde genelde matematik serilerden gelen i,j,k ifadeleri kullanılır

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 3; i <= 50; i += 3) { 
            //Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazdırmak istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{ 
            //  Console.WriteLine("Yaşasın Cumhuriyet");
            //}




            #endregion


            #region For Döngüsü ile karar yapıları

            //5'e tam bölünen sayıları listeler
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //1'den 10 dahil olarak toplayıp sonucu verir
            // totalValue += i >>> totalValue = totalValue + i
            //int totalValue = 0;

            //for (int i = 1; i<=10; i++) {
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue); 


            //20'e kadar olan sayılardan ikiye tam bölünenlerin toplamını verir.
            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    { 
            //        totalValue += i;
            //        Console.WriteLine(i);                
            //    }
            //}

            //Console.WriteLine("--------------");
            //Console.WriteLine(totalValue);


            //50'e kadar olan sayıların 7'e tam bölünen kaç sayı olduğunu belirler ve yazdırır.
            //int count = 0;
            //for (int i = 1; i < 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++; 
            //    }
            //}

            //Console.WriteLine(count);


            //her saat ikiye katlanan bakteri
            //0.saat 1 bakteri
            //1.saat 2 bakteri
            //2.saat 4 bakteri
            //3.saat 8 bakteri
            //4.saat 16 bakteri
            //5.saat 32 bakteri
            //..

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".saat sonunda: " + $"{bacterium:N3}");
            //}

            #endregion

            #region While Döngüsü

            //While döngüsü şart sağlandığı sürece çalışır
            //yani şart true verdiği sürece.
            //While(Şart)
            //{
            //işlemler
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}


            //10'a kadar olan pozitif sayıların 3'e tam bölünebilen sayıları yazdırır.
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //10'a kadar olan pozitif sayıların toplamı
            //int i = 1;
            //int sum = 0;
            //while (i <= 10) {
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Örnek sınav sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //Console.WriteLine("Sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, hundreds, thousands;
            //int sum;

            //ones = number % 10;
            //hundreds = (number % 100) / 10;
            //thousands = number / 100;

            //Console.WriteLine(thousands + "-" + hundreds + "-" + ones);
            //sum = thousands + hundreds + ones;
            //Console.WriteLine("Toplam: " + sum);

            #endregion



            Console.Read();
        }
    }
}
