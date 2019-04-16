using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public interface IRegistrationService
    {
        void CreateRecord(IRecord record);
        void DeleteRecord(IRecord record);

        IRecord[] GetRecords();
        IRecord[] GetRecords(IEmployee employee);
        IRecord[] GetRecords(IAccount account);
    }
}
