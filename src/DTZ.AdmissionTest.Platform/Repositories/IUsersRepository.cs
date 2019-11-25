using DTZ.AdmissionTest.Platform.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTZ.AdmissionTest.Platform.Repositories
{
    public interface IUsersRepository
    {
        IList<Users> Get();
        int Insert(Users user);
        int Update(Users user);
        int Delete(Users users);
    }
}
