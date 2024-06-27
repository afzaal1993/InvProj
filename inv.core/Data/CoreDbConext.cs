using Inv.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace Inv.Core.Data;

public class CoreDbConext : DbContext
{
    public CoreDbConext(DbContextOptions<CoreDbConext> options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Batch> Batches { get; set; }
    public DbSet<Product> Products { get; set; }
}
