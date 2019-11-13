using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.DataAccess.Concrete.Contexts
{
     public class ApplicationIdentityDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options) : base(options)
        {

        }
    }
}
