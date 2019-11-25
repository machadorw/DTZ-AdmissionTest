using System;
using System.Collections.Generic;
using System.Text;
using DTZ.AdmissionTest.Platform.Entities;

namespace DTZ.AdmissionTest.Platform.Repositories
{
    public interface IAddressesRepository
    {
        bool Deactivate(Guid id);
        bool Update();
        Guid Insert();
        IList<Addresses> Get();
    }
}
