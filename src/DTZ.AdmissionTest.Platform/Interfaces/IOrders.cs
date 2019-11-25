using DTZ.AdmissionTest.Platform.Entities;
using System.Collections.Generic;

namespace DTZ.AdmissionTest.Platform.Interfaces
{
    public interface IOrders
    {
        IEnumerable<Orders> GetOrders(string userId);
    }
}
