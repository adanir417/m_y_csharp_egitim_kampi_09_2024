using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu arkadaş konsol çıktısını Unicode destekler hale getiriyor.
            // TL sembolünün gözükmesi için gerekli.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();

            ////Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice.ToString("C2", CultureInfo.CurrentCulture));
            ////Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice.ToString("C2", new CultureInfo("tr-TR")));
            ////Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + "₺");
            ////Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + "₺");
            ////Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + "₺");

            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            ////Console.WriteLine($"Elmanın Toplam Fiyatı:  {appleTotalPrice:F2}₺");
            ////Console.WriteLine($"Portakalın Toplam Fiyatı:  {appleTotalPrice:F2}₺");
            ////Console.WriteLine($"Çileğin Toplam Fiyatı:  {appleTotalPrice:F2}₺");
            ////Console.WriteLine($"Patatesin Toplam Fiyatı:  {appleTotalPrice:F2}₺");
            ////Console.WriteLine($"Domatesin Toplam Fiyatı:  {appleTotalPrice:F2}₺");
            ////Console.WriteLine();

            //Console.WriteLine("Alınan ürün: Elma - " + "Birim Fiyat : " + applePrice + " - Gramaj: " + appleGram 
            //    + " - Toplam Tutar: " + appleTotalPrice); 
            //Console.WriteLine("Alınan ürün: Portakal - " + "Birim Fiyat : " + orangePrice + " - Gramaj: " + orangeGram 
            //    + " - Toplam Tutar: " + orangeTotalPrice); 
            //Console.WriteLine("Alınan ürün: Çilek - " + "Birim Fiyat : " + strawberryPrice + " - Gramaj: " + strawberryGram 
            //    + " - Toplam Tutar: " + strawberryTotalPrice); 
            //Console.WriteLine("Alınan ürün: Patates - " + "Birim Fiyat : " + potatoPrice + " - Gramaj: " + potatoGram 
            //    + " - Toplam Tutar: " + potatoTotalPrice); 
            //Console.WriteLine("Alınan ürün: Domates - " + "Birim Fiyat : " + tomatoPrice + " - Gramaj: " + tomatoGram 
            //    + " - Toplam Tutar: " + tomatoTotalPrice);
            //Console.WriteLine();


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            ////Math.Round(decimal,1);
            ////Math.Round(decimal,2);
            ////Math.Round(decimal,2, MidpointRounding.AwayFromZero);
            ////Math.Round(decimal,2, MidpointRounding.ToZero);
            ////Math.Round(decimal,2, MidpointRounding.ToEven);
            
            ////Before Round
            //Console.WriteLine("Toplam tutar: " + shoppingTotalPrice + "₺");

            //shoppingTotalPrice = Math.Round(shoppingTotalPrice,2, MidpointRounding.AwayFromZero); 

            ////After Round
            //Console.WriteLine("Toplam tutar: " + shoppingTotalPrice + "₺");

            #endregion

            Console.WriteLine();

            #region Char Değişkenler
            //Char değişkenler Karakter türünde değişkenler oluşturur.
            //Char değişkenler tek tırnakla tanımlanırlar.

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion

            Console.WriteLine();

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine().Trim();
            
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine().Trim();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine().Trim();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine().Trim();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine().Trim();

            //Console.Write("Yolcu T.C. Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine().Trim();

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Yolcu T.C. Kimlik No: " + passengerIdentityNumber  + " - Yolcu: " + passengerName + " " + passengerSurname
            //    + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge
            //    );
            




            #endregion

            Console.WriteLine();

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1_000;
            //computerPrice = 20_000;
            //chairPrice = 5_000;
            //tvPrice = 12_000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            
            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoesCount * shoesPrice) + (computerCount * computerPrice) + (chairCount * chairPrice) + (tvCount * tvPrice) ; 

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice.ToString("N3", CultureInfo.CurrentCulture));


            #endregion

            Console.WriteLine();

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız : " + result);



            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());


            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion



            Console.Read();

        }
    }
}
