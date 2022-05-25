using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi
{
    public abstract class Abstract_Factory
    {
        public abstract IUlasim Ulasimolustur(Ulasim u);
        public abstract IKonaklama Konaklamaolustur(Konaklama k);
    }
}
