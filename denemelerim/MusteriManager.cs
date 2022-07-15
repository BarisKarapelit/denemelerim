using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemelerim
{
    class MusteriManager
    {
        public void musteriEkle (Musteri name)
        {
            Console.WriteLine(name.MusteriAdi+"    eklendi");
            Console.WriteLine("------------------");
        }

        public void musteriSil (Musteri surname)
        {
            Console.WriteLine(surname.MusteriSoyadi + " silindi");
            Console.WriteLine("-------------------");

        }

        public void musteriListele( Musteri puan)
        {
            Console.WriteLine(puan.MusteriPuani +" listelendi");
            Console.WriteLine("--------------------");
        }
    }
}
