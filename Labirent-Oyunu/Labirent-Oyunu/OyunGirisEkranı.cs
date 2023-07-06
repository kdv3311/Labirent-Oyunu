using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent_Oyunu
{
    public partial class OyunGirisEkranı : Form
    {
        public OyunGirisEkranı()
        {
            InitializeComponent();

        }
        public string oturumsahibi;
        private void OyunGirisEkranı_Load(object sender, EventArgs e)
        {
            VeriTabanıBaglantısı db = new VeriTabanıBaglantısı();
            Kullanıcı k = new Kullanıcı();


            lbloturumsahibi.Text = Giris.oturumsahibi;
            dataGridView1.DataSource = db.skorlarıListele();
            listBox1.Items.Add("- Oyunda 3 aşama vardır.");
            listBox1.Items.Add("- Her aşamada farklı karakterler vardır.");
            listBox1.Items.Add("- Karakter belirlenen süre içinde en fazla 3 mayına değmeden çıkış bölümüne ulaşmalıdır.");
            listBox1.Items.Add("- Her aşamada bitiş noktasına ulaşıldığında sonraki aşamaya geçilir ve hak 3 olarak güncellenir.");
            listBox1.Items.Add("- Herhangi bir aşamada 3 hakkını dolduğunda oyun biter.");
            listBox1.Hide();

        }
        //başla kısmına tıklandığında oyunun ilk aşamasının olduğu sayfaya yönlendiriyoruz
        private void button1_Click(object sender, EventArgs e)
        {
            Lvl1 lvl1 = new Lvl1();
            lvl1.Show();
            this.Hide();
        }


        //form kapatıldıgında giriş kısmına yonlendiriyoruz
        private void OyunGirisEkranı_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris g = new Giris();
            g.Show();
            this.Hide();
        }

        //oyun kuralları gösterme kısmı
        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            listBox1.Show();
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            listBox1.Hide();
        }
    }
}
