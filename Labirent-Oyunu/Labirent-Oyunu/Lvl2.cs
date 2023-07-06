using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent_Oyunu
{
    public partial class Lvl2 : Form
    {
        static public int puan2;

        char[,] labirent = {
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
            { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', 'F' },
            { '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', ' ', '#', '#', '#', '#', '#', '#', ' ', '#' },
            { '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', '#' },
            { '#', ' ', '#', ' ', '#', '#', '#', '#', '#', ' ', '#', '#', '#', ' ', '#', '#', ' ', '#', ' ', '#' },
            { '#', ' ', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', '#', ' ', '#' },
            { '#', ' ', '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', '#' },
            { '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', '#', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#' },
            { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', '#', '#', '#', '#', ' ', '#', '#', '#', '#', '#', '#', ' ', '#', ' ', '#', '#', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', '#' },
            { '#', '#', '#', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#', ' ', '#', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', '#' },
            { '#', ' ', '#', '#', '#', '#', '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', ' ', '#', '#', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
        };





        int karakterSatir = 18;
        int karakterSutun = 1;
        int puan;
        int can;



        int hücreBoyutu = 40;
        public Image havucResmi;
        private Image karakterResmi;
        private Image mayınresmi;
        private Image arkaplan;



        public Lvl2()
        {
            this.Size = new Size(759, 600);
            InitializeComponent();
            skorlarıYazdır();
            oyunBaşlat();
            // Resim dosya yolunu veya kaynağını belirtin
            string resimDosyaYolu = Application.StartupPath + @"\\sincap.png";
            string havucDosyaYolu = Application.StartupPath + @"\\fındık.png";
            string mayınDosyayolu = Application.StartupPath + @"\\mayın400.png";
            string arkaplan1 = Application.StartupPath + @"\\orman.png";
            // Resmi yükleyin
            karakterResmi = Image.FromFile(resimDosyaYolu);
            havucResmi = Image.FromFile(havucDosyaYolu);
            mayınresmi = Image.FromFile(mayınDosyayolu);
            arkaplan = Image.FromFile(arkaplan1);

        }


        VeriTabanıBaglantısı db = new VeriTabanıBaglantısı();
        private void Lvl2_KeyPress(object sender, KeyPressEventArgs e)
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


        private void Lvl2_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.DrawImage(arkaplan, 0, 0, labirent.GetLength(1) * hücreBoyutu, labirent.GetLength(0) * hücreBoyutu);

            for (int i = 0; i < labirent.GetLength(0); i++)
            {
                for (int j = 0; j < labirent.GetLength(1); j++)
                {
                    if (labirent[i, j] == '#')
                    {
                        g.FillRectangle(Brushes.LightGray, j * hücreBoyutu, i * hücreBoyutu, hücreBoyutu, hücreBoyutu);
                    }
                    else if (labirent[i, j] == '+')
                    {
                        g.DrawImage(havucResmi, j * hücreBoyutu, i * hücreBoyutu, hücreBoyutu, hücreBoyutu);

                    }
                    else if (labirent[i, j] == '*')
                    {
                        g.DrawImage(mayınresmi, j * hücreBoyutu, i * hücreBoyutu, hücreBoyutu, hücreBoyutu);
                    }
                }
            }
            g.DrawImage(karakterResmi, karakterSutun * hücreBoyutu, karakterSatir * hücreBoyutu, hücreBoyutu, hücreBoyutu);
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
        Kullanıcı k = new Kullanıcı();
        void haritabitti()
        {
            timer1.Stop();
            MessageBox.Show("3.levele geçtiniz");
            k.skoryaz(puan);
            puan2 = puan;

            Lvl3 lvl3 = new Lvl3();
            lvl3.Show();
            this.Hide();
        }

        void oyunBaşlat()
        {
            başlangıcD();
            skorlarıYazdır();
            PuanNoktalariEkle();
            skorlarıYazdır();
            this.KeyPreview = true;
            this.DoubleBuffered = true;
            this.KeyPress += new KeyPressEventHandler(Lvl2_KeyPress);
            this.Paint += new PaintEventHandler(Lvl2_Paint);






        }
        void başlangıcD()
        {
            can = 3;
            puan = k.skorugetir(); ;
        }
        void skorlarıYazdır()
        {
            label1.Text = puan.ToString();
            label2.Text = can.ToString();
        }

        private void Lvl2_FormClosed(object sender, FormClosedEventArgs e)
        {
            OyunGirisEkranı oyunbaslat = new OyunGirisEkranı();
            oyunbaslat.Show();
            this.Hide();
        }

        private void Lvl2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int süre = 45;
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
    }
}

