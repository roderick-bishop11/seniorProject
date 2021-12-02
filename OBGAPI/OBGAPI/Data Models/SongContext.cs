using System;
using Microsoft.EntityFrameworkCore;
namespace OBGAPI.DataModels
{
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions<SongContext> options)
            : base(options)
        {
            Database.EnsureCreated(); //ensuring that the DB(temp) is created
        }

        public DbSet<Fact> Facts { get; set; }
    }
}
