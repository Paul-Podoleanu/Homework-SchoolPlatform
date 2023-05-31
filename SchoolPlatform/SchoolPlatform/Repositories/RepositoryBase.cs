using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolPlatform.Model;

namespace SchoolPlatform.Repositories
{
    public class RepositoryBase<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly SchoolContext _context;

        public RepositoryBase(SchoolContext schoolContext)
        {
            _context = schoolContext;
            _dbSet = _context.Set<T>();
        }

        public List<T> GetAll()
        {
            return GetRecords().ToList();
        }

        protected IQueryable<T> GetRecords()
        {
            return _dbSet.AsQueryable<T>();
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
