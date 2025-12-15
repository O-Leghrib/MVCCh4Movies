using Microsoft.EntityFrameworkCore;

namespace MovieProject.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }= null!;
        public DbSet<Genre> Genres { get; set; }= null!;
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new { GenreId = "A", Name = "Action" },
                new { GenreId = "D", Name = "Drama" },
                new { GenreId = "H", Name = "Horror" },
                new { GenreId = "S", Name = "SciFi" },
                new { GenreId = "R", Name = "RemCom" }



                );


            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "The Shawshank Redemption", Year = 1994, Rating = 5 ,GenreId="D"},
                new Movie { Id = 2, Name = "The Godfather", Year = 1972, Rating = 5, GenreId = "D" },
                new Movie { Id = 3, Name = "The Dark Knight", Year = 2008, Rating = 5, GenreId = "A" }
            );
        }
    }
}
