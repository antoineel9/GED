using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewProject1.Data;

namespace NewProject1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NewProject1.Data.GED> GED { get; set; }
        public DbSet<NewProject1.Data.Orientation> Orientation { get; set; }
        public DbSet<NewProject1.Data.Intro> Intro { get; set; }
    }
}
