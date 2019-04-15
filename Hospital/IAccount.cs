using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public interface IAccount
    {
        string Name { get; }
        string Password { get; }
        ICalendar GetCalendar();
        bool IsAdmin { get; }
    }

    public interface ICalendar
    {
        IEnumerable<IRecord> Records { get; }
    }

    public interface IRecord
    {
        IAccount Account { get; }
        IEmployee Employee { get; }
        DateTime DateTime { get; }
        string Comment { get; }
    }
}
