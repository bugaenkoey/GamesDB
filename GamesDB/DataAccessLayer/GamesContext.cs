using GamesDB.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace GamesDB.DataAccessLayer
{
    public class GamesContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public GamesContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Integrated Security=True;"
            // optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Database=EF_Games2;Integrated Security=True;");
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EF_GamesDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
          
           modelBuilder.Entity<Game>().HasData(new Game() { Id = -1, Name = "DOOM", DateRelease = new DateTime(1993, 1, 1), Company = "id Software", Style = "шутера от первого" });
           modelBuilder.Entity<Game>().HasData(new Game() { Id = -2, Name = "DOOM2", DateRelease = new DateTime(1994, 1, 1), Company = "id Software", Style = "шутера от первого" });
           modelBuilder.Entity<Game>().HasData(new Game() { Id = -3, Name = "Civilization II", DateRelease = new DateTime(1994, 1, 1), Company = "MicroProse", Style = "пошаговая стратегия" });
           modelBuilder.Entity<Game>().HasData(new Game() { Id = -4, Name = "F29 Retaliator", DateRelease = new DateTime(1989, 1, 1), Company = "Ocean Software", Style = "авиасимулятор" });

           
        }
    }
}
