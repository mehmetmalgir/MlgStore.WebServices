using MlgStore.Bussiness.Contracts;
using MlgStore.DataAccess.Contracts;
using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MlgStore.Bussiness.Implementations
{
    public class EfOrdersBs : IOrdersBs
    {
        private readonly IOrdersRepository _repo;

        public EfOrdersBs(IOrdersRepository repo)
        {
            _repo = repo;
        }

        public Orders AddOrder(Orders entity)
        {
            return _repo.Add(entity);
        }

        public List<Orders> GetOrders(Expression<Func<Orders, bool>> filter = null, params string[] includeList)
        {
            return _repo.GetAll(filter, includeList).ToList();
        }

       
    }
}
