using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MlgStore.Bussiness.Contracts
{
    public interface ISizeBs
    {
        List<Sizes> GetSizes(Expression<Func<Sizes,bool>> filter = null, params string[] includeList);
    }
}
