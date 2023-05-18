using CSharp.Forms.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CSharp.Forms.Data
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseInMemoryDatabase(Configuration.GetConnectionString("WinformsDatabase"));
        }

        public DbSet<User> Users { get; set; }

    }
}