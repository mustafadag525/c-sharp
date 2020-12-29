using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖgrenciBilgi
{
  public class Egitmen:BasıcType // basictype' daki özellikleri kullanmak için;
    {
        
        public string brans { get; set; }
        public int bransseviyesi { get; set; }
        public DateTime isbaslangictarih { get; set; }
        public DateTime isbitis { get; set; }
        public int izingunsayisi { get; set; }
        public Egitmen()
        {
            Console.WriteLine("eğitmen nesnesinin yapıcı metodu çalıştı");
            
        }
        
       
    }
}
