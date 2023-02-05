using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MlgStore.Bussiness.Contracts;
using MlgStore.Model.Entities;
using System.Collections.Generic;

namespace MlgStore.WebServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductBs _pBs;

        public ProductsController(IProductBs pBs)
        {
            _pBs = pBs;
        }

        [HttpGet]
        public List<Products> GetAll()
        {
            return _pBs.GetAllProducts();

        }



    }
}
