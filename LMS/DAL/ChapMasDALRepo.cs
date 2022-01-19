using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChapMasDALRepo : IChapMasDALRepo<ChapterMaster>
    {
        public bool ChapMasDelete(ChapterMaster ChapMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ChapterMasters.Where(x => x.ChapterName == ChapMas.ChapterName).FirstOrDefault();
                    if (user != null)
                    {
                        dbContext.CHAPTERMASTER_DELETE(ChapMas.ChapterName);
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

        public ICollection<ChapterMaster> ChapMasGetAll()
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.CHAPTERMASTER_ALL().ToList();
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

        public ChapterMaster ChapMasGet(String ChapterName)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ChapterMasters.Where(x => x.ChapterName == ChapterName).FirstOrDefault();
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

        public bool ChapMasInsert(ChapterMaster ChapMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    dbContext.CHAPTERMASTER_INSERT(ChapMas.ChapterName, ChapMas.SubjectID, ChapMas.LastUpdatedOn);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ChapMasUpdate(ChapterMaster ChapMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ChapterMasters.Where(x => x.ChapterName == ChapMas.ChapterName).FirstOrDefault();
                    if (user != null)
                    {
                        String newChapterName = ChapMas.ChapterName;
                        int newSubjectId = ChapMas.SubjectID;
                        var newLastUpdatedOn = ChapMas.LastUpdatedOn;

                        dbContext.CHAPTERMASTER_UPDATE(newChapterName, newSubjectId, newLastUpdatedOn);
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

