using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminRegDALRepo : IAdminRegDALRepo<AdminRegistration>
    {
        public bool AdminRegDelete(AdminRegistration adminReg)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.AdminRegistrations.Where(x => x.Email == adminReg.Email).FirstOrDefault();
                    if (user != null)
                    {
                        dbContext.ADMINREG_DELETE(adminReg.Email);
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

        public ICollection<AdminRegistration> AdminRegGetAll()
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ADMINREG_ALL().ToList();
                    
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

        public AdminRegistration AdminRegGetUser(String email)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.AdminRegistrations.Where(x => x.Email == email).FirstOrDefault();
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

        public bool AdminRegInsert(AdminRegistration adminReg)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    dbContext.ADMINREG_INSERT(adminReg.Email, adminReg.FirstName, adminReg.LastName, adminReg.Password);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AdminRegUpdate(AdminRegistration adminReg)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.AdminRegistrations.Where(x => x.Email == adminReg.Email).FirstOrDefault();
                    if (user != null)
                    {
                        String newEmail = adminReg.Email;
                        String newFirstName = adminReg.FirstName;
                        String newLastName = adminReg.LastName;
                        String newPassword = adminReg.Password;

                        dbContext.ADMINREG_UPDATE(newEmail, newFirstName, newLastName, newPassword);
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
