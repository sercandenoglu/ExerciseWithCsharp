using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogrusalSifrelemeAffineChipper
{
    class DogrusalSifreCoz
    {
        public char[] sifreliMetin;//Çözülecek metin
        public int aAnahtari;//a Anahtarının değeri
        public int bAnahtari;//b Anahtarının değeri

       public string coz()
        {
            char[] alfabe = "abcçdefgğhıijklmnoöprsştuüvyzqwxABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZQWX0123456789*-_=?)(/&%+^!'<>£#$|".ToCharArray();//Normal alfabemiz
            char[] yeniAlfabe = "abcçdefgğhıijklmnoöprsştuüvyzqwxABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZQWX0123456789*-_=?)(/&%+^!'<>£#$|".ToCharArray();//Şifrelenmiş alfabe
            string Metin = "";// çözülmüş metin
           
            
            //formül y = ax+b ----> şifreleme formülü
            
           
                for (int i = 0; i < alfabe.Length; i++)
                {
                    //Burada normal alfabemizi şifrelenmiş şekilde yeniAlfabe'ye atıyoruz
                    yeniAlfabe[i] = alfabe[(aAnahtari * i + bAnahtari) % alfabe.Length]; ;
                 }
                for (int i = 0; i < sifreliMetin.Length; i++)
                {
                    int y = Convert.ToInt32(Array.IndexOf(yeniAlfabe,sifreliMetin[i]));//Şifrelenmiş alfabedeki karekterin indexini buluyoruz

                if (y != -1)//eğer karekter bulunmuş ise,
                {
                   
                    Metin += alfabe[y];//Metin değişkenine karekterimizi ekliyoruz
                }
                else//eğer karekter bulunamamış ise,
                {
                    Metin +=sifreliMetin[i];//harf olmadığını anlamına geliyor ve direk metine ekliyoruz
                }
                }
                return Metin;
                
        }
    }
}