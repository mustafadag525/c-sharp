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

            Console.Write("kac ögrenci ");

           
            int n = Convert.ToInt32(Console.ReadLine());
            double[] ogr_sayis = new double[n];
            double toplam = 0, ortalama = 0;
            int aa = 0, bb = 0, cc = 0, ff = 0, dd = 0,i=0;
            double vize=0, final=0;
            int sayac = 0;
            for (i=0;i<ogr_sayis.Length;i++)
            {


              
                Console.WriteLine("vize notu: ");
                vize = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("final notu: ");
                final = Convert.ToDouble(Console.ReadLine());
                sayac++;

                ortalama = (vize * 0.4 + final * 0.6);
                if (ortalama >= 90 && ortalama <= 100)
                {
                    aa++;
                }
                else if (ortalama >= 80 && ortalama < 90)
                {
                    bb++;
                }
                else if (ortalama>= 70 && ortalama < 80)
                {
                    cc++;
                }
                else if (ortalama >= 60 && ortalama < 70)
                {
                    dd++;
                }
                else if(ortalama <60)
                {
                    ff++;
                }

            }
            



            

            Console.WriteLine("ortalama: " + (ortalama/n));
            Console.WriteLine("aa " + aa);
            Console.WriteLine("bb " + bb);
            Console.WriteLine("cc " + cc);
            Console.WriteLine("dd " + dd);
            Console.WriteLine("ff " + ff);

            Console.ReadKey();


        }
    }
}
