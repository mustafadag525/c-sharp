using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace dizi1
{
    class Program
    {
        static void Main(string[] args)
        {
            int faktor = 1;
            int sayi;
            Console.WriteLine("sayi gir:");
            sayi = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=sayi;i++)
            {
                faktor *= i;
            }
            Console.WriteLine("faktoriyel: " + faktor);
            Console.ReadLine();
                        
        }
    }
}

