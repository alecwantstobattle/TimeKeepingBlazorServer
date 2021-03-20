using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeKeepingBlazorServerApp.Model;

namespace TimeKeepingBlazorServerApp.Persistence
{
    public class SqlDbContext: DbContext
    {
        public DbSet<EmployeeModel> Employees{ get; set; }

        public SqlDbContext(DbContextOptions<SqlDbContext> options)
            : base(options)
        {
        }
    }
}
