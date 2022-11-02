using Microsoft.EntityFrameworkCore;
using Recruits.Model;

namespace Recruits.Model;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Category { get; set; }
}
// add-migration AddCategoryToDb
// update-database
