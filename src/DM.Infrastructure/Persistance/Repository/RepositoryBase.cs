using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DM.Infrastructure.Persistance.Repository
{
    abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DmContext _context { get; set; }
        public RepositoryBase(DmContext context)
        {
            _context = context;
        }
        public IQueryable<T> FindAll() => _context.Set<T>().AsNoTracking();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
            _context.Set<T>().Where(expression).AsNoTracking();
        public void Create(T entity) => _context.Set<T>().Add(entity);
        public void Update(T entity) => _context.Set<T>().Update(entity);
        public void Delete(T entity) => _context.Set<T>().Remove(entity);
    }
}
