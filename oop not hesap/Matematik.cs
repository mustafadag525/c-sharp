using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek1._1
{
  public  class Matematik
  {
       
     public void nothesapla(string kullanıcıadı,string kullanıcısoyad,decimal n1,decimal n2,decimal n3)
        {
            Console.WriteLine("ad--{0},soyad---{1} ", kullanıcıadı, kullanıcısoyad);
            decimal ortalama = (n1 + n2 + n3) / 3;
            if(ortalama<=45)
            {
                Console.WriteLine("ortalama={0}, kaldınız", ortalama);
            }
            else
            {
                Console.WriteLine("ortalama={0}, geçtiniz", ortalama);
            }
        }


    }
}
