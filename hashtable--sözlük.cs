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

        static void Main(string[] args)
        {

            Hashtable degerListesi = new Hashtable();
            string secilen = string.Empty,
                eng = string.Empty,
                trk = string.Empty;

        Yeni:

            Console.Clear();
            Console.Write("Lütfen Ingilizce değer giriniz : ");
            eng = Console.ReadLine();
            if (degerListesi.ContainsKey(eng))
            {
                Console.WriteLine("Girilen ingilizce değer sistemde bulunmaktadır. ENG = {0} TRK = {1}", degerListesi, degerListesi[eng].ToString());
                Console.ReadLine();
                goto Yeni;
            }
            else
            {
                Console.Write("Lütfen Türkçe karşılığını yazınız : ");
                trk = Console.ReadLine();
                degerListesi.Add(eng, trk);
                Console.WriteLine("Değer ekleme başarılı!");
                Console.WriteLine();

                Console.Write("Yeni değer eklemek istiyor musunuz ? (E/H)");
                secilen = Console.ReadLine();

                if (secilen.ToUpper() == "E")
                {
                    goto Yeni;
                }
                else
                {
                    
                    foreach (DictionaryEntry item in degerListesi)
                    {
                        
                        Console.WriteLine("ENG : {0} = TRK : {1}", item.Key, item.Value);
                    }
                }
                Console.ReadLine();
            }




        }
    }
}
