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
        IList<string> Includes { get; }

        IQueryable<TEntity> Apply(IQueryable<TEntity> query);
    }
}
