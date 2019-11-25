using DTZ.AdmissionTest.Platform.Entities;
using System;
using System.Collections.Generic;

namespace DTZ.AdmissionTest.Platform.Interfaces
{
    public interface IAddresses
    {
        IList<Addresses> Get();
        Guid Create(Addresses address);
        bool Update(Addresses address);
        bool Deactivate(Guid id);
    }
}
