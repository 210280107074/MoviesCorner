using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moviecorner.Domain.Models;

namespace moviecorner.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<MovieLanguage> MovieLanguage { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .Property(c => c.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Users>()
                .Property(u => u.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Role>()
                .Property(r => r.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<State>()
                .Property(c => c.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Country>()
                .Property(u => u.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Movie>()
                .Property(r => r.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<MovieActor>()
                .Property(r => r.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Language>()
                .Property(r => r.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<MovieGenre>()
                .Property(r => r.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<MovieLanguage>()
                .Property(r => r.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Genre>()
                .Property(r => r.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Actor>()
                .Property(r => r.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Users>()
            .Property(u => u.CreatedAt)
            .HasDefaultValueSql("NOW()");

            modelBuilder.Entity<Movie>()
            .Property(u => u.CreatedAt)
            .HasDefaultValueSql("NOW()");

            // repeat for all Guid PK entities
        }

    }

}