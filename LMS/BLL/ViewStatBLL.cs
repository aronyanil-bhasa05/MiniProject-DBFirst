using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ViewStatBLL
    {
        ViewStatDALRepo viewStatDAL = new ViewStatDALRepo();

        public bool ViewStatDelete(ViewStatus viewStat)
        {
            return viewStatDAL.ViewStatDelete(viewStat);
        }

        public ViewStatus ViewStatGet(int id)
        {
            return viewStatDAL.ViewStatGet(id);
        }

        public ICollection<ViewStatus> ViewStatGetAll()
        {
            return viewStatDAL.ViewStatGetAll();
        }

        public bool ViewStatInsert(ViewStatus viewStat)
        {
            return viewStatDAL.ViewStatInsert(viewStat);
        }

        public bool ViewStatUpdate(ViewStatus viewStat)
        {
            return viewStatDAL.ViewStatUpdate(viewStat);
        }
    }
}
