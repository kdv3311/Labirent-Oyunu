using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Labirent_Oyunu
{
    public partial class Kurtarma : Form
    {
        public Kurtarma()
        {
            InitializeComponent();
        }
        VeriTabanıBaglantısı b = new VeriTabanıBaglantısı();
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textkurtarma.Text != "")
            {
                if (kullanıcıkontrol())
                {
                    mailgonder(textkurtarma.Text, kodolustur());
                    textkurtarma.Text = "";
                    textkurtarma.Focus();
                    btnkod.Show();
                }


            }
            else
                MessageBox.Show("BURASI BOŞ GEÇİLEMEZ..!");
        }
        public int id;
        //veri tabanında girilen mail adresine ait kullanıcı kontrolu yapıyoruz
        public bool kullanıcıkontrol()
        {

            if (textkurtarma.Text != "")
            {
                OleDbCommand cmd = new OleDbCommand();
                b.conn.Open();
                cmd.Connection = b.conn;
                cmd.CommandText = "select * from kullanici where email='" + textkurtarma.Text + "'";
                OleDbDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {

                    id = Convert.ToInt32(rd[id].ToString());
                    textkurtarma.PlaceholderText = "KODU GİRİNİZ";
                    kodg.Name = "kod";
                    b.conn.Close();

                    return true;


                }
                else
                {
                    MessageBox.Show("BU E-POSTAYA AİT KULLANICI BULUNAMADI...!!");
                    b.conn.Close();

                    return false;
                }
            }
            else
            {
                MessageBox.Show("BOŞ GEÇİLEMEZ...!!");
                b.conn.Close();

                return false;
            }



        }


        //---------------------KURTARMA EPOSTASI GÖNDERME-----------------------------------
        //maile kayıtlı kullanıcı var ise maili gönderiyoruz
        public void mailgonder(string ma, string kod)
        {


            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            sc.Credentials = new NetworkCredential("tarihbilincix1@gmail.com", "hcsxmkqmpnbmhpns");

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("tarihbilincix1@gmail.com", "KURTARMA E-POSTASI");

            mail.To.Add(ma);


            mail.Subject = "KURTARMA";
            mail.IsBodyHtml = true;
            mail.Body = "KURTARMA KODUNUZ :" + kod;

            sc.Send(mail);

            kodg.Hide();
        }
        string a = "";
        //şifre yenilemek için kod oluşturuyoruz
        public string kodolustur()
        {
            a = "";
            Random sayı = new Random();
            for (int i = 0; i <= 5; i++)
            {
                a += sayı.Next(1, 10).ToString();
            }
            return a;
        }

        //mail olarak gönderilen kod ile girilen kodun kontrolunu yapıp ilgili sayfaya yönlendiriyoruz
        private void btnkod_Click(object sender, EventArgs e)
        {
            if (textkurtarma.Text == a)
            {

                Sifreyenilecs sy = new Sifreyenilecs();
                sy.Show();
                sy.idd = id;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen Kod hatalı");
                textkurtarma.Text = "";
                textkurtarma.Focus();
            }

        }

        private void Kurtarma_Load(object sender, EventArgs e)
        {
            btnkod.Hide();
        }
        Giris g = new Giris();
        private void Kurtarma_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            g.Show();
            this.Hide();
        }
    }
}
