using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3
{
   internal class Musteri
    {

        private string tckimliknumarası;
        public string Tckimlikno
        {
            get
            {
                return tckimliknumarası.Substring(0,3);
            }
            set
            {
                if (value.Length == 11)
                {
                    bool kontrol = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karekterkontrol = char.IsNumber(value[i]);
                        if (karekterkontrol)
                        {
                            //
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("tc kimlik içindeki değerler sayısal olmalıdır!!!");
                        
                    }
                    else
                    {
                        this.tckimliknumarası = value;

                    }
                }
                else
                {
                    Console.WriteLine("tc kimlik numarası 11 hane olmalıdır");
                     
                }
            }


        }






    }
}
