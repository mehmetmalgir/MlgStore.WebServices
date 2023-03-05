using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MlgStore.Bussiness.Contracts
{
	public interface IComplaintsBs
	{
		List<Complaints> GetAllComplaints(Expression<Func<Complaints, bool>> filter = null, params string[] includeList);
		Complaints SendComplaints(Complaints entity);



	}
}
