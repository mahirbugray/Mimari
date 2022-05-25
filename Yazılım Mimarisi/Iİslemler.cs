using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Mimarisi
{
    public interface Iİslemler<islem>
    {
        void Create(islem islem);
        void Insert(islem islem);
        void Remove(islem islem);
        void Update(islem islem);
        List<islem> GetListAll();
        islem GetById(int id);
    }
}
