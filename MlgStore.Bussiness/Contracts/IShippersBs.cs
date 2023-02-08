using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MlgStore.Bussiness.Contracts
{
    public interface IShippersBs
    {
        List<Shippers> GetAllShippers(Expression<Func<Shippers,bool>> filter = null, params string[] includeList);
    }
}
