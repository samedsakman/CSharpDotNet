using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.DataAccess
{
    interface IDataService<TEntity> where TEntity : class, IEntityService, new()
    {
        public void Add(TEntity entity);
        public void Delete(TEntity entity);
        public void Update(TEntity entity);

    }
}
