using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.Borders.Repository
{
    public interface IRepository<TEntity> 
    {
        IEnumerable<TEntity> GetAll();
    }
}
