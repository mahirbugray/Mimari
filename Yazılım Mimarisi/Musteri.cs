using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string MusteriTC { get; set; }
        public string Lokasyon { get; set; }
        public string TelefonNo { get; set; }
        public Konaklama konaklama { get; set; }
        public Ulasim ulasim { get; set; }
        public  Musteri()
        {
            this.konaklama = new Konaklama();
            this.ulasim = new Ulasim();
        }
    }
}
