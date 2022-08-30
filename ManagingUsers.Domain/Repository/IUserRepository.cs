using ManagingUsers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagingUsers.Domain.Repository
{
    public interface IUserRepository
    {
        Task InsertAsync(Users users);
        Task<Users> GetById(int id);
        Task updateAsync(Users users);
        Task DeleteAsync(int id);
    }
}
