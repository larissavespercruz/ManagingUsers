using ManagingUsers.Domain.Entities;
using System.Threading.Tasks;

namespace ManagingUsers.Service.Interface
{
    public interface IUserService
    {
        Task InsertAsync(Users users);
        Task<Users> GetById(int id);
        Task updateAsync(Users users);
        Task DeleteAsync(int id);
    }
}
