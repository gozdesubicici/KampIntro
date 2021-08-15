using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrijinalQuizIkinciGun
{
    class Program
    {
        static void Main(string[] args)
        {
            //// for ile * lardan üçgen oluşturma
            //for (int i = 0; i <=5 ; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine( );

            //}

            Product urun1 = new Product();
            urun1.UrunAdi = "Babet";
            urun1.UrunFiyati = 150;
            urun1.UrunRengi = " Gri";

            Product urun2 = new Product();
            urun2.UrunAdi = "Spor Ayakkabı";
            urun2.UrunFiyati = 180;
            urun2.UrunRengi = " Siyah";

            Product urun3 = new Product();
            urun3.UrunAdi = "Terlik";
            urun3.UrunFiyati = 80;
            urun3.UrunRengi = " Siyah";

            Product urun4 = new Product();
            urun4.UrunAdi = "Topuklu";
            urun4.UrunFiyati = 354;
            urun4.UrunRengi = "Kırmızı";

            Product[] urunler = new Product[] {urun1, urun2, urun3, urun4 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine("ürün: " + urun.UrunAdi + " - " + "Fiyatı: " + urun.UrunFiyati + " Renk: " + urun.UrunRengi);
               
            }



           // Console.WriteLine(urun1.UrunAdi);





            Console.ReadLine();
        



        }

    }

    class Product
    {
        
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
        public string UrunRengi { get; set; }


    }
}
