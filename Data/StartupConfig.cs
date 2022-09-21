using ContactCrate.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactCrate.Data;

public static class StartupConfig
{
    public static void AddStandardServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllersWithViews();
    }

    public static void AddDatabaseServices(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetSection("ConnectionStrings")["DefaultConnection"];

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(connectionString));

        builder.Services.AddDatabaseDeveloperPageExceptionFilter();
    }

    public static void AddAuthServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddDefaultIdentity<AppUserModel>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationDbContext>();
    }
}
