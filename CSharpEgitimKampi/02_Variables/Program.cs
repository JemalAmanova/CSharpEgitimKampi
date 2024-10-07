using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler:
            //Console.WriteLine("**** Fiyat Listesi ****");

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("--- Elma Birim Fiyatı:" + applePrice + "TL");
            //Console.WriteLine("--- Portakal Birim Fiyatı:" + orangePrice + "TL");
            //Console.WriteLine("--- Çilek Birim Fiyatı:" + strawberryPrice + "TL");
            //Console.WriteLine("--- Patates Birim Fiyatı:" +potatoPrice + "TL");
            //Console.WriteLine("--- Domates Birim Fiyatı:" +tomatoPrice + "TL");
            //Console.WriteLine();


            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice= orangeGram * orangePrice;
            //double strawberryTotalPrice= strawberryGram * strawberryPrice;
            //double potatoTotalPrice= potatoGram * potatoPrice;
            //double tomatoTotalPrice= tomatoGram * tomatoPrice;



            //Console.WriteLine("Alınan Ürün: Elma" + "- Birim Fiyatı: " + applePrice + "- Gramaj: "+ appleGram + "- Toplam Tutar: " +appleTotalPrice +"TL");
            //Console.WriteLine("Alınan Ürün: Portakal" + "- Birim Fiyatı: " + orangePrice + "- Gramaj: " + orangeGram + "- Toplam Tutar: " + orangeTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Çilek" + "- Birim Fiyatı: " + strawberryPrice + "- Gramaj: " + strawberryGram + "- Toplam Tutar: " + strawberryTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Patates" + "- Birim Fiyatı: " + potatoPrice + "- Gramaj: " + potatoGram + "- Toplam Tutar: " + potatoTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Domates" + "- Birim Fiyatı: " + tomatoPrice + "- Gramaj: " + tomatoGram + "- Toplam Tutar: " + tomatoTotalPrice + "TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine("Toplam Tutar: " + shoppingTotalPrice + "Tl");

            #endregion

            #region Char Değişkenler
            //char sembol = 'a';
            //Console.WriteLine(sembol);
            #endregion

            #region Klavyeden Veri Girişleri: String
            //Console.WriteLine("*** CSharp Havayollary Yolcu Bilgileri ***");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Ilçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();


            //Console.WriteLine("--------------------------");

            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname + " " + passengerDistrict+ " " + passengerCity+ " " + passengerIdentityNumber);
            #endregion

            #region Klavyeden Int girişi ve Dönüşümler:

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;
            //Console.Write("Kaç Ayakkabı Aldınız?: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Kaç PC Aldınız: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Kaç Koltuk Aldınız: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Kaç TV Aldınız?: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoeCount*shoePrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;

            //Console.WriteLine();

            //Console.WriteLine("Toplam Tutar:" + totalPrice);


            #endregion

            #region Klavyeden ondalıklı sayı işlemleri:
            //double exam1, exam2, exam3, result;

            //Console.WriteLine("1. sınav notu: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sınav notunu: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("3. sınav notu:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;



            //Console.WriteLine("Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri:
            char gender;

            Console.Write("Cinsiyet Giriniz: ");
            gender=char.Parse(Console.ReadLine());

            Console.WriteLine("Cinsiyetiniz: " +gender);

            #endregion





            Console.Read();
        }
    }
}
