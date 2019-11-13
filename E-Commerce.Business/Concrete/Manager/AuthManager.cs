using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Business.Abstract.Services;
using E_Commerce.DataAccess.Concrete.Contexts;
using E_Commerce.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Business.Concrete.Manager
{
     public class AuthManager:IAuthService
     {
         private readonly ApplicationIdentityDbContext _context;
         private readonly UserManager<ApplicationUser> _userManager;

        public AuthManager(ApplicationIdentityDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public async Task<ApplicationUser> Register(ApplicationUser user, string password)
        {
             await _userManager.CreateAsync(user, password);
            return user;
        }

        public  List<ApplicationUser> UsersList()
         {
             return _userManager.Users.ToList();
         }

        public async Task<bool> UserExists(string userName)
        {
            if (await _userManager.Users.AnyAsync(x => x.UserName == userName)) return true;
            return false;

        }

        public async Task<bool> EmailExist(string email)
        {
            if (await _userManager.Users.AnyAsync(u => u.Email == email)) return true;
            return false;

        }
     }
}
