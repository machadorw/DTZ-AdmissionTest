using DTZ.AdmissionTest.Platform.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTZ.AdmissionTest.Platform.Repositories
{
    public interface IOrdersRepository
    {
        IEnumerable<Orders> GetOrders(string user);
    }
}
