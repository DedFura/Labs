using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public interface IRepository<T> where T: IEntity 
    {
        T GetById(long Id);
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);



    }
}
