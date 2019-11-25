using DTZ.AdmissionTest.Platform.Entities;
using System;
using System.Collections.Generic;

namespace DTZ.AdmissionTest.Platform.Interfaces
{
    public interface IUsers
    {
        IList<Users> Get();
        Users Create(Users user);
        Users Update(string id, Users user);
        Users Delete(Users user);
    }
}
