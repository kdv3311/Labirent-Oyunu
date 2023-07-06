using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Reflection.Emit;

namespace Labirent_Oyunu
{
    internal class VeriTabanıBaglantısı
    {   
        //veri tabanı bağlantı yolu 
        public OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;"+ "Data Source="+ Application.StartupPath+"\\labirent.accdb");

        // kullanıcı kaydı yapıyoruz
        public bool KullanıcıEkle(Kullanıcı k)
        {


            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into kullanici(kullanıcıAdi, email,sifre,erisim) values (@kadı,@email,@sifre,@erisim)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                OleDbCommand komut = new OleDbCommand(kayit, conn);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@kadı", k.kullaniciadi);
                komut.Parameters.AddWithValue("@email", k.email);
                komut.Parameters.AddWithValue("@sifre", k.sifre);
                komut.Parameters.AddWithValue("@erisim", k.erisim);

                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                conn.Close();
                MessageBox.Show("Kayıt başarılı.");
                return true;
            }

            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                return false;
            }
        }

        // olan kullanıcının bilgilerini güncelliyoruz
        public bool Guncelle(Kullanıcı k)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "UPDATE kullanici SET kullanıcıAdi = @kullanıcıAdi , email=@email , sifre=@sifre , erisim=@erisim where kullanıcıAdi= '" + k.kullaniciadi + "'";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                OleDbCommand komut = new OleDbCommand(kayit, conn);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@kullanıcıAdi", k.kullaniciadi);
                komut.Parameters.AddWithValue("@email", k.email);

                komut.Parameters.AddWithValue("@sifre", k.sifre);
                komut.Parameters.AddWithValue("@erisim", k.erisim);




                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                conn.Close();
                MessageBox.Show("Güncelleme İşlemi Gerçekleşti.");
                return true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                return false;
            }

        }


        //kullanıcıyı siliyoruz
        public bool sil(int id)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string sil = "Delete From kullanici where id=" + id;
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                OleDbCommand komut = new OleDbCommand(sil, conn);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.


                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                conn.Close();

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "Delete From skorlar where id=" + id;
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                OleDbCommand kmt = new OleDbCommand(kayit, conn);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.


                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                kmt.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                conn.Close();
                MessageBox.Show("silme işlemi gerçekleşti.");
                return true;
            }

            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                return false;
            }
        }

        // kullanıcıları listeliyoruz 
        public DataTable KullaniciListele()
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT id,kullanıcıAdi,email,sifre,erisim FROM kullanici", conn);
            DataTable tablo = new DataTable();
            conn.Open();
            adapter.Fill(tablo);
            conn.Close();
            return tablo;
        }

       // kullanıcıların skorlarını listeliyoruz
        public DataTable skorlarıListele()
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT k.kullanıcıAdi, s.skor, s.dtarih FROM kullanici as k inner join skorlar as s on k.id = s.id ", conn);
            DataTable tablo = new DataTable();
            conn.Open();
            adapter.Fill(tablo);
            conn.Close();
            return tablo;
        }

        // email adresi aynı olan kullanıcı varmı diye kontrol ediyoruz varsa var diyoruz yoksa kayıt işlemi gerçekleşiyor
        public bool mailKontrol(string mail)
        {
            OleDbCommand cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select * from kullanici where email='" + mail + "'";
            OleDbDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                conn.Close();
                return true;
            }
            else
            {
                MessageBox.Show("BU E-POSTAYA AİT KULLANICI BULUNAMADI...!!");
                conn.Close();

                return false;
            }
        }

        // bilgilerini getireceğimiz kullanıcının ıd sini alıp bilgilerinin getiriyoruz
        public DataTable secılenoyuncu(int id)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT k.kullanıcıAdi, s.skor, s.dtarih FROM kullanici as k inner join skorlar as s on k.id = s.id where s.id=" + id, conn);
            DataTable tablo = new DataTable();
            conn.Open();
            adapter.Fill(tablo);

            conn.Close();
            return tablo;
        }

       // tüm levellerdeki skorları topluyoruz

      static public int puanlar = Lvl1.puan1 + Lvl2.puan2 + Lvl3.puan3;
        // topladığımız skorları kullanıcılara bağlı olan skorlar tablosuna kaydediyoruz 
        public bool skorKaydet()
        {
            

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into skorlar (id, skor,dtarih) values (@kıd,@skor,@tarih)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                OleDbCommand komut = new OleDbCommand(kayit, conn);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@ıd", Giris.id);
                komut.Parameters.AddWithValue("@skor", puanlar.ToString());
                komut.Parameters.AddWithValue("@tarih", String.Format("{0:g}", DateTime.Now));


                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                conn.Close();
                MessageBox.Show("oyun bitti  puan : " +puanlar.ToString());
                return true;





            }

            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                return false;
            }

            
        }
        
        public int id;
       // giriş yapılan hesabın kullanıcı adını oyun giriş ekranına yazdırıyoruz
        public string oturumsahibi()
        {
            OleDbCommand cmd = new OleDbCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select * from kullanici where id=" + id;
            OleDbDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                Kullanıcı k = new Kullanıcı();

                AdminPanel y = new AdminPanel();
                string a = rd["kullanıcıAdi"].ToString();
                conn.Close();
                return a;

            }
            else
            {
                conn.Close();
                return "Hata oturum bilgilerine erişilemedi.";
                
            }
                
            
        }
    }
}
