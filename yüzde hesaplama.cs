using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static void Main(string[] args)
        {
            double alis, karOran, satis;
            Console.Write("Sayıyı Girin : ");
            alis = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kar Oranını Girin : ");
            karOran = Convert.ToDouble(Console.ReadLine());
            satis = alis+(alis * karOran / 100);
            Console.WriteLine("Satış Fiyatı : {0}",satis);
            Console.ReadKey();
        }
