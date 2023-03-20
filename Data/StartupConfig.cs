using ContactCrate.Helpers;
using ContactCrate.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NuGet.Common;
using System.Configuration;

namespace ContactCrate.Data;

public static class StartupConfig
{
    public static void AddStandardServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllersWithViews();
    }

    public static void AddDatabaseServices(this WebApplicationBuilder builder)
    {
        var connectionString = ConnectionHelper.GetConnectionString(builder.Configuration);

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(connectionString));

        builder.Services.AddDatabaseDeveloperPageExceptionFilter();
    }

    public static void AddAuthServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationDbContext>();
    }

    public static void AddExternalAuthServices(this WebApplicationBuilder builder)
    {
        // Add Google / Twitter / Github / Facebook
    }
}