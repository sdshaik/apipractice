using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObjects.DataRepository
{
    public interface IDataRepositry<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Getbyid(int id);
        void Add(TEntity entity);
        void Update(TEntity entity,TEntity entity1);
        void Delete(TEntity entity);
    }
}
