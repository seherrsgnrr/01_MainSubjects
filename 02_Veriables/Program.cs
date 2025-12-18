using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);


            //Console.WriteLine("****fiyat listesi****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 10.58;
            //strawberryPrice = 45;
            //potatoPrice = 6.77;
            //tomatoPrice = 8.99;

            //Console.WriteLine("elma birim fiyatı:" + applePrice + "tl");
            //Console.WriteLine("portakal birim fiyatı:" + orangePrice + "tl");
            //Console.WriteLine("çilek birim fiyatı:" + strawberryPrice + "tl");
            //Console.WriteLine("patates birim fiyatı:" + potatoPrice + "tl");
            //Console.WriteLine("domates birim fiyatı:" + tomatoPrice + "tl");

            //Console.WriteLine() ;

            //double appleGram , orangeGram , strawberryGram ,potatoGram , tomatoGram ;

            //appleGram = 1.240;
            //orangeGram = 2.500;
            //strawberryGram = 0.810;
            //potatoGram = 4.890;
            //tomatoGram = 7.850;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;


            //Console.WriteLine("alınan ürün: Elma-" + "birim fiyat:" + applePrice + " -gramaj: " + appleGram + "toplam tutar:" + appleTotalPrice);
            //Console.WriteLine("alınan ürün: portakal-" + "birim fiyat:" + orangePrice + " -gramaj: " + orangeGram + "toplam tutar:" + orangeTotalPrice);
            //Console.WriteLine("alınan ürün: çilek-" + "birim fiyat:" + strawberryPrice + " -gramaj: " + strawberryGram + "toplam tutar:" + strawberryTotalPrice);
            //Console.WriteLine("alınan ürün: patates-" + "birim fiyat:" + potatoPrice + " -gramaj: " + potatoGram + "toplam tutar:" + potatoTotalPrice);
            //Console.WriteLine("alınan ürün: domates-" + "birim fiyat:" + tomatoPrice + " -gramaj: " + tomatoGram + "toplam tutar:" + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("alışveriş toplam tutarı:" + shoppingTotalPrice + "tl");
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol='A';
            //Console.WriteLine(symbol);

            #endregion

            #region klavyeden veri girişleri string değişkenler
            //Console.WriteLine("****CSharp Hava Yolları Yolcu Bilgileri****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentıtyNumber;
            //Console.Write("yolcu adı:");
            //passengerName =Console.ReadLine ();
            //Console.Write("yolcu soyadı:");
            //passengerSurname = Console.ReadLine ();
            //Console.Write("ilçe bilgisi:");
            //passengerDistrict = Console.ReadLine ();
            //Console.Write("yolcu yaşı:");
            //passengerAge = Console.ReadLine ();
            //Console.Write("yolcu tc kimlik no:");
            //passengerIdentıtyNumber = Console.ReadLine ();
            //Console.Write("şehir bilgisi:");
            //passengerCity = Console.ReadLine ();
            //Console.WriteLine();
            //Console.WriteLine("---------------");
            //Console.WriteLine("yolcu tc kimlik no:" + passengerIdentıtyNumber + " "+ " ad soyadı:"+ passengerName+" " + passengerSurname + " " +"il/ilçe:"+passengerCity+ "/" +passengerDistrict +" "+"yaşı:"+passengerAge);


            #endregion

            #region klavyeden tam sayı girişleri ve dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 2000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //int totalPrice = shoesCount * shoesPrice + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;
            //Console.WriteLine();
            //Console.WriteLine("toplam ödemeniz gereken tutar" + totalPrice);

            #endregion

            #region klavyeden ondalıklı sayı işlemleri
            //double exam1, exam2, exam3, result;
            //Console.Write("lütfen 1. sınav notunu giriniz:");
            //exam1 =double.Parse(Console.ReadLine());
            //Console.Write("lütfen 2. sınav notunu giriniz:");
            //exam2=double.Parse(Console.ReadLine());
            //Console.Write("lütfen 3. sınav notunu giriniz");
            //exam3 =double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();

            //Console.WriteLine("sınav ortalamanız: " +result);



            #endregion

            #region klavyeden karakter girişleri
            char gender;
            Console.Write("lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("seçtiğiniz cinsiyet :" + gender);

            #endregion

            Console.Read();

        }
    }
}
