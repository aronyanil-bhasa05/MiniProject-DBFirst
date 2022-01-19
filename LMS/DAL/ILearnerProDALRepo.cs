using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ILearnerProDALRepo<LearnerProfile>
    {
        bool LearnerProInsert(LearnerProfile learnerPro);

        bool LearnerProUpdate(LearnerProfile learnerPro);

        bool LearnerProDelete(LearnerProfile learnerPro);

        LearnerProfile LearnerProGet(String email);

        ICollection<LearnerProfile> LearnerProGetAll();
    }
}
