using Infrastructure.DataAccess.Contracts;
using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MlgStore.DataAccess.Contracts
{
    public interface IShippersRepository : IEntityRepository<Shippers>
    {
        
    }
}
