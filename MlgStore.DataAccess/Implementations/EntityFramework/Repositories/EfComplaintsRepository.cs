using Infrastructure.DataAccess.Implementations.EntityFramework;
using MlgStore.DataAccess.Contracts;
using MlgStore.DataAccess.Implementations.EntityFramework.Contexts;
using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.DataAccess.Implementations.EntityFramework.Repositories
{
	public class EfComplaintsRepository : EfBaseEntityRepository<Complaints,MlgStoreContext>, IComplaintsRepository
	{







	}
}
