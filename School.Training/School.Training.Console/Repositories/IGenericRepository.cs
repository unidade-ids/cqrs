using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Training.Console.Repositories
{
    public interface IGenericRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task Delete(int id);
        Task<TEntity> GetById(int id);
        Task<int> SaveRange(IEnumerable<TEntity> entities);
        Task Update(TEntity entity);
        Task Save(TEntity entity);
    }
}
