using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE

            //Console.Write(" lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password =="abcd")
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}

            //string capital ,country;
            //Console.WriteLine("başkenti giriniz");
            //capital = Console.ReadLine();

            //Console.WriteLine("ülkeyi giriniz");
            //country = Console.ReadLine();

            //if (capital == "ankara"& country=="türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //} 

            //int sayi;
            //Console.Write("sayıyı giriniz: ");
            //sayi = int.Parse(Console.ReadLine());
            //if(sayi== 5)
            //{
            //    Console.WriteLine("sayı doğru");

            //}
            //else
            //{
            //    Console.WriteLine("sayı hatalı");

            //}

            //int exam1, exam2, exam3, average;
            //string result= "HATA!" ;

            //Console.Write("sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("sınavların ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "sonuç orta";

            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = " sonuç iyi";

            //}
            //if (average > 84)
            //{
            //    result = "sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "bursa" | city == "trabzon")

            //{
            //    Console.WriteLine("şehir mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil.");
            //}        

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez!");

            //}
            //else
            //{
            //    Console.Write("hoşgeldiniz");
            //}
            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            // int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("lütfen 1. sayıyı giriniz :");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sayıyı giriniz: ");
            //int number2=int.Parse(Console.ReadLine());

            // result=number1%number2;
            //Console.Write("1. sayının 2. sayıya bölümünden kalan : " + result);

            //Console.Write(" lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2  == 0)
            //{
            //    Console.Write("sayı çifttir");
            //}
            //else
            //{ 
            //    Console.Write("sayı tektir");
            //}
            #endregion

            #region CHAR değişkenler ile karar yapıları         
            //char team;
            //Console.Write("lütfen takım sembolünü giriniz: ");
            //team= char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("fenerbahçe");

            //} 
            //if (team == 'b' | team =='B')
            //{
            //    Console.Write("beşiktaş");

            //}




            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("*******C# Eğitim Kampı Restoran*******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.WriteLine("1-ANA YEMEKLER");
            //Console.WriteLine("2-ÇORBALAR");
            //Console.WriteLine("3-PİZZALAR");
            //Console.WriteLine("4-TATLILAR");
            //Console.WriteLine("-----------------------");

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz veri seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcam mussakka");
            //    Console.WriteLine("----------Ana yemekler-----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------Çorbalar--------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("----------Çorbalar-----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------Pizzalar--------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-margeritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("----------Pizzalar-----------");
            //    Console.WriteLine();

            //    if (menuItem == "4")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("-------İçecekler--------");
            //        Console.WriteLine();
            //        Console.WriteLine("1-Kola");
            //        Console.WriteLine("2-Ayran");
            //        Console.WriteLine("3-Su");
            //        Console.WriteLine("---------İçecekler-----------");
            //        Console.WriteLine();
            //    }
            //    if (menuItem == "5")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("-------Tatlılar--------");
            //        Console.WriteLine();
            //        Console.WriteLine("1-Triliçe");
            //        Console.WriteLine("2-Kazandibi");
            //        Console.WriteLine("3-Sütlaç");
            //        Console.WriteLine("---------Tatlılar-----------");
            //        Console.WriteLine();
            //    }

            #endregion


            #region SWİTCH CASE

            //Console.Write("lütfen ay girişi yapınız:");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //  case 1: Console.Write("ocak"); break;
            //  case 2 : Console.Write("şubat"); break;
            //  case 3: Console.Write("mart"); break;
            //  case 4: Console.Write("nisan"); break;
            //  case 5: Console.Write("mayıs"); break;
            //  case 6: Console.Write("haziran"); break;
            //  case 7: Console.Write("temmuz"); break;
            //  case 8: Console.Write("ağustos"); break;
            //  case 9: Console.Write("eylül"); break;
            //  case 10: Console.Write("ekim"); break;
            //  case 11: Console.Write("kasım"); break;
            //  case 12: Console.Write("aralık"); break;
            //  default:Console.Write("hatalı veri girişi");break;
            //}


            #endregion

            #region SWİTCH CASE HESAP MAKİNESİ
            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write(" lütfen yapmak istediğiniz işlemi seçiniz: ");
            //symbol =char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+' :
            //        result = number1 + number2;
            //        Console.WriteLine("toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("bölüm : " + result);
            //        break;


            //        Console.Read();






            }





















            #endregion

















        }
    }
}

        
            
            
        
    

