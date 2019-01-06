using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            start:                                                   //başla etiketi
            Console.Write("1. sınav notunu giriniz:");               //konsola yazdırdım
            int not1 = Convert.ToInt16(Console.ReadLine());          //konsoldan girilen değeri int veri tipine dönüştürdüm
            Console.Write("2. sınav notunu giriniz:");                  
            int not2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("1.  performans notunuzu giriniz:");
            int p1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.  performans notunuzu giriniz:");
            int p2 = Convert.ToInt16(Console.ReadLine());
            float ort = (not1 + not2 + p1 + p2) / 4;
            if (ort < 50)                                            //eğer ortalama 50 den küçükse
            {
                Console.WriteLine("KALDINIZ");                       //bunları yazdır
                Console.WriteLine("ortalamanız " + ort);
            }
            else if (ort > 50 && ort < 100)                         //eğer ortalama 50 den büyük VE 100 den küçükse
                Console.Write("geçtiniz ortalamanız=" + ort);       //bunları yazdır
            else
            {
                Console.Clear();                                    //console ekranını temizle
                goto start;                                         //start etiketine dön
            }
            Console.ReadKey();                                      //console ekranını beklet
        }
    }
}
