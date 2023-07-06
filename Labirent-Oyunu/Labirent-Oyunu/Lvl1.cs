using Labirent_Oyunu.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent_Oyunu
{
    public partial class Lvl1 : Form
    {

        int karakterSatir = 4;
        int karakterSutun = 1;
        int puan = 0;
        int can = 0;
        static public int puan1;

        int hücreBoyutu = 40;
        public Image havucResmi;
        private Image karakterResmi;
        private Image mayınresmi;
        private Image arkaplan;

        //2 boyutlu dizimizde haritamızı olusturuyoruz
        char[,] labirent = {
           { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
           { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
           { '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#', ' ', '#'},
           { '#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', '#'},
           { '#', ' ', '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#'},
           { '#', '#', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#'},
           { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', '#'},
           { '#', '#', '#', '#', '#', '#', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#'},
           { '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', '#'},
           { '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#', ' ', '#', ' ', '#'},
           { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', '#'},
           { '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#', ' ', '#', '#', '#'},
           { '#', ' ', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', 'F'},
           { '#', ' ', '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#'},
           { '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#'},
           { '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#'},
           { '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', '#'},
           { '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#', ' ', '#'},
           { '#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#'},
           { '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#', ' ', '#'},
           { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
           { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}

};
        //değişkenlere ilgili remin yolunu veriyoruz
        public Lvl1()
        {
            this.Size = new Size(915, 985);
            InitializeComponent();
            skorlarıYazdır();
            oyunBaşlat();
           
            string resimDosyaYolu = Application.StartupPath + @"\\tavsan400.png";
            string havucDosyaYolu = Application.StartupPath + @"\\havuç.png";
            string mayınDosyayolu = Application.StartupPath + @"\\mayın400.png";
            string arkaplan1 = Application.StartupPath + @"\\ağaç.png";

            // Resmi yükleyin
            karakterResmi = Image.FromFile(resimDosyaYolu);
            havucResmi = Image.FromFile(havucDosyaYolu);
            mayınresmi = Image.FromFile(mayınDosyayolu);
            arkaplan = Image.FromFile(arkaplan1);
        }

        VeriTabanıBaglantısı db = new VeriTabanıBaglantısı();
        //sure için timer nesnesini başlatıyoruz
        private void Lvl1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //karakterimizin bulundugu konuma göre kontrollerimizi yapıyoruz
        private void Lvl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int yeniSatir = karakterSatir;
            int yeniSutun = karakterSutun;
            if (can == 0)
            {
                db.skorKaydet();
                OyunGirisEkranı baslat = new OyunGirisEkranı();
                baslat.Show();
                this.Hide();
            }
            else
            {
                switch (e.KeyChar)
                {
                    case 'w':
                        yeniSatir--;
                        break;
                    case 'a':
                        yeniSutun--;
                        break;
                    case 's':
                        yeniSatir++;
                        break;
                    case 'd':
                        yeniSutun++;
                        break;
                }

                if (labirent[yeniSatir, yeniSutun] != '#')
                {
                    karakterSatir = yeniSatir;
                    karakterSutun = yeniSutun;

                    if (labirent[karakterSatir, karakterSutun] == '+')
                    {
                        puan++;
                        labirent[karakterSatir, karakterSutun] = ' ';

                    }
                    else if (labirent[karakterSatir, karakterSutun] == '*')
                    {
                        can--;

                        labirent[karakterSatir, karakterSutun] = ' ';
                    }
                    else if ((labirent[karakterSatir, karakterSutun] == 'F'))
                    {
                        haritabitti();

                    }

                    this.Invalidate();
                    skorlarıYazdır();

                }

            }


        }

        //olusturdugumuz haritamızı işliyoruz
        private void Lvl1_Paint(object sender, PaintEventArgs e)
        {
           
            Graphics g = e.Graphics;
            g.DrawImage(arkaplan, 0, 0, labirent.GetLength(1) * hücreBoyutu, labirent.GetLength(0) * hücreBoyutu);

            for (int i = 0; i < labirent.GetLength(0); i++)
            {
                for (int j = 0; j < labirent.GetLength(1); j++)
                {
                    if (labirent[i, j] == '#')
                    {
                        g.FillRectangle(Brushes.Green, j * hücreBoyutu, i * hücreBoyutu, hücreBoyutu, hücreBoyutu);
                    }
                    else if (labirent[i, j] == '+')
                    {
                        g.DrawImage(havucResmi, j * hücreBoyutu, i * hücreBoyutu, hücreBoyutu, hücreBoyutu);
                        //g.FillRectangle(Brushes.Yellow, j * hücreBoyutu, i * hücreBoyutu, hücreBoyutu, hücreBoyutu);
                    }
                    else if (labirent[i, j] == '*')
                    {
                        g.DrawImage(mayınresmi, j * hücreBoyutu, i * hücreBoyutu, hücreBoyutu, hücreBoyutu);
                    }
                }
            }
          
            g.DrawImage(karakterResmi, karakterSutun * hücreBoyutu, karakterSatir * hücreBoyutu, hücreBoyutu, hücreBoyutu);

            



        }
        //puan noktalarımızı rastgele ekliyoruz
        private void PuanNoktalariEkle()
        {
            Random random = new Random();



            for (int i = 0; i < 5; i++)
            {
                int satir = random.Next(1, labirent.GetLength(0) - 1);
                int sutun = random.Next(1, labirent.GetLength(1) - 1);
                if (labirent[satir, sutun] != '#' && labirent[satir, sutun] != '*')
                {
                    labirent[satir, sutun] = '+';

                }
                else
                {
                    i--;
                }

            }
            for (int i = 0; i < 5; i++)
            {
                int satir = random.Next(1, labirent.GetLength(0) - 1);
                int sutun = random.Next(1, labirent.GetLength(1) - 1);
                if (labirent[satir, sutun] != '#' && labirent[satir, sutun] != '+')
                {
                    labirent[satir, sutun] = '*';
                }
                else
                {
                    i--;
                }
            }





        }
        //harita sonunda bir sonraki levele yonlendiriyoruz
        void haritabitti()
        {
            timer1.Stop();
            MessageBox.Show("2.levele geçtiniz");
            Kullanıcı k = new Kullanıcı();
            k.skoryaz(puan);
            puan1 = puan;
            Lvl2 lvl2 = new Lvl2();
            lvl2.Show();
            this.Hide();
        }
        //başlangıç duzenlerimize geri dönüyoruz
        void oyunBaşlat()
        {
            başlangıcD();
            skorlarıYazdır();
            PuanNoktalariEkle();
            skorlarıYazdır();
            this.KeyPreview = true;
            this.DoubleBuffered = true;
            this.KeyPress += new KeyPressEventHandler(Lvl1_KeyPress);
            this.Paint += new PaintEventHandler(Lvl1_Paint);







        }
        void başlangıcD()
        {
            can = 3;
            puan = 0;
        }
        //skor ve canı ekrana yazdırıyoruz
        void skorlarıYazdır()
        {
            label1.Text = puan.ToString();
            label2.Text = can.ToString();
        }
        OyunGirisEkranı oyunbaslat = new OyunGirisEkranı();
        private void Lvl1_FormClosed(object sender, FormClosedEventArgs e)
        {

            oyunbaslat.Show();
            this.Hide();
        }
        int süre = 30;
        // süre sonunda oyunun sonlanmasını saglıyoruz
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblsure.Text = süre.ToString();
            süre--;
            if (süre == 0)
            {
                timer1.Stop();
                db.skorKaydet();
                OyunGirisEkranı oyunbaslat = new OyunGirisEkranı();
                this.Hide();
            }
        }
    }
}
