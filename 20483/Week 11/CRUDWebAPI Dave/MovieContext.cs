using Microsoft.EntityFrameworkCore;

namespace CRUDWebAPI_Dave
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "The Shawshank Redemption", ReleaseYear = 1994, Rating = 9.5f, SuggestedAudience = "R" },
                new Movie { MovieId = 2, Title = "The DarkKnight", ReleaseYear = 2008, Rating = 9.0f, SuggestedAudience = "PG-13" },
                new Movie { MovieId = 3, Title = "12 Angry Men", ReleaseYear = 1957, Rating = 9.2f, SuggestedAudience = "R" }
                );
        }
    }
}
