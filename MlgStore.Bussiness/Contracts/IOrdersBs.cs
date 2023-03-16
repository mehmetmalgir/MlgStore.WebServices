using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MlgStore.Bussiness.Contracts
{
    public interface IOrdersBs
    {
        List<Orders> GetOrders(Expression<Func<Orders, bool>> filter = null, params string[] includeList);

        Orders AddOrder(Orders entity);

    }
}
