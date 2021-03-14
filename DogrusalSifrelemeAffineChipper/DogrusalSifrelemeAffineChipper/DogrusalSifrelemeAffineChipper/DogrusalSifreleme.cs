using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogrusalSifrelemeAffineChipper
{
    public class DogrusalSifreleme
    { 
        public char[] metin;//şifrelenecek metin.
        public int aAnahtari;//a Anahtarının değeri.
        public int bAnahtari;//b Anahtarının değeri.

        public string Sifrele()
        {
            char[] alfabe = "abcçdefgğhıijklmnoöprsştuüvyzqwxABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZQWX0123456789*-_=?)(/&%+^!'<>£#$|,;é".ToCharArray();
            string sifreliMetin = "";

            //formül y = ax+b
            for (int i = 0; i < metin.Length; i++)
            {
                int x = Convert.ToInt32(Array.IndexOf(alfabe, metin[i]));//alfabede karekterin indexini buluyorum.

                if (x != -1)//eğer karekter bulunmuş ise,
                {
                   
                    int y = (aAnahtari * x + bAnahtari) % alfabe.Length;
                    //formülü uygulayıp 29'a modunu alıyorum. 29'a modunu almamdaki amaç alfabedeki karşılığını bulmak.
                    sifreliMetin += alfabe[y];//şifreli metin değişkenine karekterimi ekliyorum.
                }
                else//eğer karekter bulunamamış ise,
                {
                    sifreliMetin += metin[i];//harf olmadığını anlamına geliyor ve direk metine ekliyorum.
                }
            }
            return sifreliMetin;//şifreli metini döndürüyorum.
        }
    }

}
