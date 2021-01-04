using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot
{
    class Faktor
    {

        public void faktora(int sayi)
        {
            int faktor = 1;
            for(int i=1;i<=sayi;i++)
            {
                faktor *= i;
            }
            Console.WriteLine("faktor: " + faktor);
        }

    }
}
