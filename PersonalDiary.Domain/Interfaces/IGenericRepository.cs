using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDiary.Domain
{
    public interface IGenericRepository<T> where T : IDbEntity
    {
        void Add(T newEntity);
        void Update(T updatedEntity);
        T Get(int id);
        IQueryable<T> Get(string filter);
        void Delete(int id);
        IQueryable<T> Filter(string searchTerm);
        IQueryable<T> Filter(Expression<Func<T, bool>> expression);
    }
}
