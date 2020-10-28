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

            int i, j;
            for(i=0;i<=10;i++)
            {
                Console.WriteLine("-------------");
                for(j=0;j<=10;j++)
                {
                    Console.WriteLine((i) + "*" + (j)+"="+ i * j);
                }

            }
            Console.ReadKey();


        }
    }
}
