using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖgrenciBilgi
{
   public class Personel:BasıcType
    {
        public DateTime isbaslangictarih { get; set; }
        public DateTime isbitis { get; set; }
        public int izingunsayisi { get; set; }

        public Personel()
        {
            Console.WriteLine("personel nesnesi yapıcı metodu çalıştı");
        }



    }
}
