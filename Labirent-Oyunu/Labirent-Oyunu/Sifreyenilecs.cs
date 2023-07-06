using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent_Oyunu
{
    public partial class Sifreyenilecs : Form
    {
        public Sifreyenilecs()
        {
            InitializeComponent();
        }
        public int idd;
        VeriTabanıBaglantısı db = new VeriTabanıBaglantısı();
        private void Sifreyenilecs_Load(object sender, EventArgs e)
        {

        }
        // mail gönderilen kullanıcıya ait id bilgisi ve yeni şifre değeri alınarak veri tabanında güncelleme işlemi gerçekleştiriyoruz
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsifre.Text.Length >= 8)
            {

                try
                {
                    if (db.conn.State == ConnectionState.Closed)
                        db.conn.Open();
                    // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                    string kayit = "UPDATE kullanici SET sifre=@sifre  where id= " + idd;
                    // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                    OleDbCommand komut = new OleDbCommand(kayit, db.conn);
                    //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.


                    komut.Parameters.AddWithValue("@sifre", txtsifre.Text);




                    //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                    komut.ExecuteNonQuery();
                    //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                    db.conn.Close();
                    MessageBox.Show("Şifre yenileme İşlemi Gerçekleşti.");
                    g.Show();
                    this.Hide();

                }

                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Şifreniz en az 8 karakterden oluşmalıdir.");
            }

        }
        Giris g = new Giris();
        private void Sifreyenilecs_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            g.Show();
            this.Hide();
        }
    }
}
