using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MlgStore.Bussiness.Contracts
{
    public interface IProductBs
    {
        List<Products> GetAllProducts(Expression<Func<Products, bool>> filter = null, params string[] includeList);
        List<Products> GetProductsByCategory(int categoryId, params string[] includeList);
        List<Products> GetProductsByGender(int categoryId, params string[] includeList);
        List<Products> GetProductsByPriceRange(int min, int max, params string[] includeList);
        List<Products> GetProductsByStockRange(int min, int max, params string[] includeList);
        List<Products> GetProductsBySize(int sizeId, params string[] includeList);
        List<Products> GetProductsByColor(int colorId, params string[] includeList);
        Products GetProductById(int productId, params string[] includeList);
        Products Insert(Products entity);
        void Delete(Products entity);
        void Update(Products entity);

    }
}
