using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public interface IEmployee
    {
        string FullName {get; set;}
        Function Function { get; set; }
        Department Departament { get; set; }
       
    }

    

   
}
