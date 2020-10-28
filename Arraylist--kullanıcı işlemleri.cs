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
            string seçim = string.Empty;
            ArrayList degerelemanı = new ArrayList();
            while(true)
            {

                Console.Clear();
                Console.WriteLine("menü");
                Console.WriteLine("1 deger ekle");
                Console.WriteLine("2 deger listele");
                Console.WriteLine("3 deger ara");
                Console.WriteLine("4 deger düzenle ");
                Console.WriteLine("5 değer sil");
                Console.WriteLine("6 çıkış");
                Console.WriteLine("lütfen işlem seçiniz");
                seçim = Console.ReadLine();
                switch(seçim)
                {
                    case "1":
                   degerekle:     Console.WriteLine("eklemek istediğiniz değeri giriniz: ");
                        string kullanıcıdeger = Console.ReadLine();
                        degerelemanı.Add(kullanıcıdeger);
                        Console.WriteLine("değer başarıyla eklendi");
                        System.Threading.Thread.Sleep(2000);
                        break;

                    case "2":
                        for(int i=0;i<degerelemanı.Count;i++)
                        {
                            Console.WriteLine("{0}.indis değeri={1}", i, degerelemanı[i]);
                        }
                        Console.WriteLine("geçmek için herhangi bir tuşa bas");
                        Console.ReadLine();
                        System.Threading.Thread.Sleep(2000);
                        break;

                    case "3":
                        Console.WriteLine("aramak istediğiniz değeri giriniz: ");
                        string kullanıcıaranandeger = Console.ReadLine();
                        bool kontrol = degerelemanı.Contains(kullanıcıaranandeger);
                        if(kontrol)
                        {
                            int bulunanindex = degerelemanı.IndexOf(kullanıcıaranandeger);
                            string bulunsndeger = degerelemanı[bulunanindex].ToString();
                            Console.WriteLine("aranan değer bulundu");
                            Console.WriteLine("{0}.index sırası ,degeri={1}", bulunanindex, bulunsndeger);
                            Console.WriteLine("devam etmek için herhangi bir tuşa basın");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("deger bulunamadı");
                            Console.WriteLine("bu değeri eklemek için herhangi bir tuşa bas");
                            Console.ReadLine();
                            goto degerekle;
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;

                    case "4":
                        Console.WriteLine("güncelleştirmek istediğiniz degeri girin: ");
                        string kullanıcıdüzenlenendeger = Console.ReadLine();
                        Console.WriteLine("{0} degeri hangi deger ile değiştireceksiniz",kullanıcıdüzenlenendeger);
                        string kullanıcıyenideger = Console.ReadLine();
                        if(degerelemanı.Contains(kullanıcıdüzenlenendeger))
                        {
                            int hedefindex = degerelemanı.IndexOf(kullanıcıdüzenlenendeger);
                            degerelemanı[hedefindex] = kullanıcıyenideger;
                            Console.WriteLine("değer güncelleşti");

                        }
                        else
                        {
                            Console.WriteLine("değer bulunamadı");
                            Console.WriteLine("değeri eklemek istermisin");
                            string kullanıcıseçim = Console.ReadLine();
                            if(kullanıcıseçim.ToUpper()=="E ")
                            {
                                goto degerekle;
                            }
                            else
                            {
                                Console.WriteLine("devam etmek için herhangi bir tuşa bas");
                                Console.ReadLine();
                            }
                        }
                        System.Threading.Thread.Sleep(2000);

                        break;

                    case "5":

                        Console.WriteLine("tüm değerleri silmek mi istiyorsunuz (E/H)");
                        string kullanıcısilcevap = Console.ReadLine();
                        if (kullanıcısilcevap.ToUpper() == "E")
                        {
                            degerelemanı.Clear();
                            Console.WriteLine("tüm değerler silindi");
                        }
                        else
                        {
                            Console.WriteLine("liste içerisinde silmek istediğiniz elemanı girin:");
                            string kullanıcısildeger = Console.ReadLine();
                            if (degerelemanı.Contains(kullanıcısildeger))
                            {
                                degerelemanı.Remove(kullanıcısildeger);
                                Console.WriteLine("değer başarıyla silindi");
                            }
                            else
                            {
                                Console.WriteLine("değer bulunamadı");
                            }


                        }
                        System.Threading.Thread.Sleep(2000);

                        break;
                    default:
                        Console.WriteLine("hatalı şecim");
                        System.Threading.Thread.Sleep(2000);

                        break;
                        break;





                }



            }
      
               


        }
    }
}
          
                    
