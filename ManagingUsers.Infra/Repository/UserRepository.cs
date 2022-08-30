using ManagingUsers.Domain.Entities;
using ManagingUsers.Domain.Repository;
using ManagingUsers.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ManagingUsers.Infra.Data.UsersContext;

namespace ManagingUsers.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DbUsersContext Db;

        public UserRepository(DbUsersContext db)
        {
            Db = db;
        }

        public async Task<Users> GetById(int id)
        {
            return await Db.Users.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task InsertAsync(Users users)
        {
            try
            {
                 Db.Users.Add(users);
                 Db.SaveChanges();
            }
            catch (Exception ex)
            {
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var user = await Db.Users.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
                Db.Users.Remove(user);
                Db.SaveChanges();
            }
            catch (Exception ex)
            {
            }
        }
        public async Task updateAsync(Users users)
        {
            try
            {
                Db.Entry(users).State = EntityState.Modified;
                Db.SaveChanges();
            }
            catch (Exception ex)
            {
            }
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
