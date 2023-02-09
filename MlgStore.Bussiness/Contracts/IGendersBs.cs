using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MlgStore.Bussiness.Contracts
{
    public interface IGendersBs
    {

        List<Genders> GetAllGenders(Expression<Func<Genders,bool>> filter = null, params string[] includeList);


    }
}
