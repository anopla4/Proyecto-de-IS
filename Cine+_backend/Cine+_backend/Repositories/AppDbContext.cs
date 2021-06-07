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
            //Genre
            modelBuilder.Entity<Genre>()
                .HasData(new Genre { Id = Guid.NewGuid(), Name = "Drama" }, new Genre { Id = Guid.NewGuid(), Name = "Comedia" }, new Genre { Id = Guid.NewGuid(), Name = "Romántica" }, new Genre { Id = Guid.NewGuid(), Name = "Suspenso" }, new Genre { Id = Guid.NewGuid(), Name = "Terror" });
            //Item
            modelBuilder.Entity<Item>()
                .Property(e => e.State)
                .HasConversion(
                    v => v.ToString(),
                    v => (State)Enum.Parse(typeof(State), v));
            //ClubMember
            modelBuilder.Entity<ClubMemberGenre>()
                .HasKey(c => new { c.ClubMemberId, c.GenreId } );
            //BookEntry
            modelBuilder.Entity<BookEntry>()
                .Property(e => e.PaymentMethod)
                .HasConversion(
                    v => v.ToString(),
                    v => (PaymentMethod)Enum.Parse(typeof(PaymentMethod), v));
            //FilmScreening
            modelBuilder.Entity<FilmScreening>()
                .HasOne(c => c.Film).WithMany().OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<FilmScreening>()
                .HasOne(c => c.Room).WithMany().OnDelete(DeleteBehavior.SetNull);
            //FilmGenre
            modelBuilder.Entity<FilmGenre>()
                .HasKey(c => new { c.FilmId, c.GenreId });
            modelBuilder.Entity<FilmGenre>()
                .HasOne(c => c.Film).WithMany().OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<FilmGenre>()
                .HasOne(c => c.Genre).WithMany().OnDelete(DeleteBehavior.SetNull);
            //FilmFilmRol
            modelBuilder.Entity<FilmFilmRol>()
               .HasKey(c => new { c.FilmId, c.FilmRolId });
            modelBuilder.Entity<FilmFilmRol>()
                .HasOne(c => c.Film).WithMany().OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<FilmFilmRol>()
                .HasOne(c => c.FilmRol).WithMany().OnDelete(DeleteBehavior.SetNull);
            //UserFilm
            modelBuilder.Entity<UserFilm>()
                .HasKey(c => new { c.UserId, c.FilmId });

            modelBuilder.Entity<UserFilm>()
                .HasOne(c => c.User).WithMany().OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<UserFilm>()
                .HasOne(c => c.Film).WithMany().OnDelete(DeleteBehavior.SetNull);
            //FilmScreeningPriceModification
            modelBuilder.Entity<FilmScreeningPriceModification>()
                .HasKey(c => new { c.FilmScreeningId, c.PriceModificationId });
            modelBuilder.Entity<FilmScreeningPriceModification>().HasOne(c => c.FilmScreening).WithMany().
                                                                    OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<FilmScreeningPriceModification>().HasOne(c => c.PriceModification).WithMany().
                                                                    OnDelete(DeleteBehavior.SetNull);
            //SeatSectionLevelRoom
            modelBuilder.Entity<SeatSectionLevelRoom>()
                .HasKey(c => new { c.SeatId, c.SectionId, c.LevelId, c.RoomId });
            modelBuilder.Entity<SeatSectionLevelRoom>()
                .HasOne(c => c.Seat)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<SeatSectionLevelRoom>()
                .HasOne(c => c.Section)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<SeatSectionLevelRoom>()
                .HasOne(c => c.Level)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<SeatSectionLevelRoom>()
                .HasOne(c => c.Room)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
            //FilmFilmStaffMemberFilmRol
            modelBuilder.Entity<FilmFilmStaffMemberFilmRol>()
                .HasKey(c => new { c.FilmId, c.FilmStaffMemberId, c.FilmRolId});
            modelBuilder.Entity<FilmFilmStaffMemberFilmRol>()
                .HasOne(c => c.Film)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<FilmFilmStaffMemberFilmRol>()
                .HasOne(c => c.FilmStaffMember)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<FilmFilmStaffMemberFilmRol>()
                .HasOne(c => c.FilmRol)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
            //Reservation
            modelBuilder.Entity<Reservation>()
                .HasOne(c => c.FilmScreening)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Reservation>()
                .HasOne(c => c.Seat)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
            //PurchaseOrder
            modelBuilder.Entity<PurchaseOrder>()
                .HasMany(c => c.Items)
                .WithOne()
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<PurchaseOrder>()
                .HasOne(c => c.User)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<PurchaseOrder>()
                .Property(e => e.State)
                .HasConversion(
                    v => v.ToString(),
                    v => (StatePurchaseOrder)Enum.Parse(typeof(StatePurchaseOrder), v));

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
        public DbSet<FilmFilmRol> FilmFilmRols { get; set; }
        public DbSet<FilmScreening> FilmScreenings { get; set; }
        public DbSet<FilmGenre> FilmGenres { get; set; }
        public DbSet<UserFilm> UserFilms { get; set; }
        public DbSet<FilmScreeningPriceModification> FilmScreeningPriceModifications { get; set; }
        public DbSet<SeatSectionLevelRoom> SeatSectionLevelRooms { get; set; }
        public DbSet<FilmFilmStaffMemberFilmRol> FilmFilmStaffMemberFilmRols { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }



    }
}
