using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ViewStatDALRepo : IViewStatDALRepo <ViewStatus>
    {
        public bool ViewStatDelete(ViewStatus viewStat)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ViewStatus1.Where(x => x.ID == viewStat.ID).FirstOrDefault();
                    if (user != null)
                    {
                        dbContext.VIEWSTATUS_DELETE(viewStat.ID);
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

        public ViewStatus ViewStatGet(int id)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ViewStatus1.Where(x => x.ID == id).FirstOrDefault();
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

        public ICollection<ViewStatus> ViewStatGetAll()
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.VIEWSTATUS_ALL().ToList();
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

        public bool ViewStatInsert(ViewStatus viewStat)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    dbContext.VIEWSTATUS_INSERT(viewStat.ID, viewStat.LearnerEmailID, viewStat.SubjectID, viewStat.ChapterName, viewStat.TopicName, viewStat.ViewTime, viewStat.Comment);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ViewStatUpdate(ViewStatus viewStat)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ViewStatus1.Where(x => x.ID == viewStat.ID).FirstOrDefault();
                    if (user != null)
                    {
                        int newID = viewStat.ID;
                        String newLearnerEmailId = viewStat.LearnerEmailID;
                        int newSubjectId = viewStat.SubjectID;
                        String newChapterName = viewStat.ChapterName;
                        String newTopicName = viewStat.TopicName;
                        var newViewTime = viewStat.ViewTime;
                        String newComments = viewStat.Comment;

                        dbContext.VIEWSTATUS_UPDATE(newID, newLearnerEmailId, newSubjectId, newChapterName, newTopicName, newViewTime, newComments);
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
