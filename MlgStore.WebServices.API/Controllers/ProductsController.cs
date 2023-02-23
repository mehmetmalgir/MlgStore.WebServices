using AutoMapper;
using Infrastructure.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MlgStore.Bussiness.Contracts;
using MlgStore.Model.Dtos;
using MlgStore.Model.Entities;
using System.Collections.Generic;

namespace MlgStore.WebServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductBs _pBs;
        private readonly IMapper _mapper;

        public ProductsController(IProductBs pBs, IMapper mapper)
        {
            _pBs = pBs;
            _mapper = mapper;
        }

        [ProducesResponseType(typeof(List<ProductGetDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public ActionResult<List<ProductGetDto>> GetAll()
        {

            try
            {
                var products = _pBs.GetAllProducts(null, "Category", "Size", "Color", "ProductPhotos", "Gender");
                var dtos = _mapper.Map<List<ProductGetDto>>(products);

                return Ok(dtos);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [ProducesResponseType(typeof(ProductGetDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("{id}")]
        public ActionResult<ProductGetDto> GetProductById(int id)
        {

            try
            {
                if (id < 0)
                    return BadRequest("Id 0'dan Küçük Olamaz");

                var product = _pBs.GetProductById(id, "Category", "Size", "Color", "ProductPhotos", "Gender");

                if (product == null)
                    return NotFound("Bu Id'li Bir Ürün Bulunamadı");

                var dto = _mapper.Map<ProductGetDto>(product);
                return Ok(dto);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);

            }

        }

        [ProducesResponseType(typeof(List<ProductGetDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("bycolor")]
        public ActionResult<List<ProductGetDto>> GetProductsByColor([FromQuery] int colorId)
        {
            try
            {
                if (colorId < 0)
                    return BadRequest("Renk Id'si 0'dan Küçük Olamaz");

                var products = _pBs.GetProductsByColor(colorId, "Category", "Size", "Color", "ProductPhotos", "Gender");

                if (products == null)
                    return NotFound("Bu renkte bir ürün bulunmamaktadır.");

                var dtos = _mapper.Map<List<ProductGetDto>>(products);

                return Ok(dtos);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);

            }

        }

        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<ProductGetDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getbycategory")]
        public ActionResult<List<ProductGetDto>> GetProductsByCategory([FromQuery] int categoryId)
        {

            try
            {
                if (categoryId < 0)
                    return BadRequest("Kategori Id 0'dan Küçük Olamaz.");

                var products = _pBs.GetProductsByCategory(categoryId, "Category", "Size", "Color", "ProductPhotos", "Gender");

                if (products == null)
                    return NotFound("Girdiğiniz Kategori Id'sinde Ürün Mevcut Değil");

                var dtos = _mapper.Map<List<ProductGetDto>>(products);
                return Ok(dtos);

            }
            catch
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<ProductGetDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getbysize")]
        public ActionResult<List<ProductGetDto>> GetProductsBySize([FromQuery] int sizeId)
        {
            try
            {
                if (sizeId < 0)
                    return BadRequest("Beden Id'si 0'dan Küçük olamaz.");

                var products = _pBs.GetProductsBySize(sizeId, "Category", "Size", "Color", "ProductPhotos", "Gender");

                if (products == null)
                    return NotFound("Girdiğiniz Beden Id'sinde Ürün Bulunmamaktadır.");

                var dtos = _mapper.Map<List<ProductGetDto>>(products);

                return Ok(dtos);

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);

            }

        }

        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<ProductGetDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getbygender")]
        public ActionResult<List<ProductGetDto>> GetProductsByGender([FromQuery] int genderId)
        {
            try
            {
                if (genderId < 0)
                    return BadRequest("Gender Id 0'dan Küçük Olamaz.");

                var products = _pBs.GetProductsByGender(genderId, "Category", "Size", "Color", "ProductPhotos", "Gender");

                if (products == null)
                    return NotFound("Girdiğiniz Cinsiyet Id'sine göre ürün bulunamadı.");

                var dtos = _mapper.Map<List<ProductGetDto>>(products);
                return Ok(dtos);
            }
            catch
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<ProductGetDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getbypricerange")]
        public ActionResult<List<ProductGetDto>> GetProductsByPriceRange([FromQuery] int min, [FromQuery] int max)
        {
            try
            {
                if (min < 0 && max < 0)
                    return BadRequest("Minimum değer ve maksimum değer 0'dan küçük olamaz.");

                var products = _pBs.GetProductsByPriceRange(min, max, "Category", "Size", "Color", "ProductPhotos", "Gender");
                
                if (products == null)
                    return NotFound("Girdiğiniz fiyat aralığında ürün mevcut değil.");

                var dtos = _mapper.Map<List<ProductGetDto>>(products);
                return Ok(dtos);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(List<ProductGetDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getproductsbystock")]
        public ActionResult<List<ProductGetDto>> GetProductsByStock(int min,int max)
        {

            try
            {
                if(min < 0 && max <0)
                    return BadRequest("Girilen değerler 0'dan küçük olamaz.");

                var products = _pBs.GetProductsByStockRange(min, max, "Category", "Size", "Color", "ProductPhotos", "Gender");

                if (products == null)
                    return NotFound("Girdiğiniz değerlere uygun ürünler bulunamadı");

                var dtos = _mapper.Map<List<ProductGetDto>>(products);
                return Ok(dtos);

            }
            catch 
            {
                return StatusCode(StatusCodes.Status500InternalServerError);                
            }
        }

        [HttpDelete]
        public void DeleteProduct(ProductGetDto deletedDto)
        {
            var productDto = _mapper.Map<Products>(deletedDto);
            _pBs.Delete(productDto);
        }

        [HttpPut]
        public void UpdateProduct(ProductGetDto updatedDto)
        {
            var productDto = _mapper.Map<Products>(updatedDto);
            _pBs.Update(productDto);
        }

        [ProducesResponseType(typeof(ProductGetDto), StatusCodes.Status201Created)]
        [HttpPost]
        public ActionResult<ProductGetDto> AddProduct([FromBody]ProductForCreation dto)
        {
            var product = _mapper.Map<Products>(dto);

            var insertedProduct = _pBs.Insert(product);

            var insertedDto = _mapper.Map<ProductGetDto>(insertedProduct);

            return Created("", insertedDto);
        }



    }
}






















