using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.Business.Abstract.Services
{
     public interface IAuthService
     {
         Task<ApplicationUser> Register(ApplicationUser user, string password);
         List<ApplicationUser> UsersList();
         Task<bool> UserExists(string userName);
         Task<bool> EmailExist(string email);
     }
}
