using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Arrays
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            #region Temel Dizi Örnekleri
            // 2,4,6,8
            // beyaz, kırmızı, siyah
            // ıstanbul, adana, izmir
            // degişken türü [] DiziAdı = new değişken türü [elaman sayısı]

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "mavi";
            //colors[2] = "beyaz";
            //colors[3] = "yeşil";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "üsküp";
            //Console.WriteLine(cities[5]);

            //int[] numbers= new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elamanları Listeleme
            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Beyaz", "Mürdüm", "Yeşil", "Siyah" };
            // for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for (int i = 0; i<numbers.Length; i++)
            //{
            //    if (numbers[i]%3 == 0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] semnols = { 'a', 'B', '#', 'c', '*', '/' };
            //for (int i = 0; i < semnols.Length; i++)
            //{
            //    Console.WriteLine(semnols[i]);
            //}

            //int[] myarray = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //int maxNumber = myarray[0];
            //for (int i = 1; i < myarray.Length; i++) 
            //{
            //    if (myarray[i] > maxNumber) 
            //    { 
            //        maxNumber = myarray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] person = { "fatma", "aziz", "ahmet", "elif" };
            //Console.WriteLine(person.Length);

            //int[] myarray = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //Array.Sort(myarray);
            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    Console.WriteLine(myarray[i]);
            //}

            //int[] myarray = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //Array.Reverse(myarray);
            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    Console.WriteLine(myarray[i]);
            //}


            #endregion

            #region Dizi Metotları
            //string[] customers = { "ali", "buse", "gülçiçek", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //Console.WriteLine("Dizinin en büyük elamanı: " + numbers.Max() + " Dizinin en küçük elamanı: "+ numbers.Min());
            #endregion

            #region Kullanıcıdan deger alma:
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($" Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------");

            //for (int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int [] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers= { 21, 42, 33, 54, 55, 66,897, 748, 19,220 };

            //Console.WriteLine("Çift sayılar: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
               
            //}

            //Console.WriteLine("-------------------");
            //Console.WriteLine("Tek sayılar: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            #endregion

            Console.Read();
        }
    }
}
