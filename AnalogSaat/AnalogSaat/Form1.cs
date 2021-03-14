using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogSaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int birakilacakBosluk = 20;

        private void Saat(int saat)
        {
            Graphics grafik = this.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 6);

            float r = this.ClientSize.Width / 2;
            if (this.ClientSize.Width > this.ClientSize.Height)
            {
                float formunRYuksekligi = this.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }
            float xOrta = this.ClientSize.Width / 2;
            float yOrta = this.ClientSize.Height / 2;
            float aci = -saat * 30 + 90;

            r -= (float)(r * 0.40);//kenarlardan birakilacak bosluk

            float noktaX = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));
            float noktaY = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

            grafik.DrawLine(kalem, xOrta, yOrta, noktaX, noktaY);
        }

        private void Dakika(int dakika)
        {
            Graphics grafik = this.CreateGraphics();
            Pen kalem = new Pen(Color.Blue, 5);

            float r = this.ClientSize.Width / 2;
            if (this.ClientSize.Width > this.ClientSize.Height)
            {
                float formunRYuksekligi = this.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }
            float xOrta = this.ClientSize.Width / 2;
            float yOrta = this.ClientSize.Height / 2;
            float aci = -dakika * 6 + 90;

            r -= (float)(r * 0.25);//kenarlardan birakilacak bosluk

            float noktaX = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));
            float noktaY = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

            grafik.DrawLine(kalem, xOrta, yOrta, noktaX, noktaY);
        }

        private void Saniye(int saniye)
        {
            Graphics grafik = this.CreateGraphics();
            Pen kalem = new Pen(Color.Red, 4);
            
            float r = this.ClientSize.Width / 2;
            float yOrta = this.ClientSize.Height / 2;

            if (this.ClientSize.Width > this.ClientSize.Height)
            {
                float formunRYuksekligi = this.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }
            
            float xOrta = this.ClientSize.Width / 2;
            float aci = -saniye * 6 + 90;

            r -= (float)(r * 0.10);//kenarlardan birakilacak bosluk

            float noktaX = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));
            float noktaY = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));
            
            grafik.DrawLine(kalem, xOrta, yOrta, noktaX, noktaY);
        }
        
        private void Cerceve()
        {
            Graphics grafik = this.CreateGraphics();
            int kalemDefaultBoy = 4;
            Pen kalem = new Pen(Color.Black, kalemDefaultBoy);

            float r = this.ClientSize.Width / 2;
            float alinacakDeger = 0;
            float alinacakDegerX = 0;
            float alinacakDegerY = 0;

            if (this.ClientSize.Height < this.ClientSize.Width)
            {
                alinacakDeger = this.ClientSize.Height;
                alinacakDegerY = 0;
                alinacakDegerX = (this.ClientSize.Width - this.ClientSize.Height)/2;
            }
            else
            {
                alinacakDeger = this.ClientSize.Width;
                alinacakDegerX = 0;
                alinacakDegerY = (this.ClientSize.Height - this.ClientSize.Width) / 2;
            }

            grafik.DrawEllipse(kalem, alinacakDegerX,alinacakDegerY, alinacakDeger, alinacakDeger);
            
            float kx1, kx2, ky1, ky2;
            float xOrta = this.ClientSize.Width / 2, yOrta = this.ClientSize.Height / 2;

            if (this.ClientSize.Width > this.ClientSize.Height)
            {
                float formunRYuksekligi = this.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }

            r -= birakilacakBosluk;

            for (int aci = 0; aci <= 360; aci += 6)
            {
                kx1 = (float)(xOrta + (r + 10) * Math.Cos(aci * Math.PI / 180));//10 çizgi uzunluğunu temsil ediyor.
                kx2 = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));

                ky1 = (float)(yOrta - (r + 10) * Math.Sin(aci * Math.PI / 180));//10 çizginin eğimini temsil ediyor.
                ky2 = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

                if (aci % 90 == 0)//çeyrek, yarım veya tam'a eşit ise
                {
                    kalem.Width = kalemDefaultBoy + 4;
                    grafik.DrawLine(kalem, kx1, ky1, kx2, ky2);
                }
                else if (aci % 30 == 0)//her saat başı
                {
                    kalem.Width = kalemDefaultBoy;
                    grafik.DrawLine(kalem, kx1, ky1, kx2, ky2);
                }
                else//her dakika
                {
                    kalem.Width = kalemDefaultBoy-2;
                    grafik.DrawLine(kalem, kx1, ky1, kx2, ky2);
                }
            }
        }

        private void Sus()
        {
            Graphics grafik = this.CreateGraphics();
            SolidBrush firca = new SolidBrush(Color.FromArgb(229, 213, 121));

            float r = this.ClientSize.Width / 2;
            float alinacakDeger = 0;
            float alinacakDegerX = 0;
            float alinacakDegerY = 0;

            if (this.ClientSize.Height < this.ClientSize.Width)
            {
                alinacakDeger = 10;
                alinacakDegerY = (this.ClientSize.Height / 2) - 5;
                alinacakDegerX = (this.ClientSize.Width / 2) - 5;
            }
            else
            {
                alinacakDeger = 10;
                alinacakDegerX = (this.ClientSize.Width / 2) - 5;
                alinacakDegerY = (this.ClientSize.Height / 2);
            }

            grafik.FillEllipse(firca, alinacakDegerX, alinacakDegerY, alinacakDeger, alinacakDeger);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Saniye(DateTime.Now.Second);
            Dakika(DateTime.Now.Minute);
            Saat(DateTime.Now.Hour);
            Cerceve();
            Sus();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            Saniye(DateTime.Now.Second);
            Dakika(DateTime.Now.Minute);
            Saat(DateTime.Now.Hour);
            Sus();
        }
    }
}