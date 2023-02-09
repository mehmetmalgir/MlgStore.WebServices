using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MlgStore.Bussiness.Contracts
{
    public interface IColorBs
    {
        List<Colors> GetColors(Expression<Func<Colors,bool>> filter = null, params string[] includeList);
    }
}
