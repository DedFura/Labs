using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public interface IRecord
    {
        IAccount Account { get; }
        IEmployee Employee { get; }
        DateTime DateTime { get; }
        string Comment { get; }
    }
}
