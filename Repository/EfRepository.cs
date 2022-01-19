using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Data;

namespace WebApiCore.Repository
{
    public class EfRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public EfRepository(DatabaseContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public TEntity Add(TEntity entity)
        {
            var result = new TEntity();
            _dbSet.Add(entity);
            _context.SaveChanges();
            result = entity;
            return result;
        }

        public TEntity Delete(TEntity entity)
        {
            var result = new TEntity();
            _dbSet.Remove(entity);
            _context.SaveChanges();
            result = entity;
            return result;
        }

        public List<TEntity> GetAll()
        {
            var result = new List<TEntity>();
            var list = _dbSet.ToList();
            if (list != null)
                result = list;
            else
                result = null;
            return result;

        }

        public TEntity GetById(int id)
        {
            var result = new TEntity();
            result = _dbSet.Find(id);
            return result;
        }

        public TEntity UpdateById(TEntity entity, int id)
        {
            var result = new TEntity();
            var model = _dbSet.Find(id);
            if (model == null)
                return null;
            
            var response = _context.Entry(model);
            response.State = EntityState.Modified;
            _context.SaveChanges();
            result = response.Entity;
            return result;


        }
    }
}
