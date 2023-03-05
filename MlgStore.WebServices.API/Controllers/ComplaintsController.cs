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
	public class ComplaintsController : ControllerBase
	{
		private readonly IComplaintsBs _cBs;
		private readonly IMapper _mapper;
		public ComplaintsController(IComplaintsBs cBs, IMapper mapper)
		{
			_mapper = mapper;
			_cBs = cBs;

		}

		[ProducesResponseType(typeof(List<ComplaintsGetDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		[HttpGet]
		public ActionResult<List<ComplaintsGetDto>> GetAllComplaints()
		{
			try
			{
				var complaints = _cBs.GetAllComplaints();
				var dtos = _mapper.Map<List<ComplaintsGetDto>>(complaints);
				return Ok(dtos);
			}
			catch
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}

		}


		[ProducesResponseType(typeof(ComplaintsGetDto),StatusCodes.Status201Created)]
		[HttpPost]
		public ActionResult<ComplaintsGetDto> SendComplaints([FromBody] SendComplaintsDto dto)
		{
			var complaints = _mapper.Map<Complaints>(dto);
			var added = _cBs.SendComplaints(complaints);
			var addedDto = _mapper.Map<ComplaintsGetDto>(added);
			return Created("", addedDto);

		}



	}
}
