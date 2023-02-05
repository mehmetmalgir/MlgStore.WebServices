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
    public class ProductBs : IProductBs
    {
        private readonly IProductRepository _repo;

        public ProductBs(IProductRepository repo)
        {
            _repo = repo;
        }

        public void Delete(Products entity)
        {
            _repo.Delete(entity);
        }

        public List<Products> GetAllProducts(Expression<Func<Products, bool>> filter = null, params string[] includeList)
        {
            return _repo.GetAll(filter, includeList).ToList();
        }

        public Products GetProductById(int productId, params string[] includeList)
        {
            return _repo.GetById(productId, includeList);
        }

        public List<Products> GetProductsByCategory(int categoryId, params string[] includeList)
        {
            return _repo.GetProductsByCategory(categoryId, includeList);    
        }

        public List<Products> GetProductsByColor(int colorId, params string[] includeList)
        {
            return _repo.GetProductsByColor(colorId, includeList);  
        }

        public List<Products> GetProductsByGender(int genderId, params string[] includeList)
        {
            return _repo.GetProductsByGender(genderId, includeList);
        }

        public List<Products> GetProductsByPriceRange(int min, int max, params string[] includeList)
        {
            return _repo.GetProductsByPriceRange(min, max, includeList);
        }

        public List<Products> GetProductsBySize(int sizeId, params string[] includeList)
        {
            return _repo.GetProductsBySize(sizeId, includeList);    
        }

        public Products Insert(Products entity)
        {
            return _repo.Add(entity);
        }

        public void Update(Products entity)
        {
            _repo.Update(entity);
        }
    }
}
