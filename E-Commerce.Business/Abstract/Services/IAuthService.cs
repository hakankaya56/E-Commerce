using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.Business.Abstract.Services
{
    public interface IAuthService
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        List<User> UsersList();
        Task<bool> UserExists(string userName);
    }
}
