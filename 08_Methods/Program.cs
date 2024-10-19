using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //// () 
            //// Bir yapının metot olduğunu anlamak için parantez açık kapanmalı

            //// Metot tipleri - Metotlar özünde ikiye ayrılır.

            //// Geriye değer döndürmeyen metotlar
            //// Customer ---> Listeleme, ekle, sil, güncelle
            //// void

            //void CustomerList() {
            //    Console.WriteLine("Ali YILDIZ");
            //    Console.WriteLine("Ayşe YILDIZ");
            //    Console.WriteLine("Hakan ÖZTÜRK");
            //    Console.WriteLine("Merve ÇINAR");              
            //}


            //CustomerList(); 
            //// Metot çağrıldı.
            //// Fareyi metot üzerinde tutunca mor metot kutusu simgesi altında
            //// bir kilit işareti var. Bu işaret metotun private olduğunu belirtiyor.
            //// Access Modifier

            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum() {
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();           


            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar

            // Ctrl + shift + space 
            /*
            
            Parameter info	Ctrl+Shift+Spacebar [Text Editor, Workflow Designer]

            or Ctrl+K, Ctrl+P [Workflow Designer]

            or Ctrl+K, P [Workflow Designer]	Edit.ParameterInfo

             */

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);                
            //}

            //WriteMethod("Mehmet YILDIRIM");


            //// Parametre değişken isimleri camelCase ile yazılır.
            //void CustomerCard(string name, string surName) {
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Mehmet", "YILDIZ");
            //CustomerCard("Ayşegül", "KAYA");


            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);



            #endregion

            #region Geriye değer döndüren metotlar

            //string CustomerName() {
            //    return "Buse YILDIZ";
            //}

            //CustomerName();

            //string StudentCard() {
            //    string name = "Ali";
            //    string surname = "KAYA";

            //    return name + " " + surname;
            //    //mini denemeler
            //    //return $"{name} {surname}";
            //}

            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName, string capital, string flagColor) { 
            //string cardInfo = "Ülke: "  + countryName + " - Başkent: " + capital + " - Bayrak Rengi:  " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));


            #endregion

            #region Geriye değer döndüren int parametreli metotlar

            //int Sum(int number1, int number2) { 
            //int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44,36));
            //Console.WriteLine(Sum(14,20));


            #endregion

            #region Örnek uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3) {
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student +  " isimli öğrenci sınavı geçti" + " Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student +  " isimli öğrenci sınavı geçemedi" + " Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali",25,41,85));
            //Console.WriteLine(ExamResult("Ayşe",36,88,33));

            #endregion

            Console.Read();
        }
       

      

    }
}
