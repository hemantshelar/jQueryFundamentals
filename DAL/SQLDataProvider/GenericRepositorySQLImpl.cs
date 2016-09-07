using PersonalDiary.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SQLDataProvider
{
    public class GenericRepositorySQLImpl<T> : IGenericRepository<T> where T : class, IDbEntity                                                                    
    {
        private PersonalDiaryDbContext _dbContext = null;
        private IDbSet<T> entites;

        public GenericRepositorySQLImpl(PersonalDiaryDbContext _context)
        {
            _dbContext = _context;
            entites = _dbContext.Set<T>();
        }

        void IGenericRepository<T>.Add(T newEntity)
        {
            _dbContext.Set(typeof(T)).Add(newEntity);
        }

        void IGenericRepository<T>.Update(T updatedEntity)
        {
            _dbContext.Entry(updatedEntity).State = EntityState.Modified;
        }

        T IGenericRepository<T>.Get(int id)
        {
            var result = entites.Find(id);
            return result;
        }

        IQueryable<T> IGenericRepository<T>.Get(string filter)
        {
            return entites.AsQueryable();
        }

        void IGenericRepository<T>.Delete(int id)
        {
            var entityToDelete = entites.Find(id);
            if (entityToDelete == null)
            {
                throw new Exception("Record not found.");
            }
            _dbContext.Entry(entityToDelete).State = EntityState.Deleted;
        }


        IQueryable<T> IGenericRepository<T>.Filter(string searchTerm)
        {

            throw new NotImplementedException("Method not implemented yet!");
            IQueryable<T> result = null;
            try
            {
                var _properties = typeof(T).GetProperties().Where(p => p.PropertyType == typeof(string)).ToList();
                foreach (var item in _properties)
                {
                    string i = item.ToString();
                    Console.WriteLine(item.ToString());
                }


                Expression<Func<T, bool>> ex = (T  i) => i == null;
                //Expression<Func<int, bool>> test = Expression.
                Expression<Func<int, int>> expr = (x) => x + 1;
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }


        IQueryable<T> IGenericRepository<T>.Filter(Expression<Func<T, bool>> expression)
        {
            return entites.Where(expression).AsQueryable();
        }
    }
}
