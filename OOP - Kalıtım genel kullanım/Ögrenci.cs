using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖgrenciBilgi
{
   public class Ögrenci:BasıcType
    {
        public string bolum { get; set; }
        public int seviye { get; set; }

        public Ögrenci()
        {
            Console.WriteLine("ögrenci nesnesi yapıcı metodu çalıştı");
        }




    }
}
