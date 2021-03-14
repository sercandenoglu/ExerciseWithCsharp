using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DijitalSaat
{
    class DijitalSayilar
    {
        static public byte kalinlik = 4;
        private byte[] sayilarinCizgiAdetleri = { 4, 1, 5, 4, 3, 5, 4, 2, 5, 4 };//index numaraları sayıların çizgi adetlerini temsil ediyor.

        public Point noktaBir = new Point(), noktaIki = new Point();
        public Pen kalem = new Pen(Color.Black, kalinlik);

        public void SayiyaGit(byte sayi, Panel pnl)
        {
            switch (sayi)
            {
                case 0:
                    Sifir(pnl);
                    break;
                case 1:
                    Bir(pnl);
                    break;
                case 2:
                    Iki(pnl);
                    break;
                case 3:
                    Uc(pnl);
                    break;
                case 4:
                    Dort(pnl);
                    break;
                case 5:
                    Bes(pnl);
                    break;
                case 6:
                    Alti(pnl);
                    break;
                case 7:
                    Yedi(pnl);
                    break;
                case 8:
                    Sekiz(pnl);
                    break;
                case 9:
                    Dokuz(pnl);
                    break;
            }
        }

        private void Ciz(Panel pnl)
        {
            Graphics grafik = pnl.CreateGraphics();
            grafik.DrawLine(kalem, noktaBir, noktaIki);
        }

        public void Bir(Panel pnl)
        {
            noktaBir.X = pnl.Width - 4;
            noktaBir.Y = pnl.Height - (pnl.Height - 4);

            noktaIki.X = pnl.Width - 4;
            noktaIki.Y = pnl.Height - 4;
            Ciz(pnl);
        }

        public void Iki(Panel pnl)
        {
            for (int i = 0; i < sayilarinCizgiAdetleri[2]; i++)
            {
                switch(i)
                {
                    case 0:
                        noktaBir.X = pnl.Width - (pnl.Width - 4);
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - (pnl.Height - 4);
                        break;
                    case 1:
                        noktaBir.X = pnl.Width - 4;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height / 2;
                        break;
                    case 2:
                        noktaBir.X = pnl.Width - (pnl.Width - 4);
                        noktaBir.Y = pnl.Height / 2;

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height / 2;
                        break;
                    case 3:
                        noktaBir.X = pnl.Width - (pnl.Width - 4);
                        noktaBir.Y = pnl.Height / 2;

                        noktaIki.X = pnl.Width - (pnl.Width - 4);
                        noktaIki.Y = pnl.Height - 4;
                        break;
                    case 4:
                        noktaBir.X = pnl.Width - (pnl.Width - 4);
                        noktaBir.Y = pnl.Height - 4;

                        noktaBir.X = pnl.Width - 4;
                        noktaBir.Y = pnl.Height - 4;
                        break;
                }
                Ciz(pnl);
            }
        }

        public void Uc(Panel pnl)
        {
            for(int i=0;i<sayilarinCizgiAdetleri[3];i++)
            {
                switch(i)
                {
                    case 0:
                        noktaBir.X = pnl.Width - (pnl.Width - 4);
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - (pnl.Height - 4);
                        break;
                    case 1:
                        noktaBir.X = pnl.Width - 4;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                    case 2:
                        noktaBir.X = pnl.Width - (pnl.Width - 4);
                        noktaBir.Y = pnl.Height / 2;

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height / 2;
                        break;
                    case 3:
                        noktaBir.X = pnl.Width - (pnl.Width - 4);
                        noktaBir.Y = pnl.Height - 4;

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                }
                Ciz(pnl);
            }
        }

        public void Dort(Panel pnl)
        {
            for(int i = 0; i < sayilarinCizgiAdetleri[4];i++)
            {
                switch(i)
                {
                    case 0:
                        noktaBir.X = pnl.Width - 4;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                    case 1:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height / 2;

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height / 2;
                        break;
                    case 2:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width / 2;
                        noktaIki.Y = pnl.Height / 2;
                        break;
                }
                Ciz(pnl);
            }
        }

        public void Bes(Panel pnl)
        {
            for (int i = 0; i < sayilarinCizgiAdetleri[5]; i++)
            {
                switch (i)
                {
                    case 0:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - (pnl.Height - 4);
                        break;
                    case 1:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width / 2;
                        noktaIki.Y = pnl.Height / 2;
                        break;
                    case 2:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height / 2;

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height / 2;
                        break;
                    case 3:
                        noktaBir.X = pnl.Width - 4;
                        noktaBir.Y = pnl.Height / 2;

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                    case 4:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - 4;

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                }
                Ciz(pnl);
            }
        }

        public void Alti(Panel pnl)
        {
            for(int i=0;i<sayilarinCizgiAdetleri[6];i++)
            {
                switch(i)
                {
                    case 0:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width / 2;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                    case 1:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height / 2;

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height / 2;
                        break;
                    case 2:
                        noktaBir.X = pnl.Width - 4;
                        noktaBir.Y = pnl.Height / 2;

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                    case 3:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - 4;

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                }
                Ciz(pnl);
            }
        }

        public void Yedi(Panel pnl)
        {
            for (int i = 0; i < sayilarinCizgiAdetleri[7]; i++)
            {
                switch (i)
                {
                    case 0:
                        noktaBir.X = pnl.Width - 4;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                    case 1:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - (pnl.Height - 4);
                        break;
                }
                Ciz(pnl);
            }
        }

        public void Sekiz(Panel pnl)
        {
            for(int i=0;i<sayilarinCizgiAdetleri[8];i++)
            {
                switch(i)
                {
                    case 0:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width / 2;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                    case 1:
                        noktaBir.X = pnl.Width - 4;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                    case 2:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - (pnl.Height - 4);
                        break;
                    case 3:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height / 2;

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height / 2;
                        break;
                    case 4:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - 4;

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                }
                Ciz(pnl);
            }
        }

        public void Dokuz(Panel pnl)
        {
            for(int i=0;i<sayilarinCizgiAdetleri[9];i++)
            {
                switch(i)
                {
                    case 0:
                        noktaBir.X = pnl.Width - 4;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                    case 1:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - (pnl.Height - 4);
                        break;
                    case 2:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width / 2;
                        noktaIki.Y = pnl.Height / 2;
                        break;
                    case 3:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height / 2;

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height / 2;
                        break;
                }
                Ciz(pnl);
            }
        }

        public void Sifir(Panel pnl)
        {
            for(int i = 0; i < sayilarinCizgiAdetleri[0]; i++)
            {
                switch(i)
                {
                    case 0:
                        noktaBir.X = pnl.Width - 4;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                    case 1:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - (pnl.Height - 4);
                        break;
                    case 2:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - (pnl.Height - 4);

                        noktaIki.X = pnl.Width / 2;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                    case 3:
                        noktaBir.X = pnl.Width / 2;
                        noktaBir.Y = pnl.Height - 4;

                        noktaIki.X = pnl.Width - 4;
                        noktaIki.Y = pnl.Height - 4;
                        break;
                }
                Ciz(pnl);
            }
        }
    }
}
