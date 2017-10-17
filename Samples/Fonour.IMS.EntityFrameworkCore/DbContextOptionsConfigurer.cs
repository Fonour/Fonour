using Microsoft.EntityFrameworkCore;

namespace Fonour.IMS.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<IMSDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for IMSDbContext */
            dbContextOptions.UseNpgsql(connectionString);
        }
    }
}
