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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        VeriTabanıBaglantısı db = new VeriTabanıBaglantısı();
        private void Yönetim_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris g=new Giris();
            g.Show();
            this.Hide();
        }
        public void güncelle(int id)
        {

            txtsifre.Text = "";
            txteposta.Text = "";
            txtkullanıcı.Text = "";
            dataGridView1.DataSource = db.KullaniciListele();

        }
        private void Yönetim_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.KullaniciListele();
        }
        int a;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            if (e.ColumnIndex == 0)
            {
                db.sil(a);
                dataGridView1.DataSource = db.KullaniciListele();
            }

            else
            {
                dataGridView2.DataSource = db.secılenoyuncu(a);
                txtkullanıcı.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txteposta.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtsifre.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "1")
                {
                    checkBox1.Checked = true;
                }
                else
                    checkBox1.Checked = false;
            }


            db.KullaniciListele();
        }
        public int aos;
        private void button1_Click(object sender, EventArgs e)
        {
            Lvl1 anasayfa = new Lvl1();
            anasayfa.Show();
            this.Hide();
        }
        private void BTNGUNCELLE_Click(object sender, EventArgs e)
        {
            if (txteposta.Text != "" && txtkullanıcı.Text != "" && txtsifre.Text.Length > 8)
            {
                Kullanıcı k = new Kullanıcı();
                k.kullaniciadi = txtkullanıcı.Text;
                k.email = txteposta.Text;
                k.sifre = txtsifre.Text;
                db.Guncelle(k);
            }
            else
                MessageBox.Show("bilgiler eksik veya hatalı");

            dataGridView1.DataSource = db.KullaniciListele();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Kullanıcı k = new Kullanıcı();
            k.email = txteposta.Text;
            k.sifre = txtsifre.Text;
            k.kullaniciadi = txtkullanıcı.Text;
            if (checkBox1.Checked == true)
            {
                k.erisim = 1;
            }
            else
            {
                k.erisim = 0;
            }
            db.KullanıcıEkle(k);
            dataGridView1.DataSource = db.KullaniciListele();
        }
    }
}
