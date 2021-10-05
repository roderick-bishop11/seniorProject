using System;
using Microsoft.EntityFrameworkCore;
namespace OBGAPI.DataModels
{
    public class FactContext : DbContext
    {
        public FactContext(DbContextOptions<FactContext> options)
            :base(options)
        {
            Database.EnsureCreated(); //ensuring that the DB(temp) is created
        }

        public DbSet<Fact> Facts { get; set; }
    }
}
