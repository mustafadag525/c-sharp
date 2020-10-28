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




        static bool asalmı(int sayı)
        {
            if (sayı == 1)
            {
                return false;
            }
            else if (sayı == 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < sayı; i++)
                {
                    if (sayı % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }


        }





        static void Main(string[] args)
        {
            Console.WriteLine("sayi gir: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            if(asalmı(s1))
            {
                Console.WriteLine("{0} sayisi asal", s1);
            }
            else
            {
                Console.WriteLine("{0} sayısı asal değil",s1);
            }
            Console.ReadLine();


            
        }
        
       


        
    }

   
}
