using Infrastructure.DataAccess.Contracts;
using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.DataAccess.Contracts
{
    public interface IProductRepository : IEntityRepository<Products>
    {              
        List<Products> GetProductsByColor(int colorId, params string[] includeList);
        List<Products> GetProductsBySize(int sizeId, params string[] includeList);
        List<Products> GetProductsByCategory(int categoryId, params string[] includeList);
        List<Products> GetProductsByGender(int genderId, params string[] includeList);
        List<Products> GetProductsByPriceRange(int min, int max, params string[] includeList);
        List<Products> GetProductsByStockRange(int min, int max, params string[] includeList);

    }
}
