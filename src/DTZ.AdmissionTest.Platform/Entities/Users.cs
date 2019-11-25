using DTZ.AdmissionTest.Platform.Interfaces;
using DTZ.AdmissionTest.Platform.Repositories;
using System.Collections.Generic;

namespace DTZ.AdmissionTest.Platform.Entities
{
    public class Users : Entity, IUsers
    {
        private readonly IUsersRepository _usersRepository;

        public string Name { get; private set; }
        public bool IsActive { get; private set; }
        public IList<Addresses> Addresses { get; private set; }
        public IList<Orders> Orders { get; private set; }

        public Users(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public void Assemble(string name)
        {
            Name = name;
            IsActive = true;
        }

        public IList<Users> Get()
        {
            return _usersRepository.Get();
        }

        public Users Create(Users users)
        {
            bool success = _usersRepository.Insert(users) > 0;

            if (!success)
                users.AddNotification("Error while trying write data to database");

            return users;
        }

        public Users Update(string id, Users users)
        {
            bool success = _usersRepository.Update(users) > 0;

            if (!success)
                users.AddNotification("Error while trying write data to database");

            return users;
        }

        public Users Delete(Users users)
        {
            bool success = _usersRepository.Delete(users) > 0;

            if (!success)
                users.AddNotification("Error while trying to delete data from database");

            return users;
        }
    }
}
