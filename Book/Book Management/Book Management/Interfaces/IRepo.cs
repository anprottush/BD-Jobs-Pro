using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management.Interfaces
{
    public interface IRepo<TClass,TId,TResult>
    {
        List<TClass> Get();
        TClass Get(TId id);
        TResult Insert(TClass obj);
        bool Delete(TId id);
        TResult Update(TClass obj);

    }
}
