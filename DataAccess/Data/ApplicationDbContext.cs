using BudgetApp.Api.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Api.DataAccess.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
}