using DTZ.AdmissionTest.Platform.Enums;
using DTZ.AdmissionTest.Platform.Interfaces;
using DTZ.AdmissionTest.Platform.Repositories;
using System.Collections.Generic;

namespace DTZ.AdmissionTest.Platform.Entities
{
    public class Orders : Entity, IOrders
    {
        private readonly IOrdersRepository _ordersRepository;

        public IList<Products> Products { get; set; }
        public Users User { get; private set; }
        public EOrderStatus OrderStatus { get; private set; }

        public Orders(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public void Assemble(IList<Products> products, Users user, EOrderStatus orderStatus)
        {
            Products = products;
            User = user;
            OrderStatus = orderStatus;
        }

        public IEnumerable<Orders> GetOrders(string user)
        {
            return _ordersRepository.GetOrders(user);
        }
    }
}
