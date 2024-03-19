using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Namain_Hub_catalogue
{
    public class Startup
    {
    }


    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<MyDbContext>(options =>
            options.UseMySQL(Configuration.GetConnectionString("MySqlConnectionString")));
    }
}