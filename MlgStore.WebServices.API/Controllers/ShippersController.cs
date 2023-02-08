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
    public class ShippersController : ControllerBase
    {
        private readonly IShippersBs _sBs;
        private readonly IMapper _mapper;

        public ShippersController(IShippersBs sBs, IMapper mapper)
        {
            _sBs= sBs;
            _mapper= mapper;
        }

        [HttpGet]
        public ActionResult<List<ShipperGetDto>> GetAllShippers()
        {
            var shippers = _sBs.GetAllShippers(null);
            var dto = _mapper.Map<ShipperGetDto>(shippers);
            return Ok(dto);
        }






    }
}
