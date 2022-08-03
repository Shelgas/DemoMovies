global using DM.Domain.Interfaces;
global using DM.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Infrastructure.Persistance
{
    public class DmContext : DbContext
    {
        public DbSet<Actor>? Actors { get; set; }
        public DbSet<Movie>? Movies { get; set; }


        public DmContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                 new Movie()
                 {
                     Id = Guid.NewGuid(),
                     Name = "Life",
                     Description = "This is the Life movie description",
                     Price = 39.50,
                     ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                     Date = DateTime.Now.AddDays(-10)
                 },
                        new Movie()
                        {
                            Id = Guid.NewGuid(),
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            Date = DateTime.Now
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            Date = DateTime.Now,
                            Id = Guid.NewGuid()
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            Date = DateTime.Now.AddDays(-10),
                            Id = Guid.NewGuid()
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            Date = DateTime.Now.AddDays(-10),
                            Id = Guid.NewGuid()

                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            Date = DateTime.Now.AddDays(3),
                            Id = Guid.NewGuid()

                        });
        }
    }
}
