using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            ////Console output

            ////WriteLine metodu'nun imleci bir alt satıra taşıdığına dikkat!
            //Console.WriteLine("Merhaba Dünya!");
            //Console.Write("Selam");

            ////Bir boşluk için kullanılmıştır.
            //Console.WriteLine();

            ////Write metodundan sonra alt satıra geçmediği için 'Selam' içeriği 
            ////"Merhaba Dünya!" içeriğinden sonra yazılmıştır.
            //Console.Write("Merhaba Dünya!");
            //Console.WriteLine("Selam");

            ////Bir boşluk için kullanılmıştır.
            //Console.WriteLine();


            ////Konsol üzerinde kodsal tasarım
            //Console.WriteLine("**** Yemek Kategorileri ****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("**** Yemek Kategorileri ****");

            #endregion

            Console.WriteLine();

            #region String Değişkenler
            //string variable

            //string 
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Mustafa Cengiz";
            //Console.WriteLine(name);

            //İsimlendirme yaparken arada boşluk bırakılmaz.
            //Değişken isimlendirmede camelCase kullanılır.
            //Değişken ismi açıklayıcı olmalı. Sonradan okunduğunda veya başkası okunduğunda 
            //değişkenin isminden anlamını çıkarabilmeli.

            //Yazılımda yazım tipleri - Programming case style

            //1-Lower Camel Case(camelCase)
            //ilk harf küçük sonraki kelimelerin harfleri büyük olacak şekilde yazılır.
            //örnek - senMuhtesemBirDetaysin

            //2-Upper Camel Case(PascalCase)
            //bütün kelimelerin ilk harfleri büyük yazılır.
            //örnek - SenMuhtesemBirDetaysin

            //3-SnakeCase
            //bütün kelimeler küçük harf ile yazılırken, kelimeler altçizgi(_) ile ayrılır.
            //örnek - sen_muhtesem_bir_detaysin

            //4-KebabCase
            //bütün kelimeler küçük harf ile yazılırken, kelimeler kısaçizgi(-) ile ayrılır.
            //örnek - sen-muhtesem-bir-detaysın

            //5-Screaming Snake Case
            //SnakeCase'in aynısı sadece hepsi büyük harf
            //örnek - SEN_MUHTESEM_BIR_DETAYSIN

            //6-Title Case
            //Her kelime büyük harf ile başlar. Her kelime bir boşluk ile ayrılır. 
            //Adı üzerinde genelde klasör, proje ve başlık isimlendirilirken kullanılır
            //örnek - Sen Muhtesem Bir Detaysin

            //7-FlatCase
            //Tüm harfler, küçük harf yazılır. 
            //Boşluk ve özel karakter kısıtlamalarının olduğu yerlerde, domain adı veya
            //sistem tanımlayıcısı olarak kullanılır.
            //örnek - username
            //örnek2- apikey

            //ReadMe üzerindeki siteye giderek daha fazlası öğrenilebilir.



            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Kocaeli";
            ////Console.WriteLine(customerName);

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------------------");



            #endregion

            Console.WriteLine();

            #region Int Değişkenler
            //int değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();           
            Console.WriteLine("----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("----Kola: " + cokePrice + " TL");
            Console.WriteLine("----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("----Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            int totalPrice = totalHamburgerPrice + totalCokePrice 
                + totalWaterPrice + totalFriesPrice
                + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("----------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");
            Console.WriteLine("----------------------");
            #endregion


            Console.Read();
        }
    }
}
