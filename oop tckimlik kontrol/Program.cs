using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
         Console.WriteLine("tc kimlik numarası gir: ");
            M1.Tckimlikno = Console.ReadLine();
            Console.WriteLine(M1.Tckimlikno);
            Console.ReadLine();
            
            
        }
    }
}
