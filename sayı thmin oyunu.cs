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
            yenioyun:

            int sayiuret = 0;

            int sayac = 1;

            Random rastgele = new Random();

            sayiuret = rastgele.Next(1, 10);

            Console.WriteLine("Sizce hangi sayı?");

        tekrar:

            int tahmin = Convert.ToInt32(Console.ReadLine());

            while (true)

            {

                if (tahmin == sayiuret)

                {

                    Console.WriteLine("Tahmininiz doğru");

                    break;

                }

                else

                {

                    Console.WriteLine("Tahmin yanlış.Tekrar deneyiniz");

                    sayac++;

                    goto tekrar;

                }

            }

            Console.WriteLine("{0} denemede sayıyı buldunuz", sayac);

            Console.WriteLine("Tekrar oynamak için e tuşuna çıkmak için başka bir tuşa basınız");

            string giris = Console.ReadLine();

            if (giris == "E" || giris == "e")

            { goto yenioyun; }

        }
    }
}
