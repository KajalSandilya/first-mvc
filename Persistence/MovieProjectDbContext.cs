using Microsoft.EntityFrameworkCore;

namespace MovieProject.Persistence
{
    public class MovieProjectDbContext : DbContext
    {
         public MovieProjectDbContext(DbContextOptions<MovieProjectDbContext> options) 
         : base(options)
       {
           
       }
    }
}