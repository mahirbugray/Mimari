using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi
{
    public class Ulasim
    {
        public int MusteriID { get; set; }
        public int UlasimId { get; set; }
        public int UlasimTuru { get; set; }
        public DateTime gidistarihi { get; set; }
        public DateTime donustarihi { get; set; }
        public string Kalkisnoktasi { get; set; }
        public string Varisnoktasi { get; set; }
        public int fiyat { get; set; }
    }
}
