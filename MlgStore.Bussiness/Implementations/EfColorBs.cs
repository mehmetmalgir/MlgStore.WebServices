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
    public class EfColorBs : IColorBs
    {
        private readonly IColorRepository _repo;

        public EfColorBs(IColorRepository repo)
        {
            _repo= repo;
        }

        public List<Colors> GetColors(Expression<Func<Colors, bool>> filter = null, params string[] includeList)
        {
            return _repo.GetAll(filter, includeList).ToList();
        }
    }
}
