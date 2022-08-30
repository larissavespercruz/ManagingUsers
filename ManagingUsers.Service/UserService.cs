using ManagingUsers.Domain.Entities;
using ManagingUsers.Domain.Repository;
using System.Threading.Tasks;

namespace ManagingUsers.Service.Interface
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)=>
            this.userRepository = userRepository;
        
        public async Task DeleteAsync(int id)
        {
            await userRepository.DeleteAsync(id);
        }

        public async Task<Users> GetById(int id)
        {
            return await userRepository.GetById(id);
        }

        public async Task InsertAsync(Users users)
        {
            await userRepository.InsertAsync(users);
        }

        public async Task updateAsync(Users users)
        {
            await userRepository.updateAsync(users);
        }
    }
}
