using PersonalDiary.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SQLDataProvider
{
    public class GenericRepositorySQLImpl<T> : IGnericRepository<T> where T : class, IDbEntity                                                                    
    {
        private PersonalDiaryDbContext _dbContext = null;
        private IDbSet<T> entites;

        public GenericRepositorySQLImpl(PersonalDiaryDbContext _context)
        {
            _dbContext = _context;
            entites = _dbContext.Set<T>();
        }

        void IGnericRepository<T>.Add(T newEntity)
        {
            _dbContext.Set(typeof(T)).Add(newEntity);
        }

        void IGnericRepository<T>.Update(T updatedEntity)
        {
            _dbContext.Entry(updatedEntity).State = EntityState.Modified;
        }

        T IGnericRepository<T>.Get(int id)
        {
            var result = entites.Find(id);
            return result;
        }

        IQueryable<T> IGnericRepository<T>.Get(string filter)
        {
            return entites.AsQueryable();
        }

        void IGnericRepository<T>.Delete(int id)
        {
            var entityToDelete = entites.Find(id);
            if (entityToDelete == null)
            {
                throw new Exception("Record not found.");
            }
            _dbContext.Entry(entityToDelete).State = EntityState.Deleted;
        }
    }
}
