using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek1._1
{
  public  class Matematik
  {
       
        public int topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public int fark(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            return sonuc;
        }
        public int bolme(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            return sonuc;
        }
        public int çarp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            return sonuc;
        }
        public void menuolustur()
        {
            Console.Clear();
            Console.WriteLine("**** menu ****");
            Console.WriteLine("1 toplama");
            Console.WriteLine("2 fark");
            Console.WriteLine("3 bolme");
            Console.WriteLine("4 çarpma");
            Console.WriteLine("lütfen seçim yapınız");
        }
        
        public void sonucekranı(int sayi1, int sayi2, int sonuc, string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3}", sayi1, operators, sayi2, sonuc);
        }





    }
}
