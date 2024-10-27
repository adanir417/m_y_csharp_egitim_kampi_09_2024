using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

      //      /*
             
      //SQL Server data type - .NET data type
      //       bit	            bool	
      //       tinyint	        byte	
      //       smallint	        short	
      //       int	            int	
      //       real	            float	
      //       bigint	            long	
      //       float	            double	
      //       nchar(n)	        string	
      //       nvarchar(n)	    string	
      //       binary(n)	        byte[]	
      //       varbinary(n)	    byte[]	
      //       nvarchar(max)	    string	
      //       varbinary(max)	    byte[]	
      //       uniqueidentifier	Guid	
      //       char(n)	        string	
      //       varchar(n)	        string	
      //       varchar(max)	    string	
      //       date	            DateOnly	.NET 6 and later versions
      //       time	            TimeOnly	.NET 6 and later versions
      //       numeric	        decimal	
      //       decimal	        decimal	
      //       money	            decimal	
      //       smallmoney	        decimal	
      //       smalldatetime	    DateTime	
      //       datetime	        DateTime	
      //       datetime2	        DateTime

      //       */

      //      /*
             
      //      MSSQL bilgileri ve üzerinde yapılan değişiklikler.

      //      * Microsoft SQL Server Management Studio açıldı.
      //      * SQL server'a bağlantı sağlanınca solda object explorer üzerinden Databases'e sağ tuş tıklayarak new database seçeneği seçildi.
      //      * EgitimKampiDB adında bir veri tabanı oluşturuldu. Sadece ad girildi. Başka ayar yapılmadı.Kullanılan adın Türkçe karakter içermediğine dikkat!
      //      * Databases'e sağ tıklayıp refresh yapılınca veri tabanı alfabetik sıraya göre dizildiğinde birden çok veri tabanı içinde konumu ona göre değişir.
      //      * Oluşturduğumuz veri tabanının yanındaki ufak artıya basınca açılan kısımlardan Tables'a sağ tıklayarak New >> Table... seçilir
      //      * Burada Kategori tablosu oluşturuyoruz fakat kaydetmeden isim sormadığı için endişeye gerek yok.
      //      * Tablolarda ilk kısım id kısmı IDENTITY(Kimlik)'den gelir. 
            
      //      Column Name            Data Type          Allow Nulls
      //      CategoryId             int                 FALSE(NO)
      //      CategoryName           nvarchar(30)        TRUE(YES)


      //       * CategoryId üzerine gelip sağ tıkladıktan sonra Set Primary Key seçeneği seçilerek bu alan birincil anahtar olarak tanımlanır.
      //       * Primary key seçiminden sonra CategoryId başında sarı bir anahtar belirdiğine dikkat edelim.
      //       * Bu değişiklikler tamamlandıktan sonra CTRL + S ile tablo kaydedilir ve isim sorduğunda
      //       * TblCategory olarak kaydedilir.
      //       * Eğer olurda bir şekilde değişiklikleri önlemek adına bir uyarı gelirse
      //       * Tools >> Options... >> Designers >> Table and Database Designers >> Untick(İşaretli ise kaldırın) Prevent saving changes that require table re-creation
      //       * Bu seçili olmadığında artık tablolar değişikliğe göre yeniden oluşturulabilecek. Bu oluşturma aşamasında verilerin güvenliği adına işlem öncesi yedekleme alınmalı.
      //       * Daha sonra oluşturulan dbo.TblCategory'e sağ tuş tıklayarak Edit Top 200 Rows seçilir. Bu ilk 200 satırın düzenlenmesi demek.
             
             

      //       CategoryId                CategoryName
      //       1                         Ana Yemekler
      //       2                         Tatlılar
      //       3                         Salatalar
      //       4                         Çorbalar

      //      //------------------ Otomatik arttırma etkinleştirme sonrası sadece CategoryName kısmına giriş yapıyoruz

      //       5                         Mezeler
      //       6                         Pizzalar
      //       7                         Hamburger
      //       8                         Atıştırmalık
      //       9                         Çocuk Menüleri
      //       10                        Öğrenci Menüsü



      //       * Eğer CategoryId değeri yani Primary Key olarak atanan değer otomatik artsın isteniyorsa
      //       * Tablo düzenleme ekranı kapatıldıysa Tabloya sağ tuş tıklanarak Design seçilir. 
      //       * CategoryId satırına tıkladıktan sonra Column Properties içerisinde 
      //       * Identity Specification alanı bulunur
      //       * (Is Identity) Default No(Varsayılan olarak kapalı) olarak gelirken. Yes konumuna aldığımızda
      //       * iki seçenek daha etkin hale gelir.
      //       * Identity Increment   1
      //       * Identity Seed        1
      //       * 
      //       * Identity Increment artış değerini ifade eder 1 olarak işaretlendiğinden bir bir arttırır yani bir değer 20 ise 21 sonra 22 olarak gider
      //       * Identity Seed ise konum belirtir. Bir numaradan başlayarak arttır ya da iki yüz(200) girilirse iki yüz(200)'den itibaren Identity increment değerinde arttırır.
      //       * Eğer daha önce sıralı olarak girilen değerler varsa onlar bozulmadan kendisi kaldığı yerden devam edecek.
      //       * Örneğimiz için 4 Çorbalardan sonra ID'i otomatik 5 olarak alacaktır.
      //       * Edit kısmına geri dönüp boş alana sağ tuş tıklayıp Execute SQL(CTRL + R) seçeneğini seçtiğimizde
      //       * tablo kısımları grileşecek. Çünkü artık CategoryId kısmı yönetimini SQL'e devrettik.
      //       * Eğer tabloda CategoryId kısımları grileşmediyse Edit kısmında kaydetmeyi unutmuş olabilirsiniz.
      //       * 
      //       * 
      //       * İkinci olarak Product Tablosu oluşturuyoruz
      //       * Tables'a sağ tuş tıklayarak New >> Table... 
      //       * Kolon adları ProductId, ProductName, ProductPrice, ProductStatus
      //       * ProductId int not null
      //       * ProductName varchar(50) nullable
      //       * ProductPrice decimal(18,2) nullable
      //       * ProductStatus bit nullable
      //       * 
      //       * ProductId'i Primary key olarak set etmeyi ve otomatik arttırmayı etkinleştirmeyi unutmayalım!
      //       * Tablo adı TblProduct olarak kaydedilir.
      //       * Edit Top 200 Rows ile 10 adet veri giriyoruz.
      //       * 
      //       * 
            
      //      ProductId	ProductName	                ProductPrice	    ProductStatus
      //      1	        Mercimek Çorbası	        60.00	            1
      //      2	        Yayla Çorbası	            65.00	            1
      //      3	        Tavuk Suyu Çorbası	        80.00	            1
      //      4	        Spagetti	                50.00	            1
      //      5	        Steak Burger	            100.00	            1
      //      6	        Cheese Burger	            120.00	            1
      //      7	        Sütlaç	                    40.00	            0
      //      8	        Profiterol	                35.00	            1
      //      9	        Kori Soslu Tavuk	        90.00	            1
      //      10	        Kızarmış Mantı	            85.00	            1



      //      *
      //      * Son olarak Order tablosunu oluşturuyoruz
      //      * Databases'e sağ tuş New >> Table...
      //      * Kolon adları OrderId, OrderCustomer, ProductCount, ProductUnitPrice, TotalPrice
      //      * 
      //      * OrderId int not null
      //      * OrderCustomer varchar(50) nullable
      //      * ProductCount tinyint nullable
      //      * ProductUnitPrice decimal(18,2) nullable
      //      * TotalPrice decimal(18,2) nullable
      //      *
      //      *
      //      * tinyint 0 - 255 arasında değer alan bir yapıymış. 
      //      * Yani Mahalleye ikram etmeyecekse kimse 255 üzerinde bir sipariş vermez.
      //      * 
      //      * Tüm bunlardan sonra otomatik arttırma ve primary key atamalarını unutmayalım.
      //      * Tablo adı TblOrder olarak kaydediyoruz.
      //      * 

      //       */

      //      /*
      //       Kısaca en çok kullanacağımız veri tipi hakkında bilgiler
      //      bit ---> bool true - false
      //      char(10) ---> sabit uzunluktaki karakterler için kullanılır. Örnek T.C. Kimlik numarası herkes için 11 karakterdir. Telefon numaraları sabittir.
      //      date, datetime ---> tarih zaman 
      //      decimal(18, 0) ---> Ondalıklı sayıları tutar. Virgünden sonraki sıfır(0) ifadesi kaç basamak alacağını bildirir. 
      //      int ---> Tam sayıları tutar.
      //      varchar(50) ---> Veri uzunluğu sabit olmayan değerler için kullanılır. Mesela isimler çünkü isimlerin uzunlukları kişi ismine göre değişiyor.
      //      nvarchar(50) ---> başa gelen n, uluslar arası karakterlerin kapsamnını ifade eder. Latin alfabesi dışındaki ifadeler için n ifadeli olanlar seçilmeli.
      //      *Burada dikkat edilecek nokta saklama boyutları değişiyor. nvarchar, varchar'a göre 2 kat fazla yer kaplıyor.
            
      //      Parantez içindeki değerler ile alacağı karakter uzunluğunu değiştirebiliyoruz
      //      nvarchar(50) ---> 50 karakter uzunluğuna kadar
      //      nvarchar(30) ---> 30 karakter uzunluğuna kadar
      //       */


      //      /*
             
      //      SQL Sorgu --- SQL Query

      //      -- bu arkadaş yorum satırı yapar tıpkı 

      //      // C# için kullanılan bu ifade gibi.

      //      Select Insert Update Delete

      //      Select * From TblCategory 
            
      //      // bu sorgu TblCategory tablosundan Ne varsa(*) seçip getir demek.

      //      Select * From TblProduct

      //      // bu sorgu TblProduct tablosundan Ne varsa(*) seçip getir demek.

      //      Select ProductName, ProductPrice from TblProduct

      //      // bu sorgu ne varsa değil sadece belirtilen değerleri tablodan seç getir demek.
      //      // ProductName ve Product Price'ı TblProduct tablosundan seç ve getir demek.

      //      Select * From TblProduct Where ProductName='Sütlaç'

      //      // Burada product adı Sütlaç olan ne varsa(*) TblProduct Tablosundan getir demek.
            
      //      Select * From TblProduct Where ProductPrice<80

      //      // Burada ProductPrice'ı 80'den düşük olanların hepsini getir dedik.

      //      Select * From TblProduct Where ProductPrice<80 And ProductStatus=1

      //      // Burada ProductPrice'ı 80'den düşük olanları VE ProductStatus'ü 1 olanların hepsini getir dedik.

            
             
      //       */


      //      // Ado.net

      //      Console.OutputEncoding = System.Text.Encoding.UTF8;

      //      Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
      //      Console.WriteLine();
      //      Console.WriteLine();

      //      string tableNumber;

      //      Console.WriteLine("----------------------------------------");
      //      Console.WriteLine("1-Kategoriler");
      //      Console.WriteLine("2-Ürünler");
      //      Console.WriteLine("3-Siparişler");
      //      Console.WriteLine("4-Çıkış yap");
      //      Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
      //      tableNumber = Console.ReadLine();
      //      Console.WriteLine("----------------------------------------");

      //      // Connection String
      //      // Data Source=DESKTOP-HQRJD4Q\MSSQLSERVER01;initial Catalog=EgitimKampiDB01;integrated security=true;
      //      SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HQRJD4Q\\MSSQLSERVER01;initial Catalog=EgitimKampiDB01;integrated security=true;");
            
      //      //SQL Bağlantısı açıldı. Bu süreç içerisinde veri tabanı ile iletişim halinde olacak.
      //      connection.Open();

      //      // new SqlCommand(); yapılandırıcısı içine sql sorgusu alabiliyor
      //      // yani burada basitçe sql sorgusu oluşturuyoruz
      //      // ve tabi bunu belirtirken bağlanılan sunucunun hangi veri tabanından veri alacağını söylememiz gerekiyor
      //      // new SqlCommand("SORGU", BAĞLANTI);
      //      // new SqlCommand("Select * From TblCategory", connection);
      //      // SqlCommand getAllProductCommand = new SqlCommand("Select * From TblProduct", connection);
      //      // SqlCommand getAllOrderCommand = new SqlCommand("Select * From TblOrder", connection);
      //      // gibi

      //      SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
      //      SqlDataAdapter adapter = new SqlDataAdapter(command);

      //      // Verileri geçici belleğe(RAM) alınmasını sağlar.
      //      DataTable dataTable = new DataTable();

      //      // Bu arkadaş SqlDataAdapter türünde oluşturduğumuz adapter ile komut sonrası dönen verileri parametre olarak verdiğimiz DataTable'a atıyor.
      //      adapter.Fill(dataTable);

      //      // Burada da sql ile açık bağlantıyı kapatıyoruz ki sonraki sorgularda açık kalan kullanım için sorun çıkmasın.
      //      connection.Close();

      //      //foreach (var item in dataTable.Rows) {
      //      //    Console.WriteLine(item);
      //      //}

      //      // Data tablosu içindeki satırları dolaşır
      //      foreach (DataRow row in dataTable.Rows) {
      //          // Dolaşılan satırların içindeki her bir sütuna karşılık gelen değeri alır
      //          foreach (var item in row.ItemArray) {
      //              // Ve o değeri burada yazdırır.
      //              Console.Write(item.ToString() + " ");
      //          }
      //              Console.WriteLine();
      //      }
      //      /*
            
      //       // birinci sql satırını aldı
      //       // ikinci foreach ile sql satırındaki sütunları dolaşmaya başladı
      //       // bir sonraki satıra geçmeden ilk foreach döngüsünde görsel olarak bir satır alta inildi.
      //       // ikinci sql satırını aldı
      //       // ... 

             
      //       */

            Console.Read();
        }
    }
}
