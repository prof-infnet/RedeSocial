using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RedeSocial.BLL.Models;

namespace RedeSocial.DAL.Data
{
    public class RedeSocialAPIContext : DbContext
    {
        public RedeSocialAPIContext (DbContextOptions<RedeSocialAPIContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItem { get; set; } = default!;
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<RedeSocialAPIContext>
    {
        public RedeSocialAPIContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory()
      + "/../RedeSocial.API/appsettings.json").Build();

            var builder = new DbContextOptionsBuilder<RedeSocialAPIContext>();

            var connectionString = configuration.GetConnectionString("RedeSocialAPIContext");
            builder.UseSqlServer(connectionString);
            return new RedeSocialAPIContext(builder.Options);
        }
    }
}
