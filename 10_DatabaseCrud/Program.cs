using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // CRUD ---> Create, Read, Update, Delete
            //           Oluştur, Oku, Güncelle, Sil

            Console.WriteLine("***** Menü Sipariş İşlemi Paneli *****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");

            #region Kategori ekleme işlemi



            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();


            ////string connectionString = "Data Source=;initial catalog=;integrated security=true";
            //string connectionString = "Data Source=DESKTOP-HQRJD4Q\\MSSQLSERVER01;initial catalog=EgitimKampiDB01;integrated security=true";
            //// Veri Sunucusuna bağlantı oluşturuldu
            //SqlConnection sqlConnection = new SqlConnection(connectionString);
            //// SQL Sorgusu hazırlandı
            //string addNewCategorySqlCommandString = "insert into TblCategory (CategoryName) values (@p1)";
            //// Sql Sorgusu komut haline getirildi
            //SqlCommand addNewCategorySqlCommand = new SqlCommand(addNewCategorySqlCommandString, sqlConnection);
            //// Sql Sorgusunda kullanılan parametre değeri kullanıcıdan alınan categoryName değişkeni ile eşitlendi.
            //addNewCategorySqlCommand.Parameters.AddWithValue("@p1", categoryName);
            //// Sql bağlantısı açıldı.
            //sqlConnection.Open();
            //// Sql sorgusu işlendi.
            //addNewCategorySqlCommand.ExecuteNonQuery();
            //// Sql bağlantısı kapatıldı.
            //sqlConnection.Close();

            //Console.WriteLine("Kategori başarı ile eklendi!");





            #endregion

            #region Ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HQRJD4Q\\MSSQLSERVER01;initial catalog=EgitimKampiDB01;integrated security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@ProductName,@ProductPrice,@ProductStatus)",connection);
            //command.Parameters.AddWithValue("@ProductName", productName);
            //command.Parameters.AddWithValue("@ProductPrice",productPrice);
            //command.Parameters.AddWithValue("@ProductStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün eklemesi başarılı!");




            #endregion

            #region Ürün listeleme işlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HQRJD4Q\\MSSQLSERVER01;initial catalog=EgitimKampiDB01;integrated security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün silme işlemi

            //Console.Write("Silinecek Ürün id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HQRJD4Q\\MSSQLSERVER01;initial catalog=EgitimKampiDB01;integrated security=true;");
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.Add("@productId", productId);
            //connection.Open();
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı!");

            #endregion

            #region Ürün güncelleme işlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek ürün fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HQRJD4Q\\MSSQLSERVER01;initial catalog=EgitimKampiDB01;integrated security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productId" , productId);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Güncelleme başarılı!");


            #endregion


            Console.Read();
        }
    }
}
