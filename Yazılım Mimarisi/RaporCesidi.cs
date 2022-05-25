using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi
{
    public abstract class RaporCesidi
    {
        public abstract void XmlOlustur();
        public abstract void HtmlOlustur();
        public abstract void JsonOlustur();
        public abstract RaporOlustur RaporOlustur();
    }
}
