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
    public class EfCategoryBs : ICategoryBs
    {
        private readonly ICategoryRepository _repo;

        public EfCategoryBs(ICategoryRepository repo)
        {
            _repo= repo;
        }

        public Categories AddCategory(Categories entity)
        {
            return _repo.Add(entity);
        }

        public List<Categories> GetCategories(Expression<Func<Categories, bool>> filter = null, params string[] includeList)
        {
            return _repo.GetAll(filter, includeList).ToList();
        }




    }
}
