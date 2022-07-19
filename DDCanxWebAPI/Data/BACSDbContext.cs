using DDCanxWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DDCanxWebAPI.Data
{
    public class BACSDbContext : DbContext
    {
        public BACSDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BACs> BACs { get; set; }
    }
}
