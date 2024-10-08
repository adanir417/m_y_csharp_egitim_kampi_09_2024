using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            //Console.WriteLine();

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            //Console.WriteLine();

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            //Console.WriteLine();

            #region Dik üçgen

            //char yildiz = '*';
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(yildiz);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            //Console.WriteLine();

            #region Ters Dik üçgen

            //char yildiz = '*';
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(yildiz);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            //Console.WriteLine();

            #region Dik ve Ters dik üçgen beraber

            //char yildiz = '*';

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(yildiz);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(yildiz);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            //Console.WriteLine();

            #region Baklava dilimi

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            //for (int i = n - 1; i >= 1; i--) {
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    { 
            //       Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            //Console.WriteLine();

            #region Piramit

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    //boşluk
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldız
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            //Console.WriteLine();

            #region Ters Piramit

            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    //boşluk
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldız
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            #endregion
            //Console.WriteLine();

            #region Elmas içinde isim denemem

            //char yildiz = '*';
            //char bosluk = ' ';

            //Console.Write("Kalp içine yazdırmak istediğiniz ismi giriniz: ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Genişlik için tek sayı giriniz(15,35,61 vb.): ");
            //int jewelryWidth;
            //bool readed = int.TryParse(Console.ReadLine(),out jewelryWidth);

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //int space = jewelryWidth / 2;
            //int startSpace = space;
            //int endSpace = space;

            //for (int i = 1; i <= jewelryWidth/2+1; i++)
            //{
            //    //Boşluklar
            //    for (int j = startSpace; j >= 0; j--)
            //    { 
            //        Console.Write(bosluk);
            //    }
                
            //    for (int l = 1; l <= 2 * i - 1; l++)
            //    {
            //        Console.Write(yildiz);
            //    }

            //    for (int k = endSpace; k >= 0; k--)
            //    {
            //        Console.Write(bosluk);
            //    }


            //    Console.WriteLine();
            //    space--;
            //    startSpace = space;
            //    endSpace = space;
            //}

            //int lastStarCount = 0;
            //if (name.Length + 4 < jewelryWidth)
            //{
            //    int count = 0;
            //    for (int i = 0; i < 1; i++)
            //    {
            //        for (int j = 1; j <= ((jewelryWidth/2)-(name.Length)/2+1); j++)
            //        {
            //            Console.Write(yildiz);
            //            count++;
                        
            //        }

            //        Console.Write(name);
            //        count += name.Length;
            //        lastStarCount = count;


            //        for (int k = 1; k < jewelryWidth - count+3; k++)
            //        {
            //            Console.Write(yildiz);
            //            lastStarCount++;
            //        }
            //    }
            
            //}

            //Console.WriteLine();
            //lastStarCount-=2;

            //space = 1;
            //startSpace = space;
            //endSpace = space;

            //for (int i = jewelryWidth / 2; i >= 0; i--)
            //{
            //    for (int j = 1; j <= startSpace; j++)
            //    {
            //        Console.Write(bosluk);
            //    }
                
            //    for (int k = lastStarCount; k > 0; k--)
            //    {
            //        Console.Write(yildiz);
                   
            //    }
                

            //    for (int l = 1; l <= endSpace; l++)
            //    {
            //        Console.Write(bosluk);
            //    }

            //    Console.WriteLine();
            //    space++;
            //    startSpace = space;
            //    endSpace = space;
            //    lastStarCount-=2;

            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(); 
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            #endregion

            //Console.WriteLine();

            #region Elmas denemem

            //char yildiz = '*';
            //char bosluk = ' ';

            //Console.Write("Elmas genişliğini giriniz: ");
            //int jewelryWidth = 0;
            //bool readed = int.TryParse(Console.ReadLine(), out jewelryWidth);

            //bool oddCheck = false;

            //if (jewelryWidth % 2 != 0)
            //{
            //    oddCheck = true;
            //}

            //int spaceCount = jewelryWidth / 2;
            //int starCount = 1;
            //int innerStarCount;

            ////odd number - tek sayı
            ////even number -çift sayı

            //if (readed && oddCheck)
            //{
            //    for (int i = 1; i <= (jewelryWidth/2)+1; i++)
            //    {
            //        innerStarCount = starCount;
            //        for (int j = 1; j <= jewelryWidth; j++)
            //        {
            //            if (j <= spaceCount)
            //            {
            //                Console.Write(bosluk);
            //            }
            //            else if (j > spaceCount && innerStarCount > 0)
            //            {
            //                Console.Write(yildiz);
            //                innerStarCount--;
            //            }
            //            else
            //            {
            //                Console.Write(bosluk);
            //            }

            //        }

            //        Console.WriteLine();
            //        starCount += 2;
            //        spaceCount--;
            //    }                
            //    starCount -= 2;
            //    starCount -= 2;               
            //    spaceCount = 1;
            //    for (int i = 1; i <= (jewelryWidth/2); i++)
            //    {
            //        innerStarCount = starCount;
            //        for (int j = 1; j <= jewelryWidth; j++)
            //        {
            //            if (j <= spaceCount)
            //            {
            //                Console.Write(bosluk);
            //            }
            //            else if (j > spaceCount && innerStarCount > 0)
            //            {
            //                Console.Write(yildiz);
            //                innerStarCount--;
            //            }
            //            else
            //            {
            //                Console.Write(bosluk);
            //            }

            //        }

            //        Console.WriteLine();
            //        starCount -= 2;
            //        spaceCount++;
            //    }
            //}

            #endregion

            //Console.WriteLine();

            Console.Read();

        }
    }
}
