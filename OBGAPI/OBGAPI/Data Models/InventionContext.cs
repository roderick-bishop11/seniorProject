using System;
using Microsoft.EntityFrameworkCore;
namespace OBGAPI.DataModels
{
    public class InventionContext : DbContext
    {
        public InventionContext(DbContextOptions<InventionContext> options)
            : base(options)
        {
            Database.EnsureCreated(); //ensuring that the DB(temp) is created
        }

        public DbSet<Fact> Facts { get; set; }
    }
}
