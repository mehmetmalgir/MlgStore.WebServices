using MlgStore.Bussiness.Contracts;
using MlgStore.DataAccess.Contracts;
using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MlgStore.Bussiness.Implementations
{
	public class EfComplaintsBs : IComplaintsBs
	{
		private readonly IComplaintsRepository _repo;

		public EfComplaintsBs(IComplaintsRepository repo)
		{
			_repo = repo;
		}

		public List<Complaints> GetAllComplaints(Expression<Func<Complaints, bool>> filter = null, params string[] includeList)
		{
			return _repo.GetAll(filter,includeList).ToList();
		}

		public Complaints SendComplaints(Complaints entity)
		{
			return _repo.Add(entity);
		}
	}
}
