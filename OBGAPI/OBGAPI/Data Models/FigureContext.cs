using Microsoft.EntityFrameworkCore;
namespace OBGAPI.DataModels
{   
        public class FigureContext : DbContext
        {
            public FigureContext(DbContextOptions<FigureContext> options)
                : base(options)
            {
                Database.EnsureCreated(); //ensuring that the DB(temp) is created
            }

            public DbSet<Figure> figures { get; set; }
        }
}