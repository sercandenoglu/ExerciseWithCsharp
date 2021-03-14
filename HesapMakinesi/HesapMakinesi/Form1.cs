using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class frmHesapMakinesi : Form
    {
        public frmHesapMakinesi()
        {
            InitializeComponent();

            foreach (Control controls in this.Controls)
            {//mouse lbl üstüne gelince background silver olucak
                Panel pnl = (Panel)controls;
                foreach (Control cont in pnl.Controls)
                {
                    Label lbl = (Label)cont;
                    lbl.MouseEnter += Lbl_MouseEnter;
                    lbl.MouseLeave += Lbl_MouseLeave;
                }
            }

            foreach (Control controls in pnlSayilarVeIslemler.Controls)
            {//pnlSayilarVeIslemler'de ki labellerin click eventlerini oluşturuyorum. 
                Label lbl = (Label)controls;
                if (lbl.Name.Length == 4)
                {  //Sayıları ekrana yazdırma
                    lbl.MouseClick += LblSayilar_MouseClick;
                }
                else
                {//işlemler
                    lbl.MouseClick += LblIslemler_MouseClick;
                }
            }

            foreach (Control controls in pnlMatematikselIslemler.Controls)
            {//pnlMatematikselIslemler'de ki labellerin click eventlerini oluşturuyorum.
                Label lbl = (Label)controls;
                lbl.MouseClick += LblMatematikselIslemler_MouseClick;
            }

            foreach(Control controls in pnlControlBox.Controls)
            {
                Label lbl = (Label)controls;
                lbl.MouseClick += LblControl_MouseClick;
            }
        }
        
        bool degisim = false;
        int sonucTiklama = 0;//Eğer 0 ise normal sonucu yazdırıcak 0 değil ise sonuca son sayıyı son işleme göre uyguyalacak
        string sonIslem = "";//Son yapılan işlemi tutacak
        double sonSayi = 0;//Son girilen sayiyi tutacak
        
        private void LblIslemler_MouseClick(object sender, MouseEventArgs e)//İşlemler
        {//değiştirme işlemi sonuc ekrana geldikden sonra yapılabilecek ve yapılamıcak işlemleri temsil eder.
            try
            {
                Label lbl = (Label)sender;

                #region değiştirme işlemine bağlı olmayan işlemler
                switch (lbl.Name.Substring(3))//labellerimdeki lbl kelimesini çıkartıyorum ve anlamlarına göre işlem yaptırıyorum
                {
                    case "CE":
                        lblSayi.Text = "0";
                        if (lblIslemler.Text == "") { Hesapla.Sonuc = 0; }//Eğer daha önce işlem yapılmamışsa CE tuşu sonucuda sıfırlıyor. Bunun nedeni sonuca bir kaç kez tıklanıpda arttırdığımızda CE ile sıfırlamamız kaldığımız yerden devam etmesine yol açıyor.
                        degisim = false;
                        break;
                    case "SadeceC":
                        lblSayi.Text = "0";
                        degisim = false;
                        lblIslemler.Text = "";
                        Hesapla.Sonuc = 0;
                        break;
                    case "Sil":
                        if (lblSayi.Text.Length > 0) { lblSayi.Text = lblSayi.Text.Substring(0, lblSayi.Text.Length - 1); }
                        if (lblSayi.Text.Length == 0) { lblSayi.Text = "0"; }
                        break;
                    case "Virgul":
                        if (lblSayi.Text.IndexOf(',') == -1 && lblSayi.Text.Length <= 12) { lblSayi.Text += ","; degisim = true; }//Eğer max karekter sayısından 1 az ise(1 az olmasının nedeni , den sonra rakam girilmesi gerekmesi) ve daha önce , koyulmamış ise , koy. degisim=true olayı ise bir işlem yapıldığını belirtir.
                        break;
                    case "ArtiEksi":
                        lblSayi.Text = (Convert.ToDouble(lblSayi.Text) * -1).ToString();
                        break;
                    case "Sonuc":
                        if (sonucTiklama == 0) { sonucTiklama++; sonIslem = lblIslemler.Text.Substring(lblIslemler.Text.Length - 2, 1);/*Tekrar sonuç'a tıklanırsa sonIslem'e göre işlem yapılacak*/ }
                        else
                        {
                            Hesapla.Sonuc = Convert.ToDouble(lblSayi.Text);
                            lblSayi.Text = sonSayi.ToString();
                            foreach (Control item in pnlSayilarVeIslemler.Controls)
                            {
                                Label label = (Label)item;
                                if (label.Text == sonIslem) { label.PerformLayout(); break; }
                            }
                        }
                        lblIslemler.Text = "";
                        degisim = true;
                        break;
                }
                #endregion

                #region değiştirme işlemine bağlı işlemler
                if (degisim)
                {//Değiştirme işlemine bağlı işlemler
                    string islem = "";
                    if (lblIslemler.Text.Length > 0) { islem = lblIslemler.Text.Substring(lblIslemler.Text.Length - 2, 1); }//Hangi işlemin yapılacağını belirliyorum. -2 almamın nedeni boşluk bırakmam.
                    else if (sonIslem != "") { islem = sonIslem; }
                    else { islem = lbl.Text; }

                    if (lbl.Name.Substring(3) != "Sil" && lbl.Name.Substring(3) != "Virgul")//Eğer silme işlemi değil ise işlem yap
                    {
                        switch (islem)//labellerimdeki lbl kelimesini çıkartıyorum ve anlamlarına göre işlem yaptırıyorum
                        {
                            case "+":
                                lblIslemler.Text += lblSayi.Text;
                                double toplam = Hesapla.ToplamaIslemi(Convert.ToDouble(lblSayi.Text));
                                sonSayi = Convert.ToDouble(lblSayi.Text);
                                lblSayi.Text = toplam.ToString();
                                degisim = false;
                                break;
                            case "-":
                                if (lbl.Name != "lblSonuc") { lblIslemler.Text += lblSayi.Text; }//Eğer tıklanan sonuç değil ise ekrana yazdırıyorum çünkü diğer türlü ekran'a yazdırrısam ekranda tek o olacağı için alttaki ilkmiş kontrolüne girer ve ters yönlü sonucunu verir.
                                double cikarma = Hesapla.CikarmaIslemi(Convert.ToDouble(lblSayi.Text));
                                if (lblIslemler.Text == lblSayi.Text) { cikarma *= -1; Hesapla.Sonuc += Convert.ToDouble(lblSayi.Text) * 2; }//ilk gelen sayıyı -1 ile çarpıyorum ki kullanıcıya - gözükmesin ardından Sonucumu eski değerin 2 katı ile çarpıyorum ki sonucum eski değere geri dönsün.
                                sonSayi = Convert.ToDouble(lblSayi.Text);
                                lblSayi.Text = cikarma.ToString();
                                degisim = false;
                                break;
                            case "÷":
                                if (lblIslemler.Text.Length <= 0 && lbl.Name != "lblSonuc") { Hesapla.Sonuc = (Convert.ToDouble(lblSayi.Text)); Hesapla.BolmeIslemi(1); }//daha önce işlem yapılmış mı diye kontrol ediyorum. Yapılmamış ise sonuc ile bölüncek işlemleri yer değiştiriyorum ki direk böldüğünde aynı değeri döndürsün.
                                else { Hesapla.BolmeIslemi(Convert.ToDouble(lblSayi.Text)); }//daha önce işlem yapılmış ise normal bölme işlemini yapıyorum.
                                sonSayi = Convert.ToDouble(lblSayi.Text);
                                lblIslemler.Text += lblSayi.Text;
                                double bolme = Hesapla.Sonuc;
                                lblSayi.Text = bolme.ToString();
                                degisim = false;
                                break;
                            case "x":
                                if (lblIslemler.Text.Length <= 0 && lbl.Name != "lblSonuc") { Hesapla.Sonuc = 1; }//daha önce işlem yapılmış mı diye kontrol ediyorum. Yapılmamış sonuc'a 1 değerini atıyorum çünkü çarmada 0 yutan eleman.
                                lblIslemler.Text += lblSayi.Text;
                                double carpma = Hesapla.CarpmaIslemi(Convert.ToDouble(lblSayi.Text));
                                sonSayi = Convert.ToDouble(lblSayi.Text);
                                lblSayi.Text = carpma.ToString();
                                degisim = false;
                                break;
                            default:
                                Hesapla.Sonuc = 0;
                                break;
                        }
                    }
                    if (lbl.Text == "x" || lbl.Text == "÷" || lbl.Text == "-" || lbl.Text == "+") { lblIslemler.Text += " " + lbl.Text + " "; }//işlemi ekrana yazdırıyorum.
                }
                if(lbl.Text == "x" || lbl.Text == "÷" || lbl.Text == "-" || lbl.Text == "+") { lblIslemler.Text = lblIslemler.Text.Substring(0, lblIslemler.Text.Length - 2) + lbl.Text + " "; }
                if (sonucTiklama > 0) { lblIslemler.Text = ""; }
                #endregion
            }
            catch
            {
                //Eğer buraya girdi ise kullanıcı lblSayi'da harf varken denemiştir. O an hiçbir işlem yapma.
            }
        }

        private void LblMatematikselIslemler_MouseClick(object sender, MouseEventArgs e)//Karekok alma gibi işlemler
        {
            try
            {
                Label lbl = (Label)sender;

                string islem = lbl.Name.Substring(3);//Yapılacak işlemin label namesinin lbl kısmını atıp ona göre işlem yapıyorum.
                double sonuc = 0;
                switch (islem)
                {
                    case "XKare":
                        sonuc = Hesapla.KareAlma(Convert.ToDouble(lblSayi.Text));
                        lblSayi.Text = sonuc.ToString();
                        break;
                    case "YuzdeHesaplama":
                        if(lblIslemler.Text.Length>0)
                            switch (lblIslemler.Text.Substring(lblIslemler.Text.Length - 2, 1))//Yapılacak işlemin işaretini alıyorum. -2 almamın nedeni boşluk bırakmam.
                            {
                                case "÷":
                                    sonuc = Hesapla.YuzdeIslemleri(Convert.ToDouble(lblSayi.Text), YUZDEHESAPLAMABICIMI.Bolme);
                                    break;
                                case "x":
                                    sonuc = Hesapla.YuzdeIslemleri(Convert.ToDouble(lblSayi.Text), YUZDEHESAPLAMABICIMI.Carpma);
                                    break;
                                case "-":
                                    sonuc = Hesapla.YuzdeIslemleri(Convert.ToDouble(lblSayi.Text), YUZDEHESAPLAMABICIMI.Cikarma);
                                    break;
                                case "+":
                                    sonuc = Hesapla.YuzdeIslemleri(Convert.ToDouble(lblSayi.Text), YUZDEHESAPLAMABICIMI.Toplama);
                                    break;
                            }

                        lblSayi.Text = sonuc.ToString();
                        break;
                    case "KareKok":
                        sonuc = Hesapla.KareKokAlma(Convert.ToDouble(lblSayi.Text));
                        lblSayi.Text = sonuc.ToString();
                        break;
                    case "BirBoluX":
                        if (Convert.ToDouble(lblSayi.Text) != 0)
                        {
                            sonuc = Hesapla.BirBoluX(Convert.ToDouble(lblSayi.Text));
                            lblSayi.Text = sonuc.ToString();
                        }
                        else { lblSayi.Text = "Sıfıra Bölünemez"; degisim = false; }
                        break;
                }
            }
            catch
            {
                //Eğer buraya girdi ise kullanıcı lblSayi'da harf varken denemiştir. O an hiçbir işlem yapma.
            }
        }

        private void LblSayilar_MouseClick(object sender, MouseEventArgs e)//Ekrana Sayilari yazdırma
        {
            Label lbl = (Label)sender;

            if (degisim && lblSayi.Text != "0")
            {
                if (lblSayi.Text.Length <= 13)
                {
                    lblSayi.Text += lbl.Text;
                    degisim = true;
                    sonucTiklama = 0;
                }
            }
            else
            {
                lblSayi.Text = "";
                if (lblSayi.Text.Length <= 13)
                {
                    lblSayi.Text += lbl.Text;
                    degisim = true;
                    sonucTiklama = 0;
                }
            }
        }

        private void LblControl_MouseClick(object sender, MouseEventArgs e)//Kapama kontrolleri vs.
        {
            Label lbl = (Label)sender;

            switch (lbl.Name.Substring(3))//label'in name'sinin lbl kısmını atıp işlem yaptırıyorum
            {
                case "Exit":
                    Application.Exit();
                    break;
                case "SimgeDurumunaGetir":
                    if (this.WindowState == FormWindowState.Normal) { this.WindowState = FormWindowState.Minimized; }//Normal boyda ise simge durumuna getir.
                    else { this.WindowState = FormWindowState.Normal; }//Aksi taktirde ise normal boyuta getir.
                    break;
            }
        }

        #region label arkaplan ve yazı rengi ayarları
        string eskiArkaPlanAdi = string.Empty;
        string eskiYaziRengi = string.Empty;

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl.Name != "lblSayi" && lbl.Name != "lblIslemler" && lbl.Name != "lblGecmis" && lbl.Name != "lblMod" && lbl.Name!="lblName")//Arka planı değişmiyecek labeller
            {
                lbl.BackColor = Color.FromName(eskiArkaPlanAdi);
                lbl.ForeColor = Color.FromName(eskiYaziRengi);
            }
        }

        private void Lbl_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl.Name != "lblSayi" && lbl.Name != "lblIslemler" && lbl.Name != "lblGecmis" && lbl.Name != "lblMod" && lbl.Name!= "lblName")//Arka planı değişmiyecek labeller
            {
                eskiArkaPlanAdi = lbl.BackColor.Name;//Eski arkaplanın adını alıyorum ki mouse ile üzerinden çıkınca eski rengine dönsün.
                eskiYaziRengi = lbl.ForeColor.Name;//Eski yazı renginin adını alıyorum ki mouse ile üzerinden çıkınca eski rengine dönsün.
                if (lbl.Name == "lblExit")
                {//Exit için renk kodu = 232; 30; 50
                    lbl.BackColor = Color.FromArgb(232, 30, 50);
                    lbl.ForeColor = Color.White;
                }
                else if (lbl.Name == "lblSonuc")
                {//Sonuç label'i için renk
                    lbl.BackColor = Color.DeepSkyBlue;
                    lbl.ForeColor = Color.White;
                }
                else
                {
                    lbl.BackColor = Color.Silver;
                }
            }
        }
        #endregion

        #region form taşıma işlemleri

        bool surukleme = false;
        Point offset;

        private void pnlControlBox_MouseUp(object sender, MouseEventArgs e)
        {
            surukleme = false;
        }

        private void pnlControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukleme)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void pnlControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            surukleme = true;
            offset = e.Location;
        }
        #endregion
        
    }
}
