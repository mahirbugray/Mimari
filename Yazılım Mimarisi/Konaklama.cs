using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi
{
    public class Konaklama
    {
        public int MusteriID { get; set; }
        public int KonaklamaId { get; set; }
        public int Kapasite { get; set; }
        public int fiyat { get; set; }
        public string Konum { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
    }
}
