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
            #region Metodlar 2'ye ayrılır: Void Metodlar:
            //Void- Geriye değer döndürmeyen metodlardır
            //Customer--> Listele, Ekle, Sil, Güncelle

            //bir  örnek private void metod tanımlayalım:
            //void CustomerList()
            //{
            //    Console.WriteLine("Ayşe Çelik");
            //    Console.WriteLine("Erkan Yılmaz");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            ////metodu çağıralım:
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void sum() 
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();
            #endregion

            #region Geriye değer döndürmeyen string parametreli metodlar:
            //void WriteMethod(string customerName) 
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Hakan Yılmaz");


            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name +" "+ surname);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Zeynep", "Akın");

            #endregion

            #region Geriye Değer döndürmeyen int parametreli metodlar:
            //void Sum(int num1, int num2, int num3) 
            //{
            //    int result= num1 + num2+num3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);



            #endregion

            #region Geriye değer döndüren metodlar: bir değişken türüyle tanımlanırlar.
            //string CustomerNmae () 
            //{
            //    return "Buse Yılmaz";
            //}
            //CustomerNmae();

            //string StudentCard()
            //{
            //    string name = "Can";
            //    string surname = "Altuğ";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye değer döndüren  string Parametreli metodlar.

            //string CountryCard(string countryNmae, string countryCapital, string flagColor) 
            //{
            //    string cardInfo = "Ülke: " + countryNmae + " Başkent: " + countryCapital + " Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y= Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz:");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Italya", "Roma", "Beyaz-Kırmızı-Yeşil"));
            #endregion

            #region Geriye değer döndüren  int Parametreli metodlar.
            //int Sum(int x, int y) 
            //{
            //    int result = x + y;
            //    return result;
            //}

            //Console.WriteLine(Sum(28, 34));
            //Console.WriteLine(Sum(88, 74));
            //Console.WriteLine(Sum(82, 17));
            //Console.WriteLine(Sum(27, 58));

            #endregion

            #region Örnek Uygulama:
            string ExamResult(string student, int exs1, int exs2, int exs3)
            {
                int result = (exs1 + exs2 + exs3) / 3;
                if(result>=50)
                {
                    return student+"  geçti  Ortalaması: "+result;
                }
                else
                {
                    return student+"  kaldı  Ortalaması: "+result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            Console.WriteLine(ExamResult("Merve", 80, 20, 15));

            #endregion
            Console.Read();
        }
    }
}
