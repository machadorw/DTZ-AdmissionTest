using DTZ.AdmissionTest.Platform.Entities;
using DTZ.AdmissionTest.Platform.Repositories;
using System;
using System.Collections.Generic;

namespace DTZ.AdmissionTest.Database.MySQL.Repositories
{
    public class AddressesRepository : DtzContext, IAddressesRepository
    {
        public bool Deactivate(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<Addresses> Get()
        {
            throw new NotImplementedException();
        }

        public Guid Insert()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
