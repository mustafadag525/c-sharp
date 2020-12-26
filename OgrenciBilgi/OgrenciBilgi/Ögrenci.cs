using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgi
{
   public class Ögrenci
    {
        public static string domainadres = "dag.com";
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string tckimlik { get; set; }
        public string cinsiyet { get; set; }


        private string emailadres;
        public string Emailadres
        {

            get
            {
                return this.emailadres;
            }
            set
            {
                this.emailadres = value.ToLower() + "@" + Ögrenci.domainadres;
            }

        }
        private string adres;
        public string Adres {


            get
            {
                return this.adres;
            }
            set
            {
                this.adres = value + " ŞANLIURFA /HALİLİYE ";
            }
        }
    }
}
