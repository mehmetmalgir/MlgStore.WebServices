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
    public class ColorsController : ControllerBase
    {
        private readonly IColorBs _cBs;
        private readonly IMapper _mapper;

        public ColorsController(IColorBs cBs, IMapper mapper)
        {
            _cBs = cBs;
            _mapper = mapper;
        }

        [ProducesResponseType(typeof(List<ColorGetDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public ActionResult<List<ColorGetDto>> GetColors()
        {
            try
            {
                var colors = _cBs.GetColors();
                var dtos = _mapper.Map<List<ColorGetDto>>(colors);
                return Ok(dtos);
            }
            catch 
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
          

        }







    }
}
