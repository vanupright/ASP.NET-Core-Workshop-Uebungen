using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


// Has the only purpose to "ignore" the in memory database setupped ub the Services.
namespace Workshop.Models
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite("Data Source=Books.db");
            return new ApplicationDbContext(builder.Options);
        }
    }
}
