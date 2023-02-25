using AutoMapper;
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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryBs _cBs;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryBs cBs, IMapper mapper)
        {
            _cBs = cBs;
            _mapper = mapper;
        }

        [ProducesResponseType(typeof(List<CategoryGetDto>),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public ActionResult<List<CategoryGetDto>> GetAllCategories()
        {
            try
            {
                var categories = _cBs.GetCategories(); 
                var dtos = _mapper.Map<List<CategoryGetDto>>(categories);
                return Ok(dtos);
            }
            catch 
            {
                return StatusCode(StatusCodes.Status500InternalServerError);                
            }
            

        }

        [ProducesResponseType(typeof(CategoryGetDto), StatusCodes.Status201Created)]
        [HttpPost]        
        public ActionResult<CategoryGetDto> AddCategory([FromBody]CategoryForCreation dto)
        {
            var category = _mapper.Map<Categories>(dto);
            var inserted = _cBs.AddCategory(category);
            var insertedDto = _mapper.Map<CategoryGetDto>(inserted);
            return Created("", insertedDto);

        }






    }
}
