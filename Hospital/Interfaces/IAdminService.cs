using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public interface IAdminService
    {
        void CreateEmployee(IEmployee employee);
        IEmployee[] GetEmployees();
    }
}
