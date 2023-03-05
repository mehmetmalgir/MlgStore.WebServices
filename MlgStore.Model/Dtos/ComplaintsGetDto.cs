using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Dtos
{
	public class ComplaintsGetDto : IDto
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string Description { get; set; }


	}
}
