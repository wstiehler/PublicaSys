using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicaSys.Domain.Interfaces
{
    public interface IService<T>
    {
        T Get(int id);
        List<T> GetAll();
        string Post(T model);
        string Put(T Model);
        string Delete(int id);
    }
}
