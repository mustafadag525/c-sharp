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

            double sayi, toplam = 0, ortalama = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + ". sayi");
                sayi = Convert.ToDouble(Console.ReadLine());
                toplam += sayi;
            }
            ortalama = toplam / 10;
            Console.WriteLine("toplam: {0}\n ortalama: {1}", toplam, ortalama);
            Console.ReadKey();

        }
    }
}
