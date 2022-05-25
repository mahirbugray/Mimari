using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi
{
    public class Seyahat
    {
        private Abstract_Factory _soyut_Fabrika;
        private IUlasim _ulasim;
        private IKonaklama _konaklama;

        public Seyahat(Abstract_Factory soyut_Fabrika, Ulasim ulasim, Konaklama konaklama)
        {
            _soyut_Fabrika = soyut_Fabrika;
            _ulasim = _soyut_Fabrika.Ulasimolustur(ulasim);
            _konaklama = _soyut_Fabrika.Konaklamaolustur(konaklama);

        }
        public void GetAll(Ulasim ulasim, Konaklama konaklama)
        {
            _ulasim.Ulasimolustur(ulasim);
            _konaklama.Konaklamaolustur(konaklama);
        }
    }
}
