using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖgrenciBilgi
{
   public class BasıcType
    {
        // diğer classlarda ortak olanları tek clasta topladık;
        
        public int id { get; set; }
        public string referanskod { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string  tckimlikno { get; set; }
        public string cinsiyet { get; set; }
        public DateTime kayıttarih { get; set; }
        public int kayıtkullanıcı { get; set; }
        public DateTime güncellemetarih { get; set; }
        public  int güncellemekullanıcı { get; set; }
        public bool silindi { get; set; }

        public BasıcType()
        {
            Console.WriteLine("basic type nesnesinin yapıcı metodu çalıştı");
            idAta();
           

        }
        
        
        private void idAta()
        {
            Console.WriteLine("id hangi değer aralıklarında olsun ?");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Random rastgele = new Random();
            int iduret=  rastgele.Next(sayi1, sayi2);
            Console.WriteLine("id: {0}", iduret);
            
            
        }
        
        public void basıctype()
        {
            Console.WriteLine("basıc type => metot 1");
        }
      


    }
}
