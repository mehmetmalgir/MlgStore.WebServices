﻿using AutoMapper;
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

        [ProducesResponseType(typeof(List<ShipperGetDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public ActionResult<List<ShipperGetDto>> GetAllShippers()
        {
            try
            {
                var shippers = _sBs.GetAllShippers(null);
                var dto = _mapper.Map<List<ShipperGetDto>>(shippers);
                return Ok(dto);
            }
            catch 
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
                
            }
            
        }






    }
}
