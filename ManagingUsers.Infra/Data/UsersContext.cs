using ManagingUsers.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagingUsers.Infra.Data
{
    public class UsersContext
    {
        public class DbUsersContext : DbContext
        {
            public DbUsersContext(DbContextOptions<DbUsersContext> options) : base(options)
            {
            }

            public DbSet<Users> Users { get; set; }
        }
    }
}
