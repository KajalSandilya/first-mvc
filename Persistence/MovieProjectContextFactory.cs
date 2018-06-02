using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MovieProject.Persistence
{
    public class MovieProjectDbContextFactory : IDesignTimeDbContextFactory<MovieProjectDbContext>
    {
         public MovieProjectDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MovieProjectDbContext>();
            optionsBuilder.UseSqlServer("server=localhost; database=MovieProjectDb; Integrated Security=SSPI");

            return new MovieProjectDbContext(optionsBuilder.Options);
        }
    }

   
}