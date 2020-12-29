using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖgrenciBilgi
{
    class Program
    {
        static void Main(string[] args)
        {
            Egitmen E1 = new Egitmen();
            E1.basıctype();// basıc typede tanımladıgımz bir metodu egitmen classını kullanarak cagırabiliriz;
            Console.WriteLine("eğitmen nesnesi örneklendi");
            BasıcType T1 = new BasıcType();


            E1 = (Egitmen)T1;   //  ana tip kendisinde üreyen tipi tanır ve kabul eder.temel tip kendisinden türemiş olan eğitmen classına gitip metot çağıramaz ama eğitmen temel tipe gelip yapabilir



            Personel p = new Personel();
            p.basıctype();

            Ögrenci o = new Ögrenci();
            o.basıctype();
        }
    }
}
