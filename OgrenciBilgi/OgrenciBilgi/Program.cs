using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgi
{
    class Program
    {
        static void Main(string[] args)
        {
            Ögrenci ogr = new Ögrenci();
            ogr.isim = "mustafa";
            ogr.soyisim = "dağ";
            ogr.tckimlik = "1234567890";
            ogr.cinsiyet = "erkek";
            ogr.Emailadres = "MSTAQE124";
            ogr.Adres = "green park a blok 6 numara";
            Console.ReadKey();
        }
    }
}
