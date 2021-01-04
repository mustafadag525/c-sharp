using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("sayi gir: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Faktor a1 = new Faktor();
            a1.faktora(sayi);
            Console.ReadKey();





        }
    }
}
