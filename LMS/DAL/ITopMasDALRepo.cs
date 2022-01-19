using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ITopMasDALRepo<TopicMaster>
    {

        bool TopMasInsert(TopicMaster topMas);

        bool TopMasUpdate(TopicMaster topMas);

        bool TopMasDelete(TopicMaster topMas);

        TopicMaster TopMasGet(String tname);

        ICollection<TopicMaster> TopMasGetAll();

    }
}
