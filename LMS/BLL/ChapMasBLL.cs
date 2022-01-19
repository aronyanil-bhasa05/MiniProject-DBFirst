using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ChapMasBLL
    {
        ChapMasDALRepo chapMasDAL = new ChapMasDALRepo();        
        public bool ChapMasDelete(ChapterMaster ChapMas)
        {
            return chapMasDAL.ChapMasDelete(ChapMas);
        }

        public ICollection<ChapterMaster> ChapMasGetAll()
        {
            return chapMasDAL.ChapMasGetAll();
        }

        public ChapterMaster ChapMasGet(String ChapterName)
        {
            return chapMasDAL.ChapMasGet(ChapterName);
        }

        public bool ChapMasInsert(ChapterMaster ChapMas)
        {
            return chapMasDAL.ChapMasInsert(ChapMas);
        }

        public bool ChapMasUpdate(ChapterMaster ChapMas)
        {
            return chapMasDAL.ChapMasUpdate(ChapMas);
        }
    }
}
