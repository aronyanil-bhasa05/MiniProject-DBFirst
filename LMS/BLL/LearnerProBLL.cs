using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LearnerProBLL
    {
        LearnerProDALRepo learnerProDAL = new LearnerProDALRepo();

        public bool LearnerProDelete(LearnerProfile learnerPro)
        {
            return learnerProDAL.LearnerProDelete(learnerPro);
        }

        public LearnerProfile LearnerProGet(String email)
        {
            return learnerProDAL.LearnerProGet(email);
        }

        public ICollection<LearnerProfile> LearnerProGetAll()
        {
            return learnerProDAL.LearnerProGetAll();
        }

        public bool LearnerProInsert(LearnerProfile learnerPro)
        {
            return learnerProDAL.LearnerProInsert(learnerPro);
        }

        public bool LearnerProUpdate(LearnerProfile learnerPro)
        {
            return learnerProDAL.LearnerProUpdate(learnerPro);
        }
    }
}
