using System;
using System.Collections.Generic;
using System.Text;
using FlyAway.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlyAway.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Administrator2> Administrator { get; set; }
        public DbSet<Avion> Avion { get; set; }
        public DbSet<Destinacija> Destinacija { get; set; }
        public DbSet<Karta> Karta { get; set; }
        public DbSet<Let> Let { get; set; }
        public DbSet<Putnik> Putnik { get; set; }
        public DbSet<Recenzija> Recenzija { get; set; }
        public DbSet<Rezervacija> Rezervacija { get; set; }
        public DbSet<Korisnici> Korisnici { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator2>().ToTable("Administrator");
            modelBuilder.Entity<Avion>().ToTable("Avion");
            modelBuilder.Entity<Destinacija>().ToTable("Destinacija");
            modelBuilder.Entity<Karta>().ToTable("Karta");
            modelBuilder.Entity<Let>().ToTable("Let");
            modelBuilder.Entity<Putnik>().ToTable("Putnik");
            modelBuilder.Entity<Recenzija>().ToTable("Recenzija");
            modelBuilder.Entity<Rezervacija>().ToTable("Rezervacija");
            modelBuilder.Entity<Korisnici>().ToTable("Korisnici");
            base.OnModelCreating(modelBuilder);
        }

    }
}
