using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijitalSaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaatiBul()
        {
            char[] SureHaneleri = DateTime.Now.ToLongTimeString().ToString().Replace(":","").ToCharArray();//Saati sadece rakamlar halinde diziye attım
            string[] rakamlar = new string[6];//char çevirirken ascii kodunu vermemesi için string bir dizi oluşturdum.

            int j = 0;//diziye atama sayacı
            foreach(char rakam in SureHaneleri)//süreyi string dizime atadım
            {
                rakamlar[j] = rakam.ToString();
                j++;
            }
            
            DijitalSayilar Sayilar = new DijitalSayilar();

            byte panelSayisi = 6;//panel sayacı
            foreach (Control cont in this.Controls)
            {
                Panel pnl = (Panel)cont;
                if(pnl.Name!= "pnlIkiNokta")
                {
                    pnl.Refresh();
                    Sayilar.SayiyaGit(Convert.ToByte(rakamlar[panelSayisi - 1]), pnl);//sondaki rakamdan başlamamın nedeni panelleri sondan başlaması.
                    panelSayisi--;
                }
            }
        }

        private void btnCiz_Click(object sender, EventArgs e)
        {
            DijitalSayilar sayilar = new DijitalSayilar();
            Random rr = new Random();
            int sayi = rr.Next(0, 10);
            pnlSaat0.Refresh();
            sayilar.SayiyaGit(Convert.ToByte(sayi),pnlSaat0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SaatiBul();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SaatiBul();
        }
    }
}
