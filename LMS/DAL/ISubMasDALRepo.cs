using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ISubMasDALRepo<SubjectMaster>
    {
        bool SubMasInsert(SubjectMaster subMas);

        bool SubMasUpdate(SubjectMaster subMas);

        bool SubMasDelete(SubjectMaster subMas);

        SubjectMaster SubMasGet(int subid);

        ICollection<SubjectMaster> SubMasGetAll();
    }
}
