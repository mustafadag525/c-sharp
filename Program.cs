using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ornek1._1
{
    class Program
    {

        static void Main(string[] args)
        {
            Matematik M = new Matematik();
            M.menuolustur();
            int seçim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lutfen birinci sayiyi gir: ");
            int kullanıcıdeğer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen ikinci sayıyı gir: ");
            int  kullanıcıdeger2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = 0;
            switch(seçim)
            {
                case 1:
                 sonuc=   M.topla(kullanıcıdeğer1, kullanıcıdeger2);
                    M.sonucekranı(kullanıcıdeğer1, kullanıcıdeger2, sonuc, "+");
                    break;

                case 2:
                  sonuc=  M.fark(kullanıcıdeğer1, kullanıcıdeger2);
                    M.sonucekranı(kullanıcıdeğer1, kullanıcıdeger2, sonuc, "-");
                    break;

                case 3:
                   sonuc= M.bolme(kullanıcıdeğer1, kullanıcıdeger2);
                    M.sonucekranı(kullanıcıdeğer1, kullanıcıdeger2, sonuc, "/");
                    break;
                case 4:
                  sonuc=  M.çarp(kullanıcıdeğer1, kullanıcıdeger2);
                    M.sonucekranı(kullanıcıdeğer1, kullanıcıdeger2, sonuc, "*");
                    break;

                default:
                    Console.WriteLine("hatalı değer");
                    break;



            }
            Console.ReadLine();
        }
    }
}