using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class SubMasBLL
    {
        SubMasDALRepo subMasDAL = new SubMasDALRepo();

        public bool SubMasDelete(SubjectMaster subMas)
        {
            return subMasDAL.SubMasDelete(subMas);
        }

        public SubjectMaster SubMasGet(int subid)
        {
            return subMasDAL.SubMasGet(subid);
        }

        public ICollection<SubjectMaster> SubMasGetAll()
        {
            return subMasDAL.SubMasGetAll();
        }

        public bool SubMasInsert(SubjectMaster subMas)
        {
            return subMasDAL.SubMasInsert(subMas);
        }

        public bool SubMasUpdate(SubjectMaster subMas)
        {
            return subMasDAL.SubMasUpdate(subMas);
        }
    }
}
