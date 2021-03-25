using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BerrasBio.Models;
using Microsoft.EntityFrameworkCore;

namespace BerrasBio
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext()
            {
            }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieDetail> MovieDetails { get; set; }
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

    }
}
