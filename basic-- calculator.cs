using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek1._1
{
    class Program
    {

        static void Main(string[] args)
        {

            string deger1, degerr2, kul_secim = string.Empty;
            int n1, n2,sonuc=0;


   
            Console.WriteLine("sayı1 gir: ");
            deger1 = Console.ReadLine();
            Console.WriteLine("sayı2 gir: ");
            degerr2 = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("işlem seç: ");
            Console.WriteLine("1 toplama: ");
            Console.WriteLine("2 çıkarma: ");
            Console.WriteLine("3 bölme: ");
            Console.WriteLine("4 çarpma: ");
            kul_secim= Console.ReadLine();

            n1 = int.Parse(deger1);
            n2 = int.Parse(degerr2);

            if(kul_secim=="1")
            {
                sonuc = n1 + n2;
            }
           else if (kul_secim == "2")
            {
                sonuc = n1 - n2;
            }

           else if (kul_secim == "3")
            {
                sonuc = n1 / n2;
            }

            else if (kul_secim == "4")
            {
                sonuc = n1 * n2;
            }

            else
            {
                Console.WriteLine("hatali işlem");
            }

            if(sonuc!=0)
            {
                Console.WriteLine("sonuc: {0}", sonuc);
            }

            Console.ResetColor();
            Console.ReadKey();









        }
    }
}
