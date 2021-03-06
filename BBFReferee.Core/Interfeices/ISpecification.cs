using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Core.Interfeices
{
    public interface ISpecification<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> Applay(IQueryable<TEntity> query);
    }
}
