using DTZ.AdmissionTest.Platform.Entities;
using DTZ.AdmissionTest.Platform.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace DTZ.AdmissionTest.Tests.Entities
{
    public class OrdersTests
    {
        private readonly Mock<IOrdersRepository> _ordersRepository;
        private readonly Mock<IUsersRepository> _usersRepository;

        public OrdersTests()
        {
            _ordersRepository = new Mock<IOrdersRepository>();
            _usersRepository = new Mock<IUsersRepository>();

            OrderSetup();
        }

        [Fact]
        public void GetOrders_Should_Succeed()
        {
            // Arrange
            string userId = Guid.NewGuid().ToString();
            var order = new Orders(_ordersRepository.Object);

            // Act
            var orders = order.GetOrders(userId);

            // Assert
            Assert.NotNull(orders);
        }

        private void OrderSetup()
        {
            _ordersRepository.Setup(o => o.GetOrders(It.IsAny<string>())).Returns(new List<Orders>());
        }
    }
}
