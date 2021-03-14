using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DogrusalSifrelemeAffineChipper
{
    public partial class DogrusalSifreleForm : Form
    {
        public DogrusalSifreleForm()
        {
            InitializeComponent();

            foreach (Control control in pnl1.Controls)//pnlControl'de bulunan textbox'ların KeyPress eventine giriyorum.
            {
                if(control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.KeyPress += Txt_KeyPress;
                }
            }
            foreach (Control control in pnl2.Controls)//pnlControl'de bulunan textbox'ların KeyPress eventine giriyorum.
            {
                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.KeyPress += Txt_KeyPress;
                }
            }
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)//textbox'lara harf girişini engelliyorum.
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private int DogrusalSifrele()
        {
            if (txtAAnahtari.TextLength <= 0 || txtBAnahtari.TextLength <= 0)//eğer textbox'lara değer girilmemişse -1 değerini döndürüyorum.
                return -1;

            DogrusalSifreleme Dsifrele = new DogrusalSifreleme();

            Dsifrele.metin = richTextBoxMetin.Text.ToCharArray();//şifrelenecek metin.
            Dsifrele.aAnahtari = Convert.ToInt32(txtAAnahtari.Text);//a Anahtarının değeri.
            Dsifrele.bAnahtari = Convert.ToInt32(txtBAnahtari.Text);//b Anahtarının değeri.
            richTextBoxSifreliMetin.Text = Dsifrele.Sifrele();//Şifreleme fonksiyonunu çağırıyorum.
            return 0;//0 değerini döndürmem herhangi bir hata olmadını göstermek amacıyla.
        }

      private int DogrusalCSifreCoz()
        {
            if (txtA.TextLength <= 0 || txtB.TextLength <= 0)//eğer textbox'lara değer girilmemişse -1 değerini döndürüyorum.
            return -1;
            DogrusalSifreCoz dsifrecoz = new DogrusalSifreCoz();
            dsifrecoz.sifreliMetin = rtxtsifreli.Text.ToCharArray();
            dsifrecoz.aAnahtari = Convert.ToInt32(txtA.Text);
            dsifrecoz.bAnahtari = Convert.ToInt32(txtB.Text);
            rtxtcozulu.Text = dsifrecoz.coz();
            return 0;
        }
        private void btnSifrele_Click(object sender, EventArgs e)
        {
            if (DogrusalSifrele() == -1)
                MessageBox.Show("A veya B anahtarını boş bıraktınız");
        }

        private void btnCoz_Click(object sender, EventArgs e)
        {
            if (DogrusalCSifreCoz() == -1)
            {
                MessageBox.Show("A veya B anahtarını boş bıraktınız");
            }
        }
    }
}