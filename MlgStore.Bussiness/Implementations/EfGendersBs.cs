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
    public class EfGendersBs : IGendersBs
    {
        private readonly IGenderRepository _repo;

        public EfGendersBs(IGenderRepository repo)
        {
            _repo= repo;
        }

        public List<Genders> GetAllGenders(Expression<Func<Genders, bool>> filter = null, params string[] includeList)
        {
            return _repo.GetAll(filter, includeList).ToList();
        }
    }
}
