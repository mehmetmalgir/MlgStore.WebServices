using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Bussiness.Contracts
{
    public interface ICustomerBs
    {
        Customers NewCustomers(Customers entity);


    }
}
