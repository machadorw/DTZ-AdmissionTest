using DTZ.AdmissionTest.Platform.Interfaces;
using DTZ.AdmissionTest.Platform.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTZ.AdmissionTest.Platform.Entities
{
    public class Products : Entity, IProducts
    {
        private readonly IProductsRepository _productsRepository;

        public string Description { get; private set; }
        public decimal ProductPrice { get; private set; }
        public bool IsAvailableForRedemption { get; private set; }

        public Products(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public void Assemble(string description, decimal productPrice, bool isAvailableForRedemption)
        {
            Description = description;
            ProductPrice = productPrice;
            IsAvailableForRedemption = isAvailableForRedemption;
        }

        public bool RedeemProduct(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
