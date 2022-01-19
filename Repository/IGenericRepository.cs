using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Repository
{
    public interface IGenericRepository<TEntity> where TEntity:class, new()
    {
        // C-R-U-D OP

        TEntity Add(TEntity entity);

        TEntity Delete(TEntity entity);

        TEntity UpdateById(TEntity entity,int id);

        TEntity GetById(int id);

        List<TEntity> GetAll();

    }
}
