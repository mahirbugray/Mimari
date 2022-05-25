using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi
{
    public class Ucak_Cadir_Fabrika:Abstract_Factory
    {
        public override IKonaklama Konaklamaolustur(Konaklama konaklama)
        {
            return new Cadir();
        }

        public override IUlasim Ulasimolustur(Ulasim ulasim)
        {
            return new Ucak();
        }
    }
}
