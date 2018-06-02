using Microsoft.EntityFrameworkCore;
using MovieProject.Models;

namespace MovieProject.Persistence
{
    public class MovieProjectDbContext : DbContext
    {
         public MovieProjectDbContext(DbContextOptions<MovieProjectDbContext> options) 
         : base(options)
       {
           
       }

       public DbSet<Student> Students { get; set; }
    }
}