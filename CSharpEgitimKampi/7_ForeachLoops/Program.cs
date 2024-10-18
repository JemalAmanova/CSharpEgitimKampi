using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü:
            //Foreach 4 tane parametre alır Foreach(1,2,3,4);
            //1. parametre: Değişken Türü:
            //2. parametre: Değişken Adı:
            //3. parametre: In (içinde):
            //4. parametre: liste, kolleksiyon veya dizi:

            //string[] cities = { "Milano", "Ankara", "Aşkabat", "Taşkent", "Bişkek" };
            //foreach (string x in cities) 
            //{ 
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 19, 22, 39, 74, 57, 66, 97, 88, 90, 101, 118 };
            // foreach (int number in numbers) 
            //{
            //    if (number%2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 19, 22, 39, 74, 57, 66, 97, 88, 90, 101, 118 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);
            #endregion
            #region Listeler:

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,5,7,9
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";
            //foreach (var item in word)
            //{
            //    Console.WriteLine(item);

            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            Console.Write("***** CSharp Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-------------------------");

            //öğr sayısını alma
            Console.WriteLine("Sınıfta kaç öğr var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");

            //ögr isim ve sınav ort  saklayacak diziler
            string[] studetNames = new string[studentCount];
            double[] studentExamAvg=new double[studentCount];

            for(int i=0; i<studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin ismini giriniz:");
                studetNames[i] = Console.ReadLine();
                double totalExamResult = 0;

                //her ögr için 3 sıav notu girişi:

                for(int j=0; j<3; j++)
                {
                    Console.Write($"{studetNames[i]}. Öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz
                }
                studentExamAvg[i] = totalExamResult/3;
            }

            //öğrlerin ortalaması:
            for(int i=0; i<studentCount; i++)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"{studetNames[i]}. Öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğr Geçip kalma Durumları:
                if (studentExamAvg[i] >=50) 
                {
                    Console.WriteLine($"{studetNames[i]} dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studetNames[i]} dersten kaldı");
                }
                Console.WriteLine("-------------------------");
            }

            Console.ReadLine();
            #endregion
        }
    }
}
