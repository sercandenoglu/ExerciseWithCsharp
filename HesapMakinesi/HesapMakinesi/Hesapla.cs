using System;

enum YUZDEHESAPLAMABICIMI : byte
{//!!! enumlarda tamamını büyük harf yapma kuralını yıkmamamın ve bu şekilde isimlendirmemin nedeni labellerin lbl kısmını atınca bana vereceği metinden dolayı
    Carpma,/*x işareti olursa örnek : 250'nin %10'u */
    Cikarma,/*- işareti olursa örnek: 250'nin %10 indirimli hali*/
    Toplama,/*+ işareti olursa örnek: 250 kişilik bir nufus %10 artarsa*/
    Bolme/*/(bölme) işareti olursa örnek: 250 lira, 600 liranın yüzde kaçıdır?*/
}

namespace HesapMakinesi
{
    static class Hesapla
    {
        static private double mSonuc;

        public static double Sonuc
        {
            get { return mSonuc; }
            set { mSonuc = value; }
        }

        public static double YuzdeIslemleri(double a, YUZDEHESAPLAMABICIMI bicim)
        {
            double sonuc = 0;

            switch(bicim)
            {
                case YUZDEHESAPLAMABICIMI.Bolme:
                    sonuc = (Sonuc * 100) / a;
                    break;
                case YUZDEHESAPLAMABICIMI.Carpma:
                    sonuc = (Sonuc * a) / 100;
                    break;
                case YUZDEHESAPLAMABICIMI.Cikarma:
                    sonuc = Sonuc - ((Sonuc * a) / 100);
                    break;
                case YUZDEHESAPLAMABICIMI.Toplama:
                    sonuc = Sonuc + ((Sonuc * a) / 100);
                    break;
            }
            return sonuc;
        }

        public static double BirBoluX(double x)
        {
            double sonuc = 1 / x;
            return sonuc;
        }

        public static double KareKokAlma(double a)
        {
            double sayininKoku = Math.Sqrt(a);
            return sayininKoku;
        }

        public static double KareAlma(double a)
        {
            double sayininKaresi = Math.Pow(a, 2);
            return sayininKaresi;
        }

        public static double ToplamaIslemi(double a)
        {
            Sonuc += a;
            return Sonuc;
        }

        public static double CikarmaIslemi(double a)
        {
            Sonuc -= a;
            return Sonuc;
        }

        public static double BolmeIslemi(double a)
        {
            Sonuc /= a;
            return Sonuc;
        }

        public static double CarpmaIslemi(double a)
        {
            Sonuc *= a;
            return Sonuc;
        }
    }
}
