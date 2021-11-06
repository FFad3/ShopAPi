using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public interface IUniversalInterface<T> where T:IEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T ob);
        void Update(T ob);
        void Delete(T ob);
    }
}
