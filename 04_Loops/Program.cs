using System;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            // DÖngüler 1+2+3+4+5+6
            //3+3=6+4+=10+5=15+6=21

            // for(x;y;z)
            // x:başlangıç
            // y:bitiş
            // z:artış-azalış

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim kampı");

            //}

            //for ( i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for ( i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write(" Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("yaşasın cumhuriyet");
            //}



            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{ 

            //    if (i % 5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;

            //for (int i = 1; i <=10; i++) 
            //    {
            //     totalvalue+= i;
            //    }

            //Console.WriteLine(totalvalue);


            //int totalValue= 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-------------");
            //Console.WriteLine(totalValue);

            //int count = 0;  
            //for (int i =1; i <=60; i++)
            //{
            //    if (i% 7==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //1-2-4-8-16...

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++) 
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".saat sonunda: " + bacterium);
            //}






            #endregion

            #region While Döngüsü

            //while(şart)
            //{
            //    işlemler
            //}

            //int i = 1;
            //while (i<= 10)
            //{
            //    Console.WriteLine("merhaba döngüler");
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);




















            #endregion

            #region Örnek Sınav Sorusu
            //klavyeden girilen 3 basamakları toplamını hesaplayan kodu yazarmısınız

            //456
            //Console.Write("sayıyı giriniz: ");
            // int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100; //4.56--> 4

           

            //Console.WriteLine(ones +"-" + tens + "-"+ hundreds);
            //sum= ones + tens + hundreds;
            //Console.WriteLine(sum);













            #endregion

            Console.Read();
        }
    }
}
