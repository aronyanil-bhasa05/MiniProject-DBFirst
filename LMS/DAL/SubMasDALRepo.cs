using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SubMasDALRepo : ISubMasDALRepo<SubjectMaster>
    {
        public bool SubMasDelete(SubjectMaster subMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.SubjectMasters.Where(x => x.SubjectID == subMas.SubjectID).FirstOrDefault();
                    if (user != null)
                    {
                        dbContext.SUBMASTER_DELETE(subMas.SubjectID);
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

        public SubjectMaster SubMasGet(int subid)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.SubjectMasters.Where(x => x.SubjectID == subid).FirstOrDefault();
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

        public ICollection<SubjectMaster> SubMasGetAll()
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.SUBMASTER_ALL().ToList();
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

        public bool SubMasInsert(SubjectMaster subMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    dbContext.SUBMASTER_INSERT(subMas.SubjectID, subMas.SubjectName, subMas.LastUpdatedOn, subMas.Domain);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SubMasUpdate(SubjectMaster subMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.SubjectMasters.Where(x => x.SubjectID == subMas.SubjectID).FirstOrDefault();
                    if (user != null)
                    {
                        int newSubjectId = subMas.SubjectID;
                        String newSubjectName = subMas.SubjectName;
                        DateTime newLastUpdatedOn = subMas.LastUpdatedOn;
                        String newDomain = subMas.Domain;

                        dbContext.SUBMASTER_UPDATE(newSubjectId, newSubjectName, newLastUpdatedOn, newDomain);
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
