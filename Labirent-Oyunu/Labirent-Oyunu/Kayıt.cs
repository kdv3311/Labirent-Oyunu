using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent_Oyunu
{
    public partial class Kayıt : Form
    {
        
        public Kayıt()
        {
            InitializeComponent();
        }
        VeriTabanıBaglantısı b = new VeriTabanıBaglantısı();
        ////ilgili verileri şartlar sağlandığı surece veritabanına gönderip kayıt işlemi gerçekleştiriyoruz
        private void button1_Click(object sender, EventArgs e)
        {
            if (kullanıcıadıkontrol(kullanıcıadi.Text))
            {
                if (Email_Format_Kontrol(txteposta.Text))
                {
                    if (txtsifre.Text.Length < 8)
                    {
                        MessageBox.Show("Şifre en az 8 karakterden oluşmalıdır...!!!!!");
                    }
                    else
                    {
                        if (txtsifre.Text.ToString() == txtsifretekrar.Text.ToString())
                        {
                            Kullanıcı k = new Kullanıcı();
                            k.kullaniciadi = kullanıcıadi.Text;
                            k.email = txteposta.Text;
                            k.sifre = txtsifre.Text;
                            k.erisim = 0;
                            b.KullanıcıEkle(k);
                            Giris g = new Giris();
                            g.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("Lütfen şifrenizi kontrol ediniz ...!!!!");

                    }

                }
                else
                {
                    MessageBox.Show("lütfen geçerli bir e posta giriniz..!");
                    txteposta.Focus();
                }
            }

        }
        //mail formatını kontrol ediyoruz
        public static bool Email_Format_Kontrol(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
       // Form kapatıldıgında yonlendirme yapıyoruz
        private void Kayıt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void Kayıt_Load(object sender, EventArgs e)
        {

        }
        //aynı isimde kullanıcı var mı yokmu diye kontrol ediyoruz
        public bool kullanıcıadıkontrol(string kullanıcı)
        {
            OleDbCommand cmd = new OleDbCommand();
            b.conn.Open();
            cmd.Connection = b.conn;
            cmd.CommandText = "select * from kullanici where kullanıcıAdi='" + kullanıcı + "'";
            OleDbDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {


                b.conn.Close();
                MessageBox.Show("Kullanıcı adı başka bir kişi tarafından kullanılmakta");
                kullanıcıadi.Focus();
                return false;




            }
            else
            {


                b.conn.Close();
                return true;
            }

        }
        //şifre ve şifre tekrar alanlarının birbirine eşitliğini kontrol ediyoruz
        private void txtsifretekrar_TextChanged(object sender, EventArgs e)
        {
            if (txtsifre.Text.ToString() != txtsifretekrar.Text.ToString())
            {
                label2.Text = "Şifreler eşleşmiyor.";
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.Text = "Şifreler eşleşti";
                label2.ForeColor = Color.Green;

            }
        }
    }
}
