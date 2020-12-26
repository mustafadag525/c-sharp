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
            string ad = string.Empty;
            string soyad = string.Empty;
            decimal not1 = 0, not2 = 0, not3 = 0;
            decimal ortalam = 0;
            Console.WriteLine("kullanıcı adı: ");
            ad = Console.ReadLine();
            Console.WriteLine("kullanıcı soyadı: ");
            soyad = Console.ReadLine();

            Console.WriteLine("not1: ");
            not1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("not2: ");
            not2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("not3: ");
            not3 = Convert.ToDecimal(Console.ReadLine());


            Matematik M = new Matematik();
            M.nothesapla( ad,  soyad,  not1,  not2,  not3);


            Console.ReadLine();
        }
    }
}