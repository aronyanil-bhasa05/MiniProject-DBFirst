using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TopMasBLL
    {
        TopMasDALRepo topMasDAL = new TopMasDALRepo();

        public bool TopMasDelete(TopicMaster topMas)
        {
           return topMasDAL.TopMasDelete(topMas);
        }

        public TopicMaster TopMasGet(String tname)
        {
            return topMasDAL.TopMasGet(tname);
        }

        public ICollection<TopicMaster> TopMasGetAll()
        {
           return topMasDAL.TopMasGetAll();
        }

        public bool TopMasInsert(TopicMaster topMas)
        {
            return topMasDAL.TopMasInsert(topMas);
        }

        public bool TopMasUpdate(TopicMaster topMas)
        {
            return topMasDAL.TopMasUpdate(topMas);
        }
    }
}
