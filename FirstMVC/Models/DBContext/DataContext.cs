using FirstMVC.Models.DBContext.UsersConfig;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;

namespace FirstMVC.Models.DBContext
{
    public class DataContext : DbContext
    {
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=forma-VDI1202\TFTIC;"
                                        + "Database=MVC_User2;Trusted_Connection=True;"
                                        + "TrustServerCertificate=True;");
        }
    }
}
