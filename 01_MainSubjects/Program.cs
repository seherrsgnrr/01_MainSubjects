using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("merhaba dünya");
            //Console.Write("selam");
            //Console.WriteLine();
            //Console.WriteLine("***** YEMEK KATEGORİLERİ****");
            //Console.WriteLine();
            //Console.WriteLine("Çorbalar");
            //Console.WriteLine("Ana Yemekler");
            //Console.WriteLine("Soğuk Başlangıçlar");
            //Console.WriteLine("Salatalar");
            //Console.WriteLine("Tatalılar");
            //Console.WriteLine("İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("****YEMEK KATEGORİLERİ****");
            #endregion


            #region String Değişkenler
            //Değişken_türü değişken_adı
            //string name;
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail, district, city;
            //string customerPhone;

            //customerName = " Ali";
            //customerSurname = "Toprak";
            //customerEmail ="toprak@gmail.com";
            //customerPhone = "05 457 891 445";
            //district = "Tarsus";
            //city = "Mersin";
            //Console.WriteLine("**** Rezervasyon kartı****");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri:" +  customerName +" " + customerSurname);
            //Console.WriteLine("iletişim:" + customerPhone );
            //Console.WriteLine("email:" + customerEmail);
            //Console.WriteLine("adres:" + district +"|" +city);
            //Console.WriteLine("----------------------------");

            //customerName = "seher ";
            //customerSurname = "sığınır";
            //customerEmail =("seher@gmail.com");
            //customerPhone = ("052014478");
            //district = ("tarsus");
            //city = ("mersin");
            //Console.WriteLine("--------------------");
            //Console.WriteLine("Müşteri:" + customerName + customerSurname);



            #endregion

            #region int
            
            int number = 24;
            Console.WriteLine(number);


            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrace = 18;
            int friesPrace = 10;
            int pizzaPrace = 250;
            int lemonadePrace = 25;

            Console.WriteLine("****restoran menü fiyatı****");
            Console.WriteLine();
            Console.WriteLine("hamburger:" + hamburgerPrice + "tl");
            Console.WriteLine("kola:" + cokePrice + "tl");
            Console.WriteLine("su" + waterPrace + "tl");
            Console.WriteLine("kızartma" + friesPrace + "tl");
            Console.WriteLine("pizza" + pizzaPrace + "tl");
            Console.WriteLine("limonata" + lemonadePrace + "tl");
            Console.WriteLine();
            Console.WriteLine("**** restoran menü***");



            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalhamburgerPrice = 0;
            int totalcokePrice;
            int totalwaterPrice;
            int totalfriesPrice;
            int totalpizzaPrice;
            int totallemonadePrice;
        
             hamburgerCount = 1;
             cokeCount = 3;
             waterCount = 8;
             friesCount = 7;
             pizzaCount = 6;
            lemonadeCount = 5;

            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            totalcokePrice = cokeCount * cokePrice;
            totalpizzaPrice = pizzaCount * pizzaPrace;
            totalwaterPrice = waterCount * waterPrace;
            totallemonadePrice = lemonadeCount * lemonadePrace;
            totalfriesPrice = friesCount * friesPrace;

            Console.WriteLine("------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalhamburgerPrice + "tl");
            Console.WriteLine("kola Tutarı: " + totalcokePrice+ "tl");
            Console.WriteLine("su Tutarı: " + totalhamburgerPrice + "tl");
            Console.WriteLine("kızartma Tutarı: " + totalhamburgerPrice + "tl");
            Console.WriteLine("pizza Tutarı: " + totalhamburgerPrice + "tl");
            Console.WriteLine("limonata Tutarı: " + totalhamburgerPrice + "tl");

            Console.WriteLine();

            int totalPrice = totalcokePrice + totalhamburgerPrice + totallemonadePrice + totalfriesPrice + totalwaterPrice + totalpizzaPrice;
            Console.WriteLine("toplam ödenecek tutar:" +totalPrice + " tl");
            #endregion

            Console.Read();

        }
    }
}
