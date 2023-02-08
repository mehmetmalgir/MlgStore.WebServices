using MlgStore.Bussiness.Contracts;
using MlgStore.DataAccess.Contracts;
using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;

namespace MlgStore.Bussiness.Implementations
{
    public class ShippersBs : IShippersBs
    {
        private readonly IShippersRepository _repo;

        public ShippersBs(IShippersRepository repo)
        {
            _repo = repo;
        }


        public List<Shippers> GetAllShippers(Expression<Func<Shippers, bool>> filter = null, params string[] includeList)
        {
            return _repo.GetAll(filter, includeList).ToList();
        }
    }
}
