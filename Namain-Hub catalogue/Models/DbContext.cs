using Microsoft.EntityFrameworkCore;

namespace Namain_Hub_catalogue.Models
{

    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<MyModel> MyModels { get; set; }

    }
}
