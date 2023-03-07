using MlgStore.Bussiness.Contracts;
using MlgStore.DataAccess.Contracts;
using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Bussiness.Implementations
{
    public class EfCustomersBs : ICustomerBs
    {
        private readonly ICustomersRepository _repo;
        public EfCustomersBs(ICustomersRepository repo)
        {
            _repo = repo;
        }

        public Customers NewCustomers(Customers entity)
        {
            return _repo.Add(entity);
        }


    }
}
