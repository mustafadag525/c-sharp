using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot
{
   public class EbobBulma
    {
        public int ebobbul(int sayi1, int sayi2)
        {
            int ebob = 1;
            for(int i=1;i<=sayi1 && i<=sayi2;i++)
            {
                if(sayi1%i==0 && sayi2%i==0)
                {
                    ebob = i;
                }
            }
            return ebob;
        }

    }
}
