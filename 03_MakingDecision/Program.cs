using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Karar yapıları
            // Değişkenlerden sonra en önemli konulardan biri

            #region If

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //// = Tek eşittir, atama operatorü
            //// == iki eşittir, eşitliği kontrol eden operatordür
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //if (password.Equals("abcd", StringComparison.InvariantCultureIgnoreCase))
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            ///*
            // : - Colon
            // / - Slash
            // $ - Dollar
            // % - Percent
            // < - Less than
            // > - Greater than
            // ? - Question Mark
            // * - Asterisk
            // ; - Semicolon
            // # - Number Sign
            // , - Comma
            // _ - Underscore
            //"" - Quotation Mark
            //() - Parentheses
            //'' - Apostrophe
            // & - Ampersand
            // . - Period
            //{} - Brace
            // ! - Exclamation
            //[] - Square Bracket
            // */

            //// && ve operatörü gelen yenilik sonrasında tek & olarak kullanılsa da
            //// aynı amaca hizmet ediyor.
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı.");
            //}
            //else {
            //    Console.WriteLine("hatalı bilgi.");
            //}

            //int number;

            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı.");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);

            //if (average > 0 && average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "balıkesir" | city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}


            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz.");
            //}

            #endregion

            #region Mod İşlemleri
            // Bu arkadaş bölüm isleminde kalan sayıyı verir.


            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1.Sayının 2.sayıya bölümünden kalan: " + result);


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}

            #endregion

            #region Char değişkenler ile karar yapıları


            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'f' || team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if (team == 'b' || team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            //if (team == 'g' || team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}           


            #endregion

            #region Örnek Proje Uygulaması


            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menüyü seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Ana Yemekler --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Kızartma tabağı");
            //    Console.WriteLine("3-Fasulye pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan musakka");
            //    Console.WriteLine("-------------- Ana Yemekler --------------");
            //    Console.WriteLine();
            //}  

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Çorbalar --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek çorbası");
            //    Console.WriteLine("2-Ezogelin çorbası");                
            //    Console.WriteLine("-------------- Çorbalar --------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Pizzalar --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz pizza");
            //    Console.WriteLine("2-Margaritha");                
            //    Console.WriteLine("3-Tavuklu pizza");                
            //    Console.WriteLine("-------------- Pizzalar --------------");
            //    Console.WriteLine();
            //} 

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- İçecekler --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");                
            //    Console.WriteLine("3-Su");                
            //    Console.WriteLine("-------------- İçecekler --------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Tatlılar --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("-------------- Tatlılar --------------");
            //    Console.WriteLine();
            //}

            #endregion


            #region Switch-Case 

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı veri girişi"); break;
            //}


            #endregion


            #region Switch Case Hesap Makinesi

            //int number1, number2, result;

            //char symbol;
            //Console.Write("Lütfen yapılacak işlemi seçiniz(+,-,*,/): ");
            //symbol = char.Parse(Console.ReadLine());

            //Console.Write("1.Sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            
            

            //switch (symbol)
            //{
            //    case '+': 
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        if (number2 == 0) {
            //            Console.WriteLine("Bölen sıfır(0) olamaz!!!");
            //            break;
            //        }
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //}

            #endregion





            Console.Read();
        }
    }
}
