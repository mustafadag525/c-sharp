using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot
{
    class Program
    {
        
        static void Main(string[] args)
        {
            EbobBulma E1 = new EbobBulma();
            int s1, s2;
            Console.WriteLine("sayi gir: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayi gir: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ebob: " + E1.ebobbul(s1, s2));
            Console.ReadLine();
            
        }
    }
}
