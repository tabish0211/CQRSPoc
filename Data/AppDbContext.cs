//using Microsoft.EntityFrameworkCore;

//public class AppDbContext : DbContext
//{
//    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

//    public DbSet<Item> Items { get; set; }
//}

using CQRSWithMediatR.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSWithMediatR.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}