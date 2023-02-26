using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services
{
    public interface IUsersService
    {
        public Task<List<User>> GetAllUsers();
    }


    public class UsersService : IUsersService
    {
        public UsersService() { 
        }


        Task<List<User>> IUsersService.GetAllUsers()
        {
            throw new NotImplementedException();
        }

    }
}
