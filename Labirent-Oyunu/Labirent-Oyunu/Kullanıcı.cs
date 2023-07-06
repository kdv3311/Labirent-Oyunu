using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirent_Oyunu
{   // projemizde kullanmak üze kullanıcı nesnemizi oluşturuyoruz
    internal class Kullanıcı
    {


        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string email { get; set; }
        public int erisim { get; set; }
        public  int skor { get; set; }
        public void skoryaz(int s)
        {
            skor = s;
        }
        public int skorugetir()
        {
            return skor;
        }
       
 
       
    }

}
