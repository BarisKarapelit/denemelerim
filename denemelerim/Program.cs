using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemelerim
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Asena";
            musteri1.MusteriSoyadi = "Ayaz";
            musteri1.MusteriPuani = 10;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.musteriEkle(musteri1);
            musteriManager.musteriSil(musteri1);
            musteriManager.musteriSil(musteri1);
           // Console Ekranın da kullanıcı bir kuşa basana kadar Console açık kalmasını sağlar.
            Console.ReadKey();
        }
    }
}
