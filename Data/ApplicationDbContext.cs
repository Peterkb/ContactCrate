using ContactCrate.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ContactCrate.Data;

public class ApplicationDbContext: IdentityDbContext<AppUserModel>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ContactModel> Contacts { get; set; }
    public virtual DbSet<CategoryModel> Categories { get; set; }
}