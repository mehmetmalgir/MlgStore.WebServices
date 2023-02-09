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
    public class SizesController : ControllerBase
    {
        private readonly ISizeBs _sBs;
        private readonly IMapper _mapper;

        public SizesController(ISizeBs sBs, IMapper mapper)
        {
            _sBs= sBs;
            _mapper= mapper;
        }

        [ProducesResponseType(typeof(List<SizeGetDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public ActionResult<List<SizeGetDto>> GetSizes()
        {
            try
            {
                var sizes = _sBs.GetSizes(null);
                var dtos = _mapper.Map<List<SizeGetDto>>(sizes);
                return Ok(dtos);
            }
            catch 
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }




    }
}
