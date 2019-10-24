using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //sonradan ekledık. image kullanmak ıcın
using System.IO;//sonradan ekledık. MemoryStream kullanmak ıcın

namespace OgrenciBilgiSistemi.Fonksiyonlar
{
    class Resimler
    {
        public byte[] ResimYukleme(Image resim)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                resim.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public Image ResimGetirme(byte[] gelenByteArray)
        {
            using (MemoryStream ms = new MemoryStream(gelenByteArray))
            {
                Image resim = Image.FromStream(ms);
                return resim;
            }
        }
    }
}
