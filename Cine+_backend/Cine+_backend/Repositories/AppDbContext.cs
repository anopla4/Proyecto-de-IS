using Cine__backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasData(new Genre { Id = Guid.NewGuid(), Name = "Drama" }, new Genre { Id = Guid.NewGuid(), Name = "Comedia" }, new Genre { Id = Guid.NewGuid(), Name = "Romántica" }, new Genre { Id = Guid.NewGuid(), Name = "Suspenso" }, new Genre { Id = Guid.NewGuid(), Name = "Terror" });
            modelBuilder.Entity<Item>()
                .Property(e => e.State)
                .HasConversion(
                    v => v.ToString(),
                    v => (State)Enum.Parse(typeof(State), v));
            modelBuilder.Entity<ClubMemberGenre>()
                .HasKey(c => new { c.ClubMemberId, c.GenreId } );
            modelBuilder.Entity<BookEntry>()
                .Property(e => e.PaymentMethod)
                .HasConversion(
                    v => v.ToString(),
                    v => (PaymentMethod)Enum.Parse(typeof(PaymentMethod), v));

                .HasData(new Genre { Id = Guid.NewGuid(), Name = "Drama" }, new Genre { Id = Guid.NewGuid(), Name = "Comedia" }, new Genre { Id = Guid.NewGuid(), Name = "Romántica" }, new Genre { Id = Guid.NewGuid(), Name = "Suspenso" }, new Genre { Id = Guid.NewGuid(), Name = "Terror" });

            modelBuilder.Entity<FilmScreening>().HasOne(c => c.Film).WithMany().
                                                OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<FilmScreening>().HasOne(c => c.Room).WithMany().
                                                OnDelete(DeleteBehavior.Restrict);

        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<FilmStaffMember> FilmStaffMembers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ClubMember> ClubMembers { get; set; }
        public DbSet<ClubMemberGenre> clubMemberGenres { get; set; }
        public DbSet<BookEntry> BookEntries { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<PriceModification> PriceModifications { get; set; }
        public DbSet<FilmRol> FilmRols { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmScreening> FilmScreenings { get; set; }

    }
}
