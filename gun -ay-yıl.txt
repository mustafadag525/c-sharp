using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            int yıl = DateTime.Today.Year;
            int ay = DateTime.Today.Month;
            int gun = DateTime.Today.Day;
            Console.WriteLine(gun + "-" + ay + "-" + yıl);
            Console.ReadLine();

        }
    }
}
