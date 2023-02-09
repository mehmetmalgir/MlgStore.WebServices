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
    public class EfSizeBs : ISizeBs
    {
        private readonly ISizeRepository _repo;

        public EfSizeBs(ISizeRepository repo)
        {
            _repo= repo;
        }

        public List<Sizes> GetSizes(Expression<Func<Sizes, bool>> filter = null, params string[] includeList)
        {
            return _repo.GetAll(filter, includeList).ToList();
        }
    }
}
