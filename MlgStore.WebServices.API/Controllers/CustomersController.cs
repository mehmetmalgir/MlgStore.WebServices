using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MlgStore.Bussiness.Contracts;
using MlgStore.Model.Dtos;
using MlgStore.Model.Entities;

namespace MlgStore.WebServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerBs _cBs;
        private readonly IMapper _mapper;
        public CustomersController(ICustomerBs cBs, IMapper mapper)
        {
            _cBs = cBs;
            _mapper = mapper;
        }



        [HttpPost]
        [ProducesResponseType(typeof(CustomersGetDto),StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CustomersGetDto> Register([FromBody] NewCustomerDto dto)
        {
            var newUser = _mapper.Map<Customers>(dto);
            var addedUser = _cBs.NewCustomers(newUser);
            var addedUserDto = _mapper.Map<CustomersGetDto>(addedUser);
            return Created("", addedUserDto);

        }









    }
}
