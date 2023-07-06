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
    public partial class Lvl3 : Form
    {
        static public int puan3;

        int karakterSatir = 39;
        int karakterSutun = 1;
        int puan = 0;
        int can = 0;

        VeriTabanıBaglantısı db = new VeriTabanıBaglantısı();

        int hücreBoyutu = 22; // Her bir hücrenin boyutunu belirledim
        public Image havucResmi;
        private Image karakterResmi;
        private Image mayınresmi;
        private Image arkaplan;

        char[,] labirent =
        {
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#','#', '#', '#', '#', '#', '#','#', '#', '#', '#', '#', '#', '#', '#', '#', '#','#', '#', '#', '#', '#', '#'},
            { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', 'F'},
            { '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#', ' ', '#','#', '#', '#', '#', '#', '#','#', '#', '#', '#', '#', '#', '#', '#', '#', '#',' ', '#', '#', '#', '#', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', '#',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', '#', ' ', ' ', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#',' ', '#', '#', '#', '#', '#','#', '#', '#', '#', '#', '#', '#', '#', '#', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', '#', '#','#', '#', '#', '#', '#', '#', '#', '#', '#', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', '#',' ', '#', ' ', '#', ' ', '#','#', '#', '#', '#', '#', '#', '#', '#', '#', '#','#', '#', '#', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#',' ', '#', ' ', '#', ' ', '#',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', '#', ' ', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ',' ', '#', ' ', '#', ' ', '#','#', '#', '#', '#', '#', '#', '#', '#', '#', '#',' ', '#', '#', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', ' ', '#', ' ', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#','#', '#', ' ', '#', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', '#', ' ', ' ', ' ', '#'},
            { '#', ' ', '#', ' ', '#', '#', ' ', '#', ' ', '#', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ',' ', ' ', ' ', '#', '#', '#','#', '#', '#', '#', '#', '#', '#', '#', '#', '#',' ', '#', ' ', '#', '#', '#'},
            { '#', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', '#', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#','#', '#', '#', '#', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', '#', '#', '#', '#', '#', ' ', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ',' ', ' ', ' ', '#', '#', '#','#', '#', '#', '#', '#', '#', '#', '#', '#', '#','#', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#',' ', '#', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#',' ', '#', ' ', '#', '#', '#','#', '#', '#', '#', '#', '#', '#', '#', '#', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#','#', '#', ' ', '#', '#', '#','#', '#', '#', '#', '#', '#', '#', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', ' ', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#','#', '#', ' ', '#', '#', '#','#', '#', '#', '#', '#', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', '#', '#', '#', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', '#', ' ', '#', ' ', ' ',' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', ' ', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',' ', '#', ' ', '#', ' ', '#','#', ' ', '#', '#', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#',' ', '#', ' ', '#', ' ', '#',' ', ' ', '#', ' ', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#',' ', '#', '#', ' ', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#',' ', '#', ' ', '#', ' ', '#',' ', ' ', '#', ' ', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',' ', '#', ' ', '#', ' ', '#','#', ' ', '#', ' ', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', '#', ' ', '#', ' ', ' ','#', ' ', '#', ' ', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#','#', '#', ' ', '#', '#', ' ','#', ' ', '#', ' ', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ','#', ' ', '#', ' ', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', '#', '#', '#', '#', '#', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#','#', '#', ' ', '#', '#', '#','#', ' ', '#', ' ', '#', '#', ' ', '#', ' ', '#','#', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ',' ', '#', ' ', '#', ' ', ' ',' ', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ',' ', ' ', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#',' ', '#', ' ', '#', ' ', '#',' ', ' ', '#', ' ', '#', '#', ' ', '#', '#', '#','#', '#', '#', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#',' ', '#', ' ', '#', ' ', '#',' ', ' ', '#', ' ', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#',' ', '#', '#', ' ', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#',' ', '#', ' ', '#', ' ', '#',' ', ' ', '#', ' ', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',' ', '#', ' ', '#', ' ', '#',' ', ' ', '#', '#', ' ', '#', ' ', '#', ' ', '#',' ', '#', ' ', '#', ' ', '#'},
            { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', '#', ' ', '#', ' ', '#',' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ',' ', ' ', ' ', '#', ' ', '#'},
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#','#', '#', ' ', '#', ' ', '#','#', '#', '#', '#', '#', '#', '#', '#', '#', '#','#', '#', ' ', '#', ' ', '#'},
            { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ',' ', ' ', ' ', ' ', ' ', '#'},
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#','#', '#', '#', '#', '#', '#','#', '#', '#', '#', '#', '#', '#', '#', '#', '#','#', '#', '#', '#', '#', '#'}
        };
        public Lvl3()
        {

            InitializeComponent();
            this.Size = new Size(1080, 940);
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Lvl3_KeyPress);
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(Lvl3_Paint);
            oyunBaşlat();

            // Resim dosya yolunu veya kaynağını belirtin
            string resimDosyaYolu = Application.StartupPath + @"\\fare.png";
            string havucDosyaYolu = Application.StartupPath + @"\\peynir.png";
            string mayınDosyayolu = Application.StartupPath + @"\\mayın400.png";
            string arkaplan1 = Application.StartupPath + @"\\orman.png";


            // Resmi yükleyin
            karakterResmi = Image.FromFile(resimDosyaYolu);
            havucResmi = Image.FromFile(havucDosyaYolu);
            mayınresmi = Image.FromFile(mayınDosyayolu);
            arkaplan = Image.FromFile(arkaplan1);
        }
        Kullanıcı k = new Kullanıcı();
        private void Lvl3_KeyPress(object sender, KeyPressEventArgs e)
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


                }

            }
        }

        private void Lvl3_Paint(object sender, PaintEventArgs e)
        {



            Graphics g = e.Graphics;
            g.DrawImage(arkaplan, 0, 0, labirent.GetLength(1) * hücreBoyutu, labirent.GetLength(0) * hücreBoyutu);

            for (int i = 0; i < labirent.GetLength(0); i++)
            {
                for (int j = 0; j < labirent.GetLength(1); j++)
                {
                    if (labirent[i, j] == '#')
                    {
                        g.FillRectangle(Brushes.Black, j * hücreBoyutu, i * hücreBoyutu, hücreBoyutu, hücreBoyutu);
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

        void haritabitti()
        {
            timer1.Stop();

            VeriTabanıBaglantısı db = new VeriTabanıBaglantısı();
            db.skorKaydet();

            puan3 = puan;

            OyunGirisEkranı anamenü = new OyunGirisEkranı();

            anamenü.Show();
            this.Hide();

        }

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
        void oyunBaşlat()
        {
            başlangıcD();

            PuanNoktalariEkle();
            skorlarıYazdır();
        }
        void başlangıcD()
        {
            can = 3;
            puan = k.skorugetir();
        }
        void skorlarıYazdır()
        {
            label1.Text = puan.ToString();
            label2.Text = can.ToString();
        }
        private void Lvl3_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int süre = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblsure.Text = süre.ToString();
            süre--;
            if (süre == 0)
            {
                timer1.Stop();
                db.skorKaydet();
            }
        }
        private void Lvl3_FormClosed(object sender, FormClosedEventArgs e)
        {
            OyunGirisEkranı oyunbaslat = new OyunGirisEkranı();
            oyunbaslat.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblsure_Click(object sender, EventArgs e)
        {

        }
    }
}


