using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IAdminRegDALRepo <AdminRegistration>
    {
        bool AdminRegInsert(AdminRegistration adminReg);

        bool AdminRegDelete(AdminRegistration adminReg);

        bool AdminRegUpdate(AdminRegistration adminReg);

        AdminRegistration AdminRegGetUser(String email);

        ICollection<AdminRegistration> AdminRegGetAll();

    }
}
