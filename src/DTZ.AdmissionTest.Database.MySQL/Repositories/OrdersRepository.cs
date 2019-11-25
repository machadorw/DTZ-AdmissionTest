using DTZ.AdmissionTest.Platform.Entities;
using DTZ.AdmissionTest.Platform.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DTZ.AdmissionTest.Database.MySQL.Repositories
{
    public class OrdersRepository : DtzContext, IOrdersRepository
    {
        public IEnumerable<Orders> GetOrders(string user)
        {
            throw new NotImplementedException();
        }
    }
}
