using Infrastructure.DataAccess.Contracts;
using Infrastructure.DataAccess.Implementations.EntityFramework;
using Infrastructure.Model;
using MlgStore.DataAccess.Contracts;
using MlgStore.DataAccess.Implementations.EntityFramework.Contexts;
using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MlgStore.DataAccess.Implementations.EntityFramework.Repositories
{
    public class EfProductRepository : EfBaseEntityRepository<Products, MlgStoreContext>, IProductRepository
    {
        public List<Products> GetProductsByCategory(int categoryId, params string[] includeList)
        {
            return GetAll(x => x.CategoryID == categoryId, includeList).ToList();
        }

        public List<Products> GetProductsByColor(int colorId, params string[] includeList)
        {
            return GetAll(x => x.ColorID == colorId, includeList).ToList();
        }

        public List<Products> GetProductsByGender(int genderId, params string[] includeList)
        {
            return GetAll(x => x.GenderID == genderId, includeList).ToList();
        }

        public List<Products> GetProductsByPriceRange(int min, int max, params string[] includeList)
        {
            return GetAll(x => x.UnitPrice > min && x.UnitPrice < max, includeList).ToList();
        }

        public List<Products> GetProductsBySize(int sizeId, params string[] includeList)
        {
            return GetAll(x => x.SizeID == sizeId, includeList).ToList();
        }

        public List<Products> GetProductsByStockRange(int min, int max, params string[] includeList)
        {
            return GetAll(x => x.QuantityPerUnit > min && x.QuantityPerUnit < max, includeList).ToList();
        }


    }
}
