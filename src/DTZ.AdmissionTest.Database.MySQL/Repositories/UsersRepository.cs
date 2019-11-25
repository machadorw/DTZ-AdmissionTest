using DTZ.AdmissionTest.Platform.Entities;
using DTZ.AdmissionTest.Platform.Repositories;
using System;
using System.Collections.Generic;

namespace DTZ.AdmissionTest.Database.MySQL.Repositories
{
    public class UsersRepository : DtzContext, IUsersRepository
    {
        public IList<Users> Get()
        {
            throw new NotImplementedException();
        }

        public int Insert(Users user)
        {
            int affectedRows;

            using (var context = new DtzContext())
            {
                context.Database.EnsureCreated();

                context.User.Add(user);

                affectedRows = context.SaveChanges();
            }

            return affectedRows;
        }

        public int Update(Users user)
        {
            int affectedRows;

            using (var context = new DtzContext())
            {
                context.Database.EnsureCreated();

                context.User.Update(user);

                affectedRows = context.SaveChanges();
            }

            return affectedRows;
        }

        public int Delete(Users user)
        {
            int affectedRows;

            using (var context = new DtzContext())
            {
                context.Database.EnsureCreated();

                context.User.Remove(user);

                affectedRows = context.SaveChanges();
            }

            return affectedRows;
        }
    }
}
