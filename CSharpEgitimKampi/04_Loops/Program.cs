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
            //For(x,y,z)
            //X-başlangıç değer
            //y-bitiş değer
            //z-artış ve azalış değeri

            //for (int i = 1; i <=5; i++)
            //{
            //    Console.WriteLine("c# eğitim kampı");
            //}

            //for (int i = 1; i <=20; i++) 
            //{ 
            //    Console.WriteLine(i);
            //}

            //for(int i = 3; i <=50; i+=3) 
            //{ 
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen Bitiş Değeri Giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion

            #region For Döngüsü ile Karar Yapıları: 

            //for (int i = 1; i <=100; i++) 
            //{
            //    if(i%5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 1; i <=10; i++) 
            //{ 
            //    totalValue+=i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 1; i <20; i++) 
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 0; i <=50; i++) 
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //Bir Bakteri her saatin sonunda kendini 2 ye bölerek çoğaltır.
            //bu bakteriden 1 tane var 24 saatin sonunda kaç bakteri olacak?

            //int bacterium = 1;
            //for (int i = 1; i <=24; i++) 
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saatin sonunda: " + bacterium);
            //}
            #endregion
            #region While Döngüsü:
            //While(şart)
            //{ 
            // İşlemler
            //}

            //int i = 1;
            //while(i >=10) 
            //{
            //    Console.WriteLine("Mehaba Döngü");
            //    i++;
            //}

            //int i = 1;
            //while (i>=10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //   i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i >= 10) 
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
           
            #endregion
            #region Örnek Sınav Sorusu:
            // Klavyeden Girilen 3 basamaklı sayının, basamak sayılarının toplamı:

            Console.Write("3basamaklı sayı girin: ");
            int number=int.Parse(Console.ReadLine());

            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100)/10;
            hundreds = number / 100;
            Console.WriteLine(ones +"  " + tens + "  " + hundreds);
            sum = ones + tens + hundreds;
            Console.WriteLine(sum);

            Console.Read();

            #endregion
        }
    }
}
