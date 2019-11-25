using System;
using System.Collections.Generic;
using DTZ.AdmissionTest.Platform.Interfaces;
using DTZ.AdmissionTest.Platform.Repositories;

namespace DTZ.AdmissionTest.Platform.Entities
{
    public class Addresses : Entity, IAddresses
    {
        private readonly IAddressesRepository _addressesRepository;

        public string ZipCode { get; private set; }
        public int Number { get; private set; }
        public string Address { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public Users User { get; private set; }

        public Addresses(IAddressesRepository addressesRepository)
        {
            _addressesRepository = addressesRepository;
        }

        public void Assemble(string zipCode, int number, string address, string state, string city)
        {
            ZipCode = zipCode;
            Number = number;
            Address = address;
            State = state;
            City = city;
        }

        public IList<Addresses> Get()
        {
            return _addressesRepository.Get();
        }

        public Guid Create(Addresses address)
        {
            return _addressesRepository.Insert();
        }

        public bool Update(Addresses address)
        {
            return _addressesRepository.Update();
        }

        public bool Deactivate(Guid id) => _addressesRepository.Deactivate(id);
    }
}
