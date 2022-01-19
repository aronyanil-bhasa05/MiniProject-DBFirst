using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LearnerProDALRepo : ILearnerProDALRepo<LearnerProfile>
    {
        public bool LearnerProDelete(LearnerProfile learnerPro)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.LearnerProfiles.Where(x => x.Email == learnerPro.Email).FirstOrDefault();
                    if (user != null)
                    {
                        dbContext.LEARNPROF_DELETE(learnerPro.Email);
                        dbContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public LearnerProfile LearnerProGet(String email)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.LearnerProfiles.Where(x => x.Email == email).FirstOrDefault();
                    if (user != null)
                    {
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public ICollection<LearnerProfile> LearnerProGetAll()
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.LEARNPROF_ALL().ToList();
                    if (user != null)
                    {
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool LearnerProInsert(LearnerProfile learnerPro)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    dbContext.LEARNPROF_INSERT(learnerPro.Email, learnerPro.FirstName, learnerPro.LastName, learnerPro.Dob, learnerPro.Gender, learnerPro.Remark, learnerPro.Password, learnerPro.Status);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool LearnerProUpdate(LearnerProfile learnerPro)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.LearnerProfiles.Where(x => x.Email == learnerPro.Email).FirstOrDefault();
                    if (user != null)
                    {
                        String newEmail = learnerPro.Email;
                        String newFirstName = learnerPro.FirstName;
                        String newLastName = learnerPro.LastName;
                        var newDOB = learnerPro.Dob;
                        String newGender = learnerPro.Gender;
                        String newRemarks = learnerPro.Remark;
                        String newPassword = learnerPro.Password;
                        String newStatus = learnerPro.Status;

                        dbContext.LEARNPROF_UPDATE(newEmail, newFirstName, newLastName, newDOB, newGender, newRemarks, newPassword, newStatus);
                        dbContext.SaveChanges();
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
