using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IViewStatDALRepo<ViewStatus>
    {
        bool ViewStatInsert(ViewStatus viewStat);

        bool ViewStatUpdate(ViewStatus viewStat);

        bool ViewStatDelete(ViewStatus viewStat);

        ViewStatus ViewStatGet(int id);

        ICollection<ViewStatus> ViewStatGetAll();
    }
}
