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
    public class OrdersController : ControllerBase
    {

        private readonly IOrdersBs _oBs;
        private readonly IMapper _mapper;

        public OrdersController(IOrdersBs oBs, IMapper mapper)
        {
            _oBs = oBs;
            _mapper = mapper;
        }

        [ProducesResponseType(typeof(List<OrdersGetDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public ActionResult<List<OrdersGetDto>> GetAllOrders()
        {
            try
            {
                var orders = _oBs.GetOrders();
                var dtos = _mapper.Map<List<OrdersGetDto>>(orders);
                return Ok(dtos);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }


        }

        [ProducesResponseType(typeof(CategoryGetDto), StatusCodes.Status201Created)]
        [HttpPost]
        public ActionResult<OrdersGetDto> AddOrders([FromBody] OrdersForCreationDto dto)
        {
            var orders = _mapper.Map<Orders>(dto);
            var inserted = _oBs.AddOrder(orders);
            var insertedDto = _mapper.Map<OrdersGetDto>(inserted);
            return Created("", insertedDto);

        }






    }
}
