using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class AdminRegBLL
    {
        AdminRegDALRepo adminRegDAL = new AdminRegDALRepo();

        public bool AdminRegDelete(AdminRegistration adminReg)
        {
            return adminRegDAL.AdminRegDelete(adminReg);
        }

        public ICollection<AdminRegistration> AdminRegGetAll()
        {
            return adminRegDAL.AdminRegGetAll();
        }

        public AdminRegistration AdminRegGetUser(String email)
        {
            return adminRegDAL.AdminRegGetUser(email);
        }

        public bool AdminRegInsert(AdminRegistration adminReg)
        {
           return adminRegDAL.AdminRegInsert(adminReg);
        }

        public bool AdminRegUpdate(AdminRegistration adminReg)
        {
            return adminRegDAL.AdminRegUpdate(adminReg);
        }
    }
}
