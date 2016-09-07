using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDiary.Domain
{
    public interface IGnericRepository<T> where T : IDbEntity
    {
        void Add(T newEntity);
        void Update(T updatedEntity);
        T Get(int id);
        IQueryable<T> Get(string filter);
        void Delete(int id);
    }
}
