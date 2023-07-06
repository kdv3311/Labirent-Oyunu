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
using static System.Windows.Forms.DataFormats;

namespace Labirent_Oyunu
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            Init_Data();
        }
        public static string oturumsahibi;
        VeriTabanıBaglantısı db = new VeriTabanıBaglantısı();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //kayıt ol kısmına gelındıgınde ilgili sayfaya yonlendiriyoruz
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayıt kayıt = new Kayıt();
            kayıt.Show();
            this.Hide();
        }
        //init ve save data kısmında benı hatırla ozelliği için verilerimizi atayıp saklıyoruz ve yazıyoruz
        private void Init_Data()
        {
            if (Properties.Settings.Default.kullanıcıadı != string.Empty)
            {
                if (Properties.Settings.Default.remember == true)
                {
                    kullanıcıadi.Text = Properties.Settings.Default.kullanıcıadı;
                    txtsifre.Text = Properties.Settings.Default.sifre;
                    checkBox1.Checked = true;
                }
                else
                {
                    kullanıcıadi.Text = Properties.Settings.Default.kullanıcıadı;
                }
            }
        }
        private void Save_Data()
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.kullanıcıadı = kullanıcıadi.Text.Trim();
                Properties.Settings.Default.remember = true;
                Properties.Settings.Default.sifre = txtsifre.Text.Trim();
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.kullanıcıadı = "";
                Properties.Settings.Default.sifre = "";
                Properties.Settings.Default.remember = false;
                Properties.Settings.Default.Save();
            }
        }
        private void Giris_Load(object sender, EventArgs e)
        {

        }
        public static int id;
        //girilen bilgilere göre veritabanı kontrolu yapıp giriş saglıyoruz
        private void giris()
        {
            if (kullanıcıadi.Text != "" && txtsifre.Text != "")
            {
                OleDbCommand cmd = new OleDbCommand();
                db.conn.Open();
                cmd.Connection = db.conn;
                cmd.CommandText = "select * from kullanici where kullanıcıAdi='" + kullanıcıadi.Text + "' and sifre='" + txtsifre.Text + "'";
                OleDbDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {

                    oturumsahibi = rd["kullanıcıAdi"].ToString();
                    id = Convert.ToInt32(rd["id"].ToString());

                    if (Convert.ToInt32(rd["erisim"]) == 1)
                    {
                        AdminPanel y = new AdminPanel();


                        y.Show();

                        this.Hide();
                    }
                    else
                    {
                        OyunGirisEkranı anasayfa = new OyunGirisEkranı();

                        anasayfa.Show();

                        this.Hide();
                    }


                }
                else
                {
                    MessageBox.Show("girdiğiniz bilgiler hatalı veya eksik...!!");

                }
            }
            else
            {
                MessageBox.Show("lütfen boş alanları doldurunuz..!");
            }
            db.conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            giris();
            Save_Data();


        }
        //şifremi unuttum kısmına gelindiğinde ilgili forma yonlendiriyoruz
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kurtarma kur = new Kurtarma();
            kur.Show();
            this.Hide();
        }
        //form kapatıldıgında uygulamayı kapatıyoruz
        private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
