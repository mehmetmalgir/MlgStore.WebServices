using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MlgStore.Bussiness.Contracts
{
    public interface ICategoryBs
    {
        List<Categories> GetCategories(Expression<Func<Categories,bool>> filter = null, params string[] includeList);

    }
}
