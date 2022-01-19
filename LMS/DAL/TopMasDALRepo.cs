using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TopMasDALRepo : ITopMasDALRepo<TopicMaster>
    {
        public bool TopMasDelete(TopicMaster topMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.TopicMasters.Where(x => x.TopicName == topMas.TopicName).FirstOrDefault();
                    if (user != null)
                    {
                        dbContext.TOPICMASTER_DELETE(topMas.TopicName);
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

        public TopicMaster TopMasGet(String tname)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.TopicMasters.Where(x => x.TopicName == tname).FirstOrDefault();
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

        public ICollection<TopicMaster> TopMasGetAll()
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.TOPICMASTER_ALL().ToList();
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

        public bool TopMasInsert(TopicMaster topMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    dbContext.TOPICMASTER_INSERT(topMas.TopicName, topMas.SubjectID, topMas.ChapterName, topMas.LastUpdatedOn, topMas.ContentURL);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool TopMasUpdate(TopicMaster topMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.TopicMasters.Where(x => x.TopicName == topMas.TopicName).FirstOrDefault();
                    if (user != null)
                    {
                        String newTopicName = topMas.TopicName;
                        int newSubjectId = topMas.SubjectID;
                        String newChapterName = topMas.ChapterName;
                        DateTime newLastUpdateOn = topMas.LastUpdatedOn;
                        String newContentUrl = topMas.ContentURL;

                        dbContext.TOPICMASTER_UPDATE(newTopicName, newSubjectId, newChapterName, newLastUpdateOn, newContentUrl);
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
