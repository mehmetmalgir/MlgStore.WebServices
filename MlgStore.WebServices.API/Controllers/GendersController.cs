using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MlgStore.Bussiness.Contracts;
using MlgStore.Model.Dtos;
using System.Collections.Generic;

namespace MlgStore.WebServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GendersController : ControllerBase
    {
        private readonly IGendersBs _gBs;
        private readonly IMapper _mapper;

        public GendersController(IGendersBs gBs, IMapper mapper)
        {
            _gBs= gBs;
            _mapper= mapper;
        }

        [ProducesResponseType(typeof(List<GenderGetDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public ActionResult<List<GenderGetDto>> GetGenders()
        {
            try
            {
                var genders = _gBs.GetAllGenders();
                var dtos = _mapper.Map<List<GenderGetDto>>(genders);
                return Ok(dtos);
            }
            catch 
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }            
        }











    }
}
