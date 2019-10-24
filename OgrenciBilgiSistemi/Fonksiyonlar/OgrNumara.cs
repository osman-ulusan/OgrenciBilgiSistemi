using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Fonksiyonlar
{
    class OgrNumara
    {
        ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
        public string OgrenciNumara()
        {
            try
            {
                int numara = int.Parse((from s in db.tblOgrencis orderby s.Id descending select s).First().OgrNumara); // gelecek değeri double a çevirdik parse ile
                numara++;
                string num = numara.ToString().PadLeft(7, '0'); // totelde 7 hane olacak , eksıkse 0 ekleyecek eksıgı kadar
                return num;
            }
            catch (Exception)
            {

                return "1000000";
            }
        }
    }
}
